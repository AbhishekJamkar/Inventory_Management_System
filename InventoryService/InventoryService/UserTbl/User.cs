using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace InventoryService.UserTbl
{
    [DataContract]
    public class User
    {
        [DataMember]
        public int Id;

        [DataMember]
        public string username;
        
        [DataMember]
        public string password;

        [DataMember]
        public string fullName; 

        [DataMember]
        public string phone;

        public User() {}

        public User(string username, string password, string fullName, string phone)
        {
            this.username = username;
            this.password = password;
            this.fullName = fullName;
            this.phone = phone;
        }

    }
}
