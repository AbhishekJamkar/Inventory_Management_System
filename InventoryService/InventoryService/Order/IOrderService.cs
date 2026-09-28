using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace InventoryService.Order
{
    [ServiceContract]
    public interface IOrderService
    {
        [OperationContract]
        void AddOrder(Order order);

        [OperationContract]
        DataSet GetAllOrder();

        [OperationContract]
        Order GetOrderById(int id);

        [OperationContract]
        DataSet GetOrdersByCust(int custId);

        [OperationContract]
        Order GetLastInsertedOrder();
    }
}
