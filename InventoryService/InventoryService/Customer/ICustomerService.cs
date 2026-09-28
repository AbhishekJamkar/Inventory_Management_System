using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace InventoryService.Customer
{
    [ServiceContract]
    public interface ICustomerService
    {
        [OperationContract]
        void AddCustomer(Customer customer);

        [OperationContract]
        void DeleteCustomer(int id);

        [OperationContract]
        void UpdateCustomer(Customer customer);

        [OperationContract]
        DataSet GetCustomerDataset();

        [OperationContract]
        Customer GetCustomerById(int id);


    }
}
