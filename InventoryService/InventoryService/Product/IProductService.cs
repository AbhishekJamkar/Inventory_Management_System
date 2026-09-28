using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace InventoryService.Product
{
    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        void AddProduct(Product product);

        [OperationContract]
        void DeleteProduct(int id);

        [OperationContract]
        void UpdateProduct(Product product);

        [OperationContract]
        DataSet GetProductDataSet();

        [OperationContract]
        DataSet GetProductCatDataSet(int catid);

        [OperationContract]
        Product GetProductById(int id);

        [OperationContract]
        Product GetProductByName(string name);

    }
}
