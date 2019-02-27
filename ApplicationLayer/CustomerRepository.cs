using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer;

namespace ApplicationLayer
{
	public class CustomerRepository
	{
        Customer customer = new Customer();

        public Customer AddCustomer(string CustomerName, string CustomerAddress, int CustomerZip, string CustomerTown, int CustomerTelephone)
		{
            
            customer.Customer_Name = CustomerName;
            customer.Customer_Address = CustomerAddress;
            customer.Customer_Zip = CustomerZip;
            customer.Customer_Town = CustomerTown;
            customer.Customer_PhoneNumber = CustomerTelephone;

            return customer;
		}
	}
}
