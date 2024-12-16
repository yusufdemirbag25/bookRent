

using bookRent.models;

namespace bookRent.service
{
    internal interface ICustomerService
    {
        public void saveCustomer(string custName, string custSur, string custPass, string custMail);

        public bool customerListInfo();

        public Customer customerChangeInfo(string custName, string custSur, string custPass, string custMail);

        public void listBooks();

        public bool rentBookRequest(int pick);

        public void seeRentedBooks();
    }
}
