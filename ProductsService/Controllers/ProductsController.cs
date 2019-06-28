using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductsService.Services;
using ProductsService.ViewModels;

namespace ProductsService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsDataService service;
        public ProductsController(IProductsDataService service)
        {
            this.service = service;
        }

        // GET api/products
        [HttpGet]
        public ActionResult<IEnumerable<ProductModel>> Get()
        {
            return new ObjectResult(service.GetAllProducts());
        }

        // GET api/products/5
        [HttpGet("{productId}")]
        public ActionResult<ProductModel> Get(int productId)
        {
            return new ObjectResult(service.GetProductById(productId));
        }

        // POST api/products
        [HttpPost]
        public ActionResult<ProductModel> Post([FromBody] ProductModel newProduct)
        {
            return new ObjectResult(service.AddProduct(newProduct));
        }

        // PUT api/products/5
        [HttpPut("{productId}")]
        public ActionResult<ProductModel> Put(int productId, [FromBody] ProductModel dirtyProduct)
        {
            var foundProduct = service.UpdateProduct(productId, dirtyProduct);
            if(foundProduct == null)
            {
                return new NotFoundObjectResult(productId);
            }
            return foundProduct;
        }

        // DELETE api/products/5
        [HttpDelete("{productId}")]
        public ActionResult Delete(int productId)
        {
            var isDeleted = service.DeleteProduct(productId);
            if (!isDeleted)
            {
                return new NotFoundObjectResult(productId);
            }
            return Ok();
        }
    }
}
