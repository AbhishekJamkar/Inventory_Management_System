using InventoryService.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace InventoryService.Order
{
    [DataContract]
    public class Order
    {
        [DataMember]
        public int orderid;

        [DataMember]
        public DateTime orderDate;

        [DataMember]
        public int amount;

        [DataMember]
        public string paymentMode;

        [DataMember]
        public Customer.Customer customer;

        [DataMember]
        public int userid;
        public Order() { }

        public Order(int orderid, DateTime orderDate, int amount, string paymentMode, Customer.Customer customer, int userid)
        {
            this.orderid = orderid;
            this.orderDate = orderDate;
            this.amount = amount;
            this.paymentMode = paymentMode;
            this.customer = customer;
            this.userid = userid;
        }
    }
}
