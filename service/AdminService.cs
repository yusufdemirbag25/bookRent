

using bookRent.models;
using bookRent.repo;

namespace bookRent.service
{
    internal class AdminService : IAdminService

    {
        Book book = new Book();
        BookDB bookDB = new BookDB();
        Admin admin = new Admin();
        AdminDB adminDB = new AdminDB();
        CustomerDB customerDB = new CustomerDB();
        Customer customer = new Customer();
        public void addBook(string bookName, int pageCount, string writer, int bookStock)
        {
            book.bookName = bookName;
            book.pageCount = pageCount;
            book.writer = writer;
            book.bookStock = bookStock;
            bookDB.addBook(book);


        }


        public void adminAdd(string mail, string password)
        {
            admin.adminMail = mail;
            admin.adminPass = password;
            adminDB.addAdmin(admin);
        }

        public Admin updateAdmin(string mail, string password)
        {
            foreach (Admin admins in adminDB.admins)
            {

                if (admin.adminMail == mail)
                {
                    admin.adminMail = mail;
                    admin.adminPass = password;
                }
            }
            return admin;
        }

        public Customer updateCustMail(string mail)
        {
            foreach (Customer cust in customerDB.customerList)
            {

                if (customer.custMail == mail)
                {
                    customer.custMail = mail;
                }
            }
            return customer;
        }

        public Book updateBook(string bookName, int pageCount, string writer, int bookStock)
        {
            foreach (Book book in bookDB.bookList)
            {
                if (book.bookName == bookName)
                {
                    book.bookName = bookName;
                    book.pageCount = pageCount;
                    book.writer = writer;
                    book.bookStock = bookStock;
                }
            }
            return book;
        }

        public bool prendingRequest(int pick, bool confirm)
        {
            for (int i = 0; i < bookDB.bookList.Count; i++)
            {
                Book selectedBook = bookDB.bookList[i];


                if (i == pick)
                {
                    if (confirm)
                    {
                        Console.WriteLine("Istegi Onayladiniz");
                        customer.addIndex(selectedBook);
                    }
                }
            }
            
            return true;
        }


        public void seeRequest (List<Customer> customers, List<Book> books)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine($"User: {customer.custName}, Email: {customer.custMail}");

                foreach (var index in book.requestedBookIndexes)
                {
                    
                    if (index >= 0 && index < books.Count) 
                    {
                        var book = books[index];
                        Console.WriteLine($"  Requested Book Index: {index}, Book: {book.bookName}, Writer: {book.writer}, Page Count: {book.pageCount}, Stock: {book.bookStock}");
                    }
                }
            }
        }
    }
}

