using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace InventoryService.UserTbl
{
    [ServiceContract]
    public interface IUserService
    {

        [OperationContract]
        string AddUser(User user);

        [OperationContract]
        DataSet GetUserDataSet();

        [OperationContract]
        void DeleteUser(int id);

        [OperationContract]
        void UpdateUser(User user);

        [OperationContract]
        bool verifyUser(string username, string password);

        [OperationContract]
        int getUserIdByUsername(string username);
    }
}
