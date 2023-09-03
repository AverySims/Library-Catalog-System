using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCatalogSystem
{
	enum BookStatus
	{
		Available,
		CheckedOut
	}

	internal class Book
	{
		// Properties
		public int ISBN { get; set; }
		public string Title { get; set; }
		public string Author { get; set; }
		public BookStatus Status { get; set; }

		// Constructor
		public Book(int isbn, string title, string author, BookStatus status)
		{
			ISBN = isbn;
			Title = title;
			Author = author;
			Status = status;
		}
	}
}