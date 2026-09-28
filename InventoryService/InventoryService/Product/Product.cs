using InventoryService.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace InventoryService.Product
{
    [DataContract]
    public class Product
    {
        [DataMember]
        public int id;

        [DataMember]
        public string ProdName;

        [DataMember]
        public string ProdDesc;

        [DataMember]
        public int price;

        [DataMember]
        public int quantity;

        [DataMember]
        public Category.Category prodCategory;

        public Product() { }

        public Product(int id, string prodName, string prodDesc, int price, int quantity, Category.Category prodCategory)
        {
            this.id = id;
            ProdName = prodName;
            ProdDesc = prodDesc;
            this.price = price;
            this.quantity = quantity;
            this.prodCategory = prodCategory;
        }
    }
}
