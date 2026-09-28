using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace InventoryService.Category
{
    [ServiceContract]
    public interface ICategoryService
    {
        [OperationContract]
        void AddCategory(Category category);

        [OperationContract]
        void DeleteCategory(int id);

        [OperationContract]
        void UpdateCategory(Category category);

        [OperationContract]
        DataSet GetCategoryDataset();

        [OperationContract]
        DataTable GetCategoryDataTable();

        [OperationContract]
        Category GetCategoryById(int id);
    }
}
