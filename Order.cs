using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.Assignment5_06
{
    class Order
    {
        private int order_id;
        private string city;
        private string cust_name;
        private bool isDelivered;
        public int Id
        {
            get { return order_id; }
            set { order_id = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string CustName
        {
            get { return cust_name; }
            set { cust_name = value; }
        }
        public bool Delivered
        {
            get { return isDelivered; }
            set { isDelivered = value; }
        }
    }
    class DeliveryInfo
    {
        static void Main(string[] args)
        {
            Order a = new Order();
            a.Id=1102341121;
            a.City = "New York";
            a.CustName = "happy";
            a.Delivered = true;
            Console.WriteLine(" order id = "+a.Id);
            Console.WriteLine(" city = "+a.City);
            Console.WriteLine(" customer Name = "+a.CustName);
            if (a.Delivered == true)
            {
                Console.WriteLine(" Order process: order is delievered");
            }
        }
    }
}
