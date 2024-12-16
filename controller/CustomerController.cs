

using bookRent.models;
using bookRent.service;

namespace bookRent.controller
{
    internal class CustomerController
    {
        ICustomerService icustomerService = new CustomerService();

        public void saveCustomer(string custName, string custSur, string custPass, string custMail)
        {
            icustomerService.saveCustomer(custName, custSur, custPass, custMail);
        }

        public bool customerListInfo()
        {
            return icustomerService.customerListInfo();
        }

        public Customer customerChangeInfo(string custName, string custSur, string custPass, string custMail)
        {
            return icustomerService.customerChangeInfo (custName, custSur, custPass,custMail);
        }

        public void listBooks()
        {
            icustomerService.listBooks();
        }

        public bool rentBookRequest(int pick)
        {
            return icustomerService.rentBookRequest(pick);
        }

        public void seeRentedBooks()
        {
            icustomerService.seeRentedBooks();
        }
    }
}

