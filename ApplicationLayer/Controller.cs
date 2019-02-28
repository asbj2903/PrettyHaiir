using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer;


namespace ApplicationLayer
{
	public class Controller
	{
        DatabaseController databaseController = new DatabaseController();


        public void CreateCustomer(string customer_Name, string customer_Address, int customer_Zip, string customer_Town, int customer_Telephone)
        {
            Customer customer = new Customer {Customer_Name = customer_Name, Customer_Address = customer_Address, Customer_Zip = customer_Zip, Customer_Town = customer_Town, Customer_PhoneNumber = customer_Telephone };

            databaseController.OPRET_KUNDE(customer);

        }

        public string GetCustomer(int customerID)
        {
            Customer customer = new Customer { CustomerID = customerID };

            return databaseController.FindCustomerByCustomerID(customerID);

            
        }

        public void CreateOrder(DateTime order_Date, DateTime delivery_Date,int order_Picked, int customerID)
        {
            Order order = new Order { Order_Date = order_Date, Order_DeliveryDate = delivery_Date, Order_Picked = order_Picked, Order_CustomerID = customerID };

            databaseController.CreateOrder(order);
        }
	}

}
