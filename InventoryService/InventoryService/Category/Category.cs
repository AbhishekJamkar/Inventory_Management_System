using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace InventoryService.Category
{
    [DataContract]
    public class Category
    {
        [DataMember]
        public int id;

        [DataMember]
        public string Catname;

        [DataMember]
        public string Description;

        public Category() { }

        public Category(int id, string catname, string description)
        {
            this.id = id;
            Catname = catname;
            Description = description;
        }
    }
}
