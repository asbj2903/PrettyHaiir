using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
	public class Product
	{
		
		public string Product_Name
		{
            get; set;
		}

		public string Product_Manufacturer
		{
            get; set;
		}

		public string Product_Description
        {
            get; set;
		}
		
		public double Product_Price
        {
            get; set;
		}
		
		public int Product_MinStock
        {
            get; set;
    	}
		
		public int Product_Quantity
        {
            get; set;
		}
	}
}
