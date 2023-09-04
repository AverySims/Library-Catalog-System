using CustomConsole;
using GenericParse;

namespace LibraryCatalogSystem;

public static class SearchManager
{
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

		if (results.Keys.Count < 1)
		{
			ConsoleHelper.PrintBlank();
			Console.WriteLine("Couldn't find any books with that title.");
		}
		else
		{
			ConsoleHelper.PrintBlank();
			Console.WriteLine("Found the following book(s):");
			for (int i = 0; i < results.Values.Count; i++)
			{
				Console.WriteLine($"ISBN: {results.Keys.ToArray()[i]}, Title: {results.Values.ToArray()[i].Title}, Author: {results.Values.ToArray()[i].Author}, Status: {results.Values.ToArray()[i].Status}");
			}
		}
		/*
		 *
		Console.WriteLine("Enter a title to search for:");
		string title = Console.ReadLine();
		Console.WriteLine($"Searching for {title}...");
		ConsoleHelper.PrintBlank();
		List<Book> results = new List<Book>();
		foreach (Book book in Book.PresetLibrary.Values)
		{
			if (book.Title.Contains(title))
			{
				results.Add(book);
			}
		}
		if (results.Count == 0)
		{
			Console.WriteLine("No results found.");
		}
		else
		{
			Console.WriteLine($"Found {results.Count} results:");
			ConsoleHelper.PrintBlank();
			foreach (Book book in results)
			{
				Console.WriteLine($"Title: {book.Title}");
				Console.WriteLine($"Author: {book.Author}");
				Console.WriteLine($"ISBN: {book.ISBN}");
				Console.WriteLine($"Status: {book.Status}");
				ConsoleHelper.PrintBlank();
			}
		}
		 */
	}
}