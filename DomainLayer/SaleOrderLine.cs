using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
	public class SaleOrderLine
	{
		private int quantity;//ssdfsdf
		public int Quantity
		{
			get { return quantity; }
			set { quantity = value; }
		}

		private double price;
		public double Price
		{
			get { return price; }
			set { price = value; }
		}
	}
}
