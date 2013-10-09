Usage of enrich method :
	
Specify the following arguments :
   Table1,Table2,Tab2_Col,Tab1_Col,regex_Tab1,regex_Tab2,groupNo1,groupNo2
Example :

		Table1 = 'table1'
		Table2 = 'table2'
		Tab2_Col = 'unit_link'
		Tab3_Col = 'mail'
		regex_Tab1 = '(.*)(@)(.*)') 
		regex_Tab2 = '(.*)(@)(.*))'
		groupNo1 = '$3'
		groupNo2 = '$1'
		
Example Test class : 
	
import java.net.MalformedURLException;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

import org.apache.solr.client.solrj.SolrServerException;

import com.inferlink.common.util.db.SQLUtil;
import com.inferlink.cybermedia.enrichment.DomainCount;
import com.inferlink.common.util.db.TableMatchInfo;
import com.inferlink.wikipediaenrichment.CategoryHarvester;

public class StratforDemo {


public static void main(String[] args) throws 
ClassNotFoundException,SQLException {


		String regex_Tab1 = 
		"(.*)(@)(.*)",regex_Tab2="http://(?:www\\.)?([^/]+)";

		
		String Table1 = 
		"table1",Table2= "table2",Tab2_Col = "unit_link", Tab1_Col="E_mail";
		String groupNo1="",groupNo2="1";

		//Set the left table properties.
		TableMatchInfo leftTable = 
		new TableMatchInfo(Table1,Tab1_Col,regex_Tab1,groupNo1);

		//Set the right table properties.
		TableMatchInfo rightTable = 
		new TableMatchInfo(Table2,Tab2_Col,regex_Tab2,groupNo2);

		//Enrich table.
		String enrichedTable;
		boolean CreateOutputTable=true;
		enrichedTable = SQLUtil.enrich(leftTable, rightTable);
		System.out.println("Table : " + enrichedTable + "is created");
}
}
	
	