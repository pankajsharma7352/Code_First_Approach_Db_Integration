using DBIntegration.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBIntegration.Service.Services
{
    public interface IProductService
    {
       public void AddProduct(Product product);
       public  List<Product> GetAllProducts();

        public Product GetById(int Id);

        public void DeleteById(int Id);
        public void EditProduct(int Id,Product product);

    }
}
