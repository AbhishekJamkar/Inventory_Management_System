using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace InventoryService.OrderDetails
{
    [DataContract]
    public class OrderDetails
    {
        [DataMember]
        public int id;

        [DataMember]
        public int ord_id;

        [DataMember]
        public int pro_id;

        [DataMember]
        public int prod_qty;

        [DataMember]
        public int prod_amount;
    }
}
