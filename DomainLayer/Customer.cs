using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
	public class Customer
	{
		private int customerID;
		public int CustomerID
		{
			get { return customerID; }
			set { customerID = value; }
		}


		private string customer_Name;
		public string Customer_Name
		{
			get { return customer_Name; }
			set { customer_Name = value; }
		}

		private string customer_Address;
		public string Customer_Address
		{
			get { return customer_Address; }
			set {customer_Address = value; }
		}

		private int customer_Zip;
		public int Customer_Zip
		{
			get { return customer_Zip; }
			set { customer_Zip = value; }
		}

		private string customer_Town;
		public string Customer_Town
		{
			get { return customer_Town; }
			set { customer_Town = value; }
		}

		private int customer_PhoneNumber;

		public int Customer_PhoneNumber
        {
			get { return customer_PhoneNumber; }
			set { customer_PhoneNumber = value; }
		}
	}
}
