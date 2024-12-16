
using bookRent.models;
using bookRent.repo;
using System.Reflection.Metadata;

namespace bookRent.service
{
    internal class CustomerService : ICustomerService
    {
        Customer customer = new Customer();
        CustomerDB customerDB = new CustomerDB();
        BookDB bookDB = new BookDB();
        public void saveCustomer (string custName, string custSur, string custPass, string custMail)
        {
            customer.custName = custName;
            customer.custSur = custSur;
            customer.custPass = custPass;
            customer.custMail = custMail;
        }

        public bool customerListInfo()
        {
            foreach (Customer cust in customerDB.customerList)

            {
                Console.WriteLine(cust.custName);
                Console.WriteLine(cust.custSur);
                Console.WriteLine(cust.custPass);
                Console.WriteLine(cust.custMail);

            }
            return true;
        }

        public Customer customerChangeInfo(string custName, string custSur, string custPass, string custMail)
        {
            foreach (Customer customer in customerDB.customerList)
            {


                if (customer.custMail == custMail)
                {
                    customer.custName = custName;
                    customer.custSur = custSur;
                    customer.custPass = custPass;
                   

                }
            }
            return customer;
        }

        public void listBooks()
        {
            foreach (Book books in bookDB.bookList)
            {
                for (int i = 0; i < bookDB.bookList.Count; i++)
                {
                    
                    Book book = bookDB.bookList[i]; 

                    Console.WriteLine($"Book Name: {book.bookName}");
                    Console.WriteLine($"Author: {book.writer}");
                    Console.WriteLine($"Page Count: {book.pageCount}");
                    Console.WriteLine($"Stock: {book.bookStock}");
                    Console.WriteLine("------------------------------");
                }

            }
        }

        public bool rentBookRequest(int pick)
        {
            for (int i = 0; i < bookDB.bookList.Count; i++)
            {

                if (i == pick)
                {
                    Book book = bookDB.bookList[i];

                   
                    if (book.bookStock > 0)
                    {

                        Console.WriteLine($"Sectiginiz kitap '{book.bookName}' Istek Beklemede");
                        
                        book.bookStock--;
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Uzgunuz Kitap Bitmis");
                       return false;
                    }
                }
            }
            Console.WriteLine("Yanlis Secim");
            return false;
        }

        public void seeRentedBooks ()
        {
            foreach (Book book in customer.rentedBooks)
            {
                Console.WriteLine($"Book Name: {book.bookName}, Writer: {book.writer}, Page Count: {book.pageCount}");
            }
        }
    }
}
