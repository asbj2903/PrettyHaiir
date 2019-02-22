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
				value = name;
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
				value = manufacturer;
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
				value = desciption;
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
				value = price;
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
				value = minStock;
			}

		}

		private int quantity;
		public int Quantity
		{
			get { return quantity; }
			set { value = quantity; }
		}
	}
}
