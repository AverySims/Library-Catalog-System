using CustomConsole;
using GenericParse;

namespace LibraryCatalogSystem;

public static class SearchManager
{
	public static void PrintBooks(Dictionary<ulong, Book> books)
	{
		ConsoleHelper.PrintBlank();

		if (books.Count < 1)
		{
			Console.WriteLine("Couldn't find any books with that title.");
		}
		else
		{
			Console.WriteLine("Found the following book(s):");
			foreach (var kvp in books)
			{
				var book = kvp.Value;
				Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Status: {book.Status}, ISBN: {kvp.Key}");
			}
		}
	}
	
	public static void SearchByTitle(string title, Dictionary<ulong, Book> catalog, out Dictionary<ulong, Book> results)
	{
		// using LINQ to filter results
		results = catalog.Where(kvp => kvp.Value.Title.ToLower().Contains(title.ToLower()))
			.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
		
		/* old method
		 * 
		Book[] tempList = catalog.Values.ToArray();

		for (int i = 0; i < tempList.Length; i++)
		{
			// checking if the title matches (making both lowercase to avoid case sensitivity)
			if (tempList[i].Title.ToLower().Contains(title.ToLower()))
			{
				results.Add(catalog.Keys.ToArray()[i], tempList[i]);
			}
		}
		 */

		PrintBooks(results);
	}
	
}