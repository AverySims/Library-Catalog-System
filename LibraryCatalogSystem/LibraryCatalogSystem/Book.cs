namespace LibraryCatalogSystem
{
	public enum BookStatus
	{
		Available,
		CheckedOut
	}

	public class Book
	{
		// Properties
		public ulong ISBN { get; set; }
		public string Title { get; set; }
		public string Author { get; set; }
		public BookStatus Status { get; set; }

		// Constructor
		public Book(string title, string author, BookStatus status)
		{
			// ISBN is currently not saved in the constructor,
			// but instead is used as a key in the dictionary
			Title = title;
			Author = author;
			Status = status;
		}

		public static Dictionary<ulong, Book> PresetLibrary { get; private set; } = new Dictionary<ulong, Book>
		{
			{ 9780061120084, new Book("To Kill a Mockingbird", "Harper Lee", BookStatus.Available) },
			{ 9780141439970, new Book("Pride and Prejudice", "Jane Austen", BookStatus.CheckedOut) },
			{ 9780739326225, new Book("The Da Vinci Code", "Dan Brown", BookStatus.Available) },
			{ 9780544003415, new Book("The Hobbit", "J.R.R. Tolkien", BookStatus.Available) },
			{ 9780141980803, new Book("1984", "George Orwell", BookStatus.CheckedOut) },
			{ 9781400064113, new Book("The Catcher in the Rye", "J.D. Salinger", BookStatus.Available) },
			{ 9780441172719, new Book("Dune", "Frank Herbert", BookStatus.CheckedOut) },
			{ 9780060850524, new Book("The Great Gatsby", "F. Scott Fitzgerald", BookStatus.Available) }
		};
	}
}