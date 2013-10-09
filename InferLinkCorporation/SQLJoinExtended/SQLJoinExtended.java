	
	
	/**************** Logger *****************************************************************/
	
	private final static Logger logger = Logger.getLogger(SQLUtil.class .getName()); 
	static private FileHandler fileTxt;
	static private SimpleFormatter formatterTxt;

	static public void loggerSetup() throws IOException {

		try {

			logger.setLevel(Level.INFO);
			fileTxt = new FileHandler("Logging.txt");
			formatterTxt = new SimpleFormatter();
			fileTxt.setFormatter(formatterTxt);
			logger.addHandler(fileTxt);
			logger.setLevel(Level.INFO);
			
		} catch (SecurityException e1) {
			e1.printStackTrace();
		} catch (IOException e1) {
			e1.printStackTrace();
		}

	}

	/**
	 * Helper method.Mimics the SQL join operation.Additionally it allows the users to specify any 
       filtering options (regex) on the columns of the tables to be compared and joined.
	 * @param leftTable  Object of type TableMatchInfo that carries three values lefttablename,colName,regex.
	 * @param rightTable Object of type TableMatchInfo that carries three values righttablename,colName,regex.
	 * @throws SQLException
	 * @throws IOException
	 */
	
	public static String enrich(TableMatchInfo leftTable, TableMatchInfo rightTable) {

		String left = leftTable.getTable(),right=rightTable.getTable(),regex;
		int count=0,leftColCount=0,rightColCount=0,rightColIndex=0;
		String output = left+"_"+right;
        
		if( (!leftTable.getTable().isEmpty()) && (!rightTable.getTable().isEmpty())  
				&& (!rightTable.getColumn().isEmpty())  && (!leftTable.getColumn().isEmpty()) 
				&& (!leftTable.getGroup().isEmpty()) && (!rightTable.getGroup().isEmpty())){

			try {
		
				loggerSetup();
				PreparedStatement newStatement = null;
				Connection conn = SQLUtil.getNewConnection();

				/*******Drop Or Create a new output table***************************************/

				SQLUtil.executeUpdate("DROP TABLE IF EXISTS "+ output);
				logger.info("Dropping the output table and creating a new one");
				
				/**We create a third table by combining the columns of left and right tables
				 * ( i.e ) where 1 = 2 returns no rows and therefore we can just grab the schema from the inner select statement
				 * *******************************/
				
				SQLUtil.executeUpdate("CREATE TABLE "+output+" " +
						"AS (SELECT "+left+".*,"+right+".* from "+left+","+right+" where 1=2)");

				/*************count the no of columns to construct a prepared statement*************/

				ResultSet resultsetCount;				
				resultsetCount = SQLUtil.executeQuery("SELECT * FROM "+output);
				ResultSetMetaData rsmd1 = resultsetCount.getMetaData();
				count = rsmd1.getColumnCount();
				//System.out.println("count : " + count);


				SQLUtil.close(resultsetCount);
				/************Construct a prepared statement.*************************/

				String query = "INSERT INTO "+output+" values(";
				for(int i=1 ;i < count ; i++){

					query += "?,";
				}
				query += "?)";

				newStatement = conn.prepareStatement(query);



				/************* Operate on the data from left table*************/

				/** Fetch the records from first table **/

				resultSet = SQLUtil.executeQuery("SELECT * FROM "+left);

				/** Fetch the records from the second table and store it to a file on server **/

				Connection con =  SQLUtil.getNewConnection();
				Statement stmt = con.createStatement(ResultSet.TYPE_SCROLL_INSENSITIVE, ResultSet.CONCUR_READ_ONLY); 
				resultSet2 = stmt.executeQuery("SELECT * FROM "+right);

				/** Metadata helps get colcount,colnames etc. **/

				ResultSetMetaData rsmd = resultSet.getMetaData();
				leftColCount = rsmd.getColumnCount();
				String colName;
				//System.out.println("Left count : " + leftColCount);

				/** Iterate through the result list and append the values to the prepared Statement 
				 * after applying regex on the required left column **/

				while (resultSet.next()) {

					List<List<String>> rightTableInfo = new ArrayList<List<String>>();
					boolean match = false;

					for(int i=1 ; i<= leftColCount ; i++){

						colName=rsmd.getColumnName(i);

						if(colName.equals(leftTable.getColumn())){

							String link = resultSet.getString(i);
							String temp_link = link;
							//	System.out.println("Val NO REGEX : "+ link);

							/** Apply regex on the data. **/

							regex = leftTable.getRegEx();		         
							Pattern p = Pattern.compile(regex); 
							Matcher m = p.matcher(link); 
							if(m.find()) 
								temp_link = m.replaceAll(leftTable.getGroup()); 


							/******** Find a matching row from the right table for a row from the left table.***********************/
							//logger.info("Perfoming join on "+left+" & "+right+" Tables");

							if(!temp_link.isEmpty()){
								//System.out.println("Case 1");
								ArrayList<List<String>> matches = new ArrayList<List<String>>();
								matches = FindMatch(temp_link,rightTable,newStatement);

								if(!matches.isEmpty()){
									//System.out.println("Case 11");
									SortedMap<Integer,List> linkLength = new TreeMap<Integer ,List>();

									for (List entry : matches) {

										int index =(Integer) entry.get(entry.size()-1);	
										String indexVal = null;

										ArrayList row = new ArrayList();
										for(int y=0 ; y< entry.size()-1 ; y++){

											if(y == index-1)
												indexVal = (String) entry.get(y);

											row.add(entry.get(y));
										}

										linkLength.put(indexVal.length(),row); 
									}
									int in=0;
									for(int insert= leftColCount+1 ; insert <= count ; insert++ ){
										newStatement.setString(insert,(String) 
												linkLength.get(linkLength.firstKey()).get(in));
										in++;
									}

								}
								else{
									//System.out.println("Case 12");
									int in=0;
									for(int insert= leftColCount+1 ; insert <= count ; insert++ ){
										newStatement.setString(insert,null);
										in++;
									}
								}
							}
							else {
								//System.out.println("Case 2");

								int in=0;
								for(int insert= leftColCount+1 ; insert <= count ; insert++ ){
									newStatement.setString(insert,null);
									in++;
								}

							}

							newStatement.setString(i,resultSet.getString(i));
						}
						else {

							newStatement.setString(i,resultSet.getString(i));
						}

					}
					newStatement.execute();
				}
				SQLUtil.close(resultSet);
				logger.info("Operation Complete");
				newStatement.close();
				conn.close();
			}catch (SQLException e) {	
				logger.info("There is a SQL Exception.Join Failed");
				e.printStackTrace();
			} catch (IOException e) {
				e.printStackTrace();
			}

		}
		else{

			System.out.println("************Please make sure you provided values to all the following******************");
			System.out.println("Table1,Table2,Tab2_Col,Tab1_Col,regex_Tab1,regex_Tab2,groupNo1,groupNo2");

			System.out.println("\t Example : "); 
			System.out.println("\t\t Table1 = 'stratfor_users_csv'"); 
			System.out.println("\t\t Table2 = 'airforce_units'");
			System.out.println("\t\t Tab2_Col = 'unit_link'");
			System.out.println("\t\t Tab3_Col = 'mail'");
			System.out.println("\t\t regex_Tab1 = '(.*)(@)(.*)') \n\t\t regex_Tab2 = '(.*)(@)(.*))' ");
			System.out.println("\t\t groupNo1 = '$3' \n\t\tgroupNo2 = '$1'");



		}

		return output;
	}



	public static ArrayList<List<String>> FindMatch(String temp_email,TableMatchInfo rightTable
													,PreparedStatement newStatement){

		ArrayList<List<String>> matches = new ArrayList<List<String>>();
		try {

			ResultSetMetaData rsmd2 = null;
			rsmd2 = resultSet2.getMetaData();
			int rightColCount,rightColIndex = -1;
			rightColCount= rsmd2.getColumnCount();
			String colName = rightTable.getColumn();

			for (int x = 1; x <= rightColCount; x++) {
				if (colName.equals(rsmd2.getColumnName(x))) {
					rightColIndex = x;
					break;
				}
			}


			if(rightColIndex != -1){

				while(resultSet2.next()){
					String val = resultSet2.getString(rightColIndex);	

					String temp_val = null;
					String regex = rightTable.getRegEx();		         
					Pattern p1 = Pattern.compile(regex); 
					Matcher m1 = p1.matcher(val); 
					if(m1.find()) {
						int grp = Integer.valueOf(rightTable.getGroup());
						temp_val = m1.group(grp); 
					}

					if(temp_val.equals(temp_email)){

						List CurrentRowInfo = new ArrayList();

						for(int i1=1 ; i1<= rightColCount ; i1++){
							CurrentRowInfo.add(resultSet2.getString(i1));
						}
						CurrentRowInfo.add(rightColIndex);
						matches.add(CurrentRowInfo);
					}

				}

				resultSet2.first();
			}
			else{
				System.out.println("Column doesnot exist");
				System.exit(-1);
			}




		} catch (SQLException e) {
			e.printStackTrace();
		}

		return matches;
	}