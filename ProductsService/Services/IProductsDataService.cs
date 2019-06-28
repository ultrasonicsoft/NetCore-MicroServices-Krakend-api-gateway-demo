using System;
using System.Collections.Generic;
using ProductsService.ViewModels;

namespace ProductsService.Services
{
    public interface IProductsDataService
    {
        IEnumerable<ProductModel> GetAllProducts();
        ProductModel GetProductById(int productId);
        ProductModel AddProduct(ProductModel newProduct);
        ProductModel UpdateProduct(int productId, ProductModel dirtyProduct);
        bool DeleteProduct(int productId);

    }
}
