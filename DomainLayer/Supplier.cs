using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
	public class Supplier
	{
		private string name;
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private string address;
		public string Address
		{
			get { return address; }
			set { address = value; }
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
