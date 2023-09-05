﻿using CustomConsole;
using GenericParse;

namespace LibraryCatalogSystem;

public static class SearchManager
{
	public static void PrintBooks(Dictionary<ulong, Book> books)
	{
		if (books.Count < 1)
		{
			Console.WriteLine("Couldn't find any books with that parameter.");
		}
		else
		{
			Console.WriteLine("Found the following book(s):");
			foreach (var kvp in books)
			{
				var book = kvp.Value;
				Console.WriteLine("------------------------------------------------------------------------------------------");
				Console.WriteLine($"{book.Title} by {book.Author} | Status: {book.Status}, ISBN: {kvp.Key}");
			}
		}
	}
	
	public static void SearchByISBN(ulong isbn, Dictionary<ulong, Book> catalog, out Dictionary<ulong, Book> results)
	{
		// using LINQ to filter results
		results = catalog.Where(kvp => kvp.Key == isbn)
			.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

		PrintBooks(results);
	}
	
	public static void SearchByTitle(string title, Dictionary<ulong, Book> catalog, out Dictionary<ulong, Book> results)
	{
		// using LINQ to filter results
		results = catalog.Where(kvp => kvp.Value.Title.ToLower().Contains(title.ToLower()))
			.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

		PrintBooks(results);
	}
	
	public static void SearchByAuthor(string author, Dictionary<ulong, Book> catalog, out Dictionary<ulong, Book> results)
	{
		// using LINQ to filter results
		results = catalog.Where(kvp => kvp.Value.Author.ToLower().Contains(author.ToLower()))
			.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

		PrintBooks(results);
	}
	
}