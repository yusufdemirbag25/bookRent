

using bookRent.models;
using bookRent.service;

namespace bookRent.controller
{
    internal class AdminController
    {
        AdminService adminService = new AdminService();
        
        public void addBook(string bookName, int pageCount, string writer, int bookStock)
        {
            adminService.addBook (bookName, pageCount, writer, bookStock);

        }

        public void adminAdd (string mail,string pass)
        {
            adminService.adminAdd (mail, pass);
        }

        public Admin updateAdmin(string mail, string password)
        {
            return adminService.updateAdmin (mail, password);
        }

        public Customer updateCustMail(string mail)
        {
            return adminService.updateCustMail (mail);
        }

        public Book updateBook(string bookName, int pageCount, string writer, int bookStock)
        {
            return adminService.updateBook (bookName,pageCount, writer, bookStock);
        }

        public bool prendingRequest(int pick, bool confirm)
        {
            return adminService.prendingRequest (pick, confirm);
        }

        public void seeRequest(List<Customer> customers, List<Book> books)
        {
            adminService.seeRequest (customers, books);
        }
    }
}
