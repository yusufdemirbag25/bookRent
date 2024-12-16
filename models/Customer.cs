

namespace bookRent.models
{
    internal class Customer
    {
        public string custName { get; set; }
        public string custSur { get; set; }
        public string custPass { get; set; }
        public string custMail { get; set; }

       public List<Book> rentedBooks = new List<Book>();
        public void addIndex (Book book)
        {
            rentedBooks.Add (book);
        }
    }
}
