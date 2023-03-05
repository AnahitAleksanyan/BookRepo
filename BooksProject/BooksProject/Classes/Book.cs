using BooksProject.Enums;

namespace BooksProject.Classes
{
    public class Book
    {
        public string Name { get; set; }

        public Person Author { get; set; }

        public int PageCount { get; set; }

        public DateTime Date { get; set; }

        public Genre Genre { get; set; }
    }
}
