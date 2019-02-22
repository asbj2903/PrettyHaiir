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
			set { value = customerID; }
		}


		private string customer_Name;
		public string Customer_Name
		{
			get { return customer_Name; }
			set { customer_Name = value; }
		}

		private string address;
		public string Address
		{
			get { return address; }
			set {address = value; }
		}

		private int zip;
		public int Zip
		{
			get { return zip; }
			set { zip = value; }
		}

		private string town;
		public string Town
		{
			get { return town; }
			set { town = value; }
		}

		private int phoneNumber;


		public int PhoneNumber
		{
			get { return phoneNumber; }
			set { phoneNumber = value; }
		}
	}
}
