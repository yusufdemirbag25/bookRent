

using bookRent.models;

namespace bookRent.service
{
    internal interface IAdminService
    {
        public void addBook(string bookName, int pageCount, string writer, int bookStock);

        public void adminAdd(string mail, string password);

        public Admin updateAdmin(string mail, string password);

        public Customer updateCustMail(string mail);

        public Book updateBook(string bookName, int pageCount, string writer, int bookStock);

        public bool prendingRequest(int pick, bool confirm);

        public void seeRequest(List<Customer> customers, List<Book> books);


    }
}
