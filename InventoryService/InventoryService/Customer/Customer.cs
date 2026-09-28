using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace InventoryService.Customer
{
    [DataContract]
    public class Customer
    {
        [DataMember]
        public int Id;

        [DataMember]
        public string name;

        [DataMember]
        public string phone;

        public Customer() { }

        public Customer(int id, string name, string phone)
        {
            Id = id;
            this.name = name;
            this.phone = phone;
        }
    }
}
