using bookRent.controller;
using bookRent.models;
using bookRent.repo;
using bookRent.service;
using System.ComponentModel;

namespace bookRent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerController customerController = new CustomerController();
            AdminController adminController = new AdminController();
            BookDB bookDB = new BookDB();
            AdminDB adminDB = new AdminDB(); 

            bookDB.bookList.Add(new Book { bookName = "1984", writer = "George Orwell", pageCount = 1949, bookStock= 5 });
            bookDB.bookList.Add(new Book { bookName = "To Kill a Mockingbird", writer = "Harper Lee", pageCount = 1960 , bookStock = 0 });
            bookDB.bookList.Add(new Book { bookName = "The Great Gatsby", writer = "F. Scott Fitzgerald", pageCount = 1925, bookStock = 2 });
            adminController.adminAdd("yusufdemirbag@hotmail.com","yusuf123");


            Console.WriteLine("Kitap Kiralama Sitesine Hos Geldiniz");
            Console.WriteLine(" \n Lütfen Ilerleyebilmek Icin Giris Yapiniz Ya da Kayıt Olunuz");
            Console.WriteLine("Kayit olmak icin 1'e Giris Yapmak icin 2'ye basınız");

            int logPick = Convert.ToInt32(Console.ReadLine());

            switch (logPick)
            {
                case 1:
                    Console.WriteLine("Kayıt Ol'u sectiniz Lutfen Adınızı giriniz");
                    string customerNameSign = Console.ReadLine();
                    Console.WriteLine("Lutfen Soyadinizi giriniz");
                    string customerSurSign = Console.ReadLine();
                    Console.WriteLine("Lutfen Sifrenizi giriniz");
                    string customerPassSign = Console.ReadLine();

                    string customerMailSign = "";
                    while (true)
                    {
                        Console.WriteLine("Lutfen Mail giriniz");
                           customerMailSign = Console.ReadLine();

                        if (customerMailSign.Contains("@"))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Yanlıs veya eksik bir mail girdiniz lutfen tekrar deneyeniz. ");
                        }
                    }

                    Console.WriteLine("Basarıyla Giris Yaptiniz");

                    customerController.saveCustomer(customerNameSign, customerSurSign, customerPassSign, customerMailSign);

                    break;

                    case 2:
                    Console.WriteLine("Giris yapı sectiniz lutfen mailinizi giriniz");
                    string customerMailLog = Console.ReadLine();
                    Console.WriteLine("Lutfen sifrenizi giriniz");
                    string customerPassLog = Console.ReadLine();

                    

            }


            }
    }
}
