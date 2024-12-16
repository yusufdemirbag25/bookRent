

using bookRent.models;

namespace bookRent.repo
{
    internal class CustomerDB
    {
        Customer customer = new Customer();

        public List <Customer> customerList = new List <Customer> ();

        public void saveCustomer(Customer customer)
        {
            customerList.Add (customer);
        }


    }
}
