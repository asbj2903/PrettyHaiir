using DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer
{
	public class Program
	{
		static void Main(string[] args)
		{
            
            // STUB TEST KODE 
            Customer test = new Customer();

			test.CustomerID = 41;
			test.Customer_Name = "TestNavn";
			test.Customer_Address = "TestAdresse";
			test.Customer_Zip = 5000;
			test.Customer_Town = "odense";
			test.Customer_PhoneNumber = 23232323;

            DatabaseController databaseController = new DatabaseController();

            databaseController.OPRET_KUNDE(test);
            
		}
	}
}
