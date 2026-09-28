using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace InventoryService.OrderDetails
{
    [ServiceContract]
    public interface IOrderDetails
    {
        [OperationContract]
        void AddOrderDetails(List<OrderDetails> orderDetails);

        [OperationContract]
        DataSet GetProdutsByOrdId(int ordId);

        
    }
}
