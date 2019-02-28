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
            DatabaseController DBC = new DatabaseController();

            Order order = new Order();

            order.Order_Date =  DateTime.Parse("20.12.2019");
            order.Order_DeliveryDate = DateTime.Parse("23.12.2019");
            order.Order_Picked = 1;
            order.Order_CustomerID = 1;

            DBC.CreateOrder(order);


        }
	}
}
