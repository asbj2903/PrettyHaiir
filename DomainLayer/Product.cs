using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
	public class Product
	{
		private string name;
		public string Name
		{
			get
			{
				return name;
			}
			set
			{
				name = value;
			}
		}

		private string manufacturer;
		public string Manufacturer
		{
			get
			{
				return manufacturer;
			}
			set
			{
                manufacturer = value;
			}
		}

		private string desciption;
		public string Description
		{
			get
			{
				return desciption;
			}
			set
			{
				 desciption=value ;
			}
		}

		private double price;
		public double Price
		{
			get
			{
				return price;
			}
			set
			{
				 price = value;
			}
		}

		private int minStock;
		public int MinStock
		{
			get
			{
				return minStock;
			}
			set
			{
                minStock= value;
			}

		}

		private int quantity;
		public int Quantity
		{
			get { return quantity; }
			set { quantity = value; }
		}
	}
}
