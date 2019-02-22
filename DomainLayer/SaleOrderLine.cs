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
			set { value = quantity; }
		}

		private double price;
		public double Price
		{
			get { return price; }
			set { value = price; }
		}
	}
}
