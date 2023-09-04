using CustomConsole;

namespace LibraryCatalogSystem
{
	internal class Program
	{
		public static Dictionary<ulong, Book> Catalog { get; private set; } = Book.PresetLibrary;
		static void Main(string[] args)
		{

			SearchManager.SearchByTitle("The", Catalog, out Dictionary<ulong, Book> results);

			ConsoleHelper.UserEndProgram();
		}
	}
}