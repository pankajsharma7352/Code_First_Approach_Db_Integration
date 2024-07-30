using DBIntegration.Model.Models;
using DBIntegration.Service.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DBIntegration.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }


        [HttpPost]
        [Route("Add")]
        public string addProduct(Product product)
        {

            _productService.AddProduct(product);
            return "Record Added Successfully";
        }

        [HttpGet]
        [Route("GetAllProduct")]
        public List<Product> getAllProduct()
        {
           return _productService.GetAllProducts();
        }

        [HttpGet("{id}")]
        public Product getById(int id)
        {
            return _productService.GetById(id);
        }


        [HttpDelete("{id}")]
        public string deleteById(int id)
        {
             _productService.DeleteById(id);
            return "Date delete successfully..";
        }

        [HttpPut("{Id}")]
        public string EditProduct(int Id,Product product)
        {

            _productService.EditProduct(Id,product);
            return "Record Edited Successfully";
        }

    }
}
