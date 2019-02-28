using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
	public class Order
	{
        private int orderID;
        public int OrderID
        {
            get { return orderID; }
            set { orderID = value; }
        }

		private DateTime order_Date;
        public DateTime Order_Date
		{
			get { return order_Date; }
			set { order_Date = value; }
		}

		private DateTime order_DeliveryDate;

		public DateTime Order_DeliveryDate
		{
			get { return order_DeliveryDate; }
			set { order_DeliveryDate = value; }
		}

		private int order_Picked;

		public int Order_Picked
		{
			get { return order_Picked; }
			set { order_Picked = value; }
		}

        private int order_CustomerID;
        public int Order_CustomerID
        {
            get; set;
        }

	}
}
