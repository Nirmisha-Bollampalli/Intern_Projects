import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.MalformedURLException;
import java.net.ProtocolException;
import java.net.URL;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.Iterator;
import java.util.Map;
import java.util.TreeMap;

import org.jsoup.Jsoup;
import org.jsoup.nodes.Document;
import org.jsoup.nodes.Element;
import org.jsoup.select.Elements;

public class FetchAndDisplay {
	
	public String GetContent(String url) {
		HttpURLConnection connection = null;
		BufferedReader rd = null;
		StringBuilder sb = null;
		String line = null;
		String jsp = null;
		URL serverAddress = null;

		try {
			
			/*** Establish Connection *****/
			serverAddress = new URL(url);
			connection = null;
			connection = (HttpURLConnection) serverAddress.openConnection();
			connection.setRequestMethod("GET");
			connection.setDoOutput(true);
			connection.setReadTimeout(10000);
			connection.connect();

			/*** Read from the server ******/
			rd = new BufferedReader(new InputStreamReader(
					connection.getInputStream()));
			sb = new StringBuilder();

			while ((line = rd.readLine()) != null) {
				if (!line.trim().equals("")) {
					sb.append(line + '\n');
				}
			}

			jsp = sb.toString().trim();

			return jsp;
		} catch (MalformedURLException e) {
			e.printStackTrace();
			System.out.println("MalformedURLException!");
			return null;
		} catch (ProtocolException e) {
			e.printStackTrace();
			System.out.println("ProtocolException!");
			return null;
		} catch (IOException e) {
			e.printStackTrace();
			System.out.println("IOException!");
			return null;
		} finally {
			/*** Close Connection and set objects to null ****/
			connection.disconnect();
			rd = null;
			sb = null;
			connection = null;

		}
	}

	
	public int Query1(String keywords) {
		
		keywords = keywords.replace(" ", "%20");
		String url = "http://www.shopping.com/products?CLT=SCH&KW="
				+ keywords;
		String jsp = GetContent(url);
		//System.out.println(url);

		if (jsp == null) {
			System.out.println("Failed to retrieve web page.");
			return 0;
		}

		/*** Calculate Total Number of Results ****/
		Document doc = Jsoup.parse(jsp);
		Elements num_results = doc.getElementsByClass("numTotalResults");
		for (Element el : num_results) {
			String text = el.text();
			int start_index = text.indexOf("of ");
			start_index += 3;
			String number = text.substring(start_index);
			number = number.replace("+", "");
			return Integer.parseInt(number);
		}

		return 0;
	}
	
	
	public String findPage(String keywords, int number) {

		keywords = keywords.replace(" ", "%20");
		String start = "http://www.shopping.com/products~PG-"+number+"?KW="+ keywords;
		return start;

	}
	
	public HashMap<Integer, ArrayList<String>> Query2(String url) {
		
		
		String jsp = GetContent(url);
		if (jsp == null) {
			System.out.println("Failed to retrieve web page.");
			System.exit(0);
		}

		Document doc = Jsoup.parse(jsp);
		int num = doc.getElementsByClass("gridItemTop").size();
		final HashMap<Integer ,ArrayList<String>> Result = new HashMap<Integer,ArrayList<String>>();
		
		for (int i = 1; i <= num; i++) {
			
			
			ArrayList<String> ProductInfo = new ArrayList<String>();
			
			//Title
			Element title = doc.getElementById("nameQA"+i);
			ProductInfo.add("Product Title : " + title.attr("title"));
		
			//Product Price
			Element price = doc.getElementById("priceClickableQA"+i);
			if(price == null){
				price = doc.getElementById("priceProductQA"+i);
			}
			ProductInfo.add("Product Price : " + price.text());
			
			
			
			Elements ShipPrice_Vendor = doc.getElementById("quickLookItem-"+i).getAllElements() ;

			for(Element elem : ShipPrice_Vendor){
				
				//Shipping Price
				if(elem.hasClass("gridItemBtm")){
					for(Element elemm : elem.children()){


						if(elemm.hasClass("noCalc"))
							ProductInfo.add("Shipping Price : Free Shipping");
							
						else if(elemm.hasClass("calc"))
							ProductInfo.add("Shipping Price : "+elemm.text().replaceAll("[+a-zA-Z\\s]",""));
						
						else if(elemm.hasClass("freeShip"))
							ProductInfo.add("Shipping Price : Free Shipping");
						
						else if(elemm.hasClass("missCalc"))
							ProductInfo.add("Shipping Price : No Shipping Info");
						
						else if(elemm.hasClass("taxShippingArea")){
							for(Element elemmm : elemm.children()){
								
								if(elemmm.hasClass("noCalc"))
									ProductInfo.add("Shipping Price : Free Shipping");
								
								else if(elemmm.hasClass("calc"))
									ProductInfo.add("Shipping Price : "+elemm.text().replaceAll("[+a-zA-Z\\s]",""));
								
								else if(elemmm.hasClass("freeShip"))
									ProductInfo.add("Shipping Price : Free Shipping");
								
								else if(elemmm.hasClass("missCalc"))
									ProductInfo.add("Shipping Price : No Shipping Info");
							}

						}

					}
					
					//Vendor Information
					
					int cnt=0;
					for(Element elemm : elem.children()){
						cnt++;
						if(cnt == 3){
							if(elemm.hasAttr("href") || elemm.hasAttr("width")){
								if(elemm.children() != null){
									
									if(elemm.child(0).attr("title") != "")
										ProductInfo.add("Vendor : " +elemm.child(0).attr("title"));
									if(!elemm.child(0).text().isEmpty())
										ProductInfo.add("Vendor : " +elemm.child(0).text());
								}
								break;
							}
							
							
						}
						if(cnt == 4){
							if(elemm.hasAttr("href") || elemm.hasAttr("width")){
								if(elemm.children() != null){
									
									if(elemm.child(0).attr("title") != "")
										ProductInfo.add("Vendor : " +elemm.child(0).attr("title"));
									if(!elemm.child(0).text().isEmpty())
										ProductInfo.add("Vendor : " +elemm.child(0).text());
								}
							}
							
						}

					}
				}

			}			

			Result.put(i,ProductInfo);

		}
		return Result;

	}
	
	public void PrintResult(HashMap<Integer,ArrayList<String>> Result){
		    
		Map<Integer, ArrayList<String>> treeMap = new TreeMap<Integer, ArrayList<String>>(Result);
	    
		for (Map.Entry<Integer, ArrayList<String>> entry : treeMap.entrySet()) {
	        int key = entry.getKey();
	        ArrayList<String> value = entry.getValue();
	        for(String aString : value){
	            System.out.println(aString);
	        }
	        System.out.println();
	    }
		
	}

}
