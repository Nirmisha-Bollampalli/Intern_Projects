import java.util.ArrayList;
import java.util.HashMap;


public class Scraper {
	public static void main(String[] args) {
		
		if (args.length == 0 || args.length > 2) {
			System.out.println("Please input valid parameters.");
			return;
		}
		
		FetchAndDisplay fc = new FetchAndDisplay();
		
		if (args.length == 1) {
			int num_results = fc.Query1(args[0]);
			if (num_results == 0) {
				System.out.println("No results found.");
			} else {
				System.out.println("Number of results: " + num_results);
			}
		}
		
		
		if (args.length == 2) {
			try {
				int number = Integer.parseInt(args[1]);
				if (number <= 0) {
					System.out.println("Please Provide a valid page number.");
					System.exit(0);
				}

				String page_link = fc.findPage(args[0], number);
				
				HashMap<Integer,ArrayList<String>> Result = new HashMap<Integer,ArrayList<String>>();
				Result = fc.Query2(page_link);
				if(Result.isEmpty())
					System.out.println("Page Not Found");
				else
					fc.PrintResult(Result);
				

			} catch (NumberFormatException nfe){
				System.out.println("Give an integer value to the second parameter.");
				return ;
			}
		}
		
		
	}
}
