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


		private string name;
		public string Name
		{
			get { return name; }
			set { value = name; }
		}

		private string address;
		public string Address
		{
			get { return address; }
			set { value = address; }
		}

		private int zip;
		public int Zip
		{
			get { return zip; }
			set { value = zip; }
		}

		private string town;
		public string Town
		{
			get { return town; }
			set { value = town; }
		}

		private int phoneNumber;


		public int PhoneNumber
		{
			get { return phoneNumber; }
			set { value = phoneNumber; }
		}
	}
}
