
using bookRent.models;

namespace bookRent.repo
{
    internal class BookDB
    {
        public  List<Book> bookList = new List<Book>();

        public void addBook (Book book)
        {
            bookList.Add(book);
        }
    }
}
