using DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer
{
	class Program
	{
		static void Main(string[] args)
		{

			// STUB TEST KODE 
			Customer test = new Customer();
            int CustomerID = test.CustomerID;
                       
             /*
			test.Customer_Name = "TestNavn";
			test.Address = "TestAdresse";
			test.Zip = 5000;
			test.Town = "odense";
			test.PhoneNumber = 23232323;
            */
			DatabaseController databaseController = new DatabaseController();

			databaseController.FineCustomerByCustomerID();
            Console.ReadLine();

		}
	}
}
