using DBIntegration.Db.Context;
using DBIntegration.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBIntegration.Service.Services
{
    public class ProductService : IProductService
    {
        private readonly ProductDbContext _dbContext;

        public ProductService(ProductDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddProduct(Product product)
        {
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
        }

        public List<Product> GetAllProducts()
        {
            return _dbContext.Products.ToList();
        }

        public Product GetById(int Id)
        {
            var p=  _dbContext.Products.Where(p=>p.Id==Id).SingleOrDefault();
            return p;
        }

        public void DeleteById(int Id)
        {
            var p = _dbContext.Products.Where(p => p.Id == Id).SingleOrDefault();
            if (p != null)
            {
                _dbContext.Products.Remove(p);
                _dbContext.SaveChanges();
  
            }
           
        }

        public void  EditProduct(int Id, Product product)
        {
            var p= _dbContext.Products.Where(product => product.Id ==Id).SingleOrDefault();
            if (p != null)
            {
                p.Name = product.Name;
                p.Price = product.Price;
                _dbContext.SaveChanges();
            }

        }


    }

 }

