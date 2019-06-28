using System;
using System.Collections.Generic;
using ProductsService.ViewModels;

namespace ProductsService.Services
{
    public class ProductsDataService : IProductsDataService
    {
        private List<ProductModel> allProducts;

        public ProductsDataService()
        {
            allProducts = new List<ProductModel>
            {
                new ProductModel
                {
                    Id = 1,
                    Name = "Product 1",
                    Description = "This is product 1",
                    Price = 100,
                    Quantity = 10
                },
                new ProductModel
                {
                    Id = 2,
                    Name = "Product 2",
                    Description = "This is product 2",
                    Price = 200,
                    Quantity = 20
                },
                new ProductModel
                {
                    Id = 3,
                    Name = "Product 3",
                    Description = "This is product 3",
                    Price = 300,
                    Quantity = 30
                },
            };
        }

        public IEnumerable<ProductModel> GetAllProducts()
        {
            return allProducts;
        }

        public ProductModel GetProductById(int productId)
        {
            return allProducts.Find(product => product.Id == productId);
        }

        public ProductModel UpdateProduct(int productId, ProductModel dirtyProduct)
        {
            var foundProduct = allProducts.Find(product => product.Id == productId);
            if (foundProduct == null)
            {
                return null;
            }
            foundProduct.Name = dirtyProduct.Name;
            foundProduct.Description = dirtyProduct.Description;
            foundProduct.Price = dirtyProduct.Price;
            foundProduct.Quantity = dirtyProduct.Quantity;

            return foundProduct;
        }

        public ProductModel AddProduct(ProductModel newProduct)
        {
            newProduct.Id = allProducts.Count + 1;

            allProducts.Add(newProduct);
            return newProduct;
        }

        public bool DeleteProduct(int productId)
        {
            var foundProduct = allProducts.Find(product => product.Id == productId);
            if (foundProduct == null)
            {
                return false;
            }
            allProducts.Remove(foundProduct);
            return true;
        }
    }
}
