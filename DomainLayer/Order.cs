using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
	public class Order
	{
		private DateTime orderDate;
		public DateTime Orderdate
		{
			get { return orderDate; }
			set { value = orderDate; }
		}

		private DateTime deliveryDate;

		public DateTime DeliveryDate
		{
			get { return deliveryDate; }
			set { value = deliveryDate; }
		}

		private bool picked;

		public bool Picked
		{
			get { return picked; }
			set { value = picked; }
		}

	}
}
