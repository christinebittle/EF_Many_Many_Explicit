using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using _5204_mypassion_project_n1010101010.Models;

namespace _5204_mypassion_project_n1010101010.Controllers
{
    public class ProductDataController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/ProductData
        public IHttpActionResult GetProducts()
        {
            IEnumerable<Product> Products = db.Products.ToList();
            List<ProductDto> ProductDtos = new List<ProductDto> { };
            foreach(var product in Products)
            {
                ProductDto NewProduct = new ProductDto {
                    ProductID = product.ProductID,
                    ProductName = product.ProductName
                };

                ProductDtos.Add(NewProduct);
            }
            return Ok(ProductDtos);

        }

        // GET: api/FindProduct/5
        [ResponseType(typeof(Product))]
        public IHttpActionResult FindProduct(int id)
        {
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        /// <summary>
        /// Gets the categories associated with a particular product, alongside a status code of 200 (OK)
        /// </summary>
        /// <param name="id">The Input Product ID</param>
        /// <returns>
        /// A list of categories for the product, stored in data transfer objects.
        /// </returns>
        public IHttpActionResult GetCategoriesForProduct(int id)
        {
           
            //Retrieve by accessing the bridging table directly
            IEnumerable<ProductxCategory> PXCs = db.ProductsxCategories
                .Where(pxc=>pxc.ProductID==id)
                //.Include(pxc => pxc.Category) //This step can be necessary if you can't grab the data
                .ToList();

            List<CategoryDto> CategoryDtos = new List<CategoryDto> { };
            foreach (var PXC in PXCs)
            {
                CategoryDto NewCategory = new CategoryDto { 
                    CategoryID= PXC.Category.CategoryID,
                    CategoryName= PXC.Category.CategoryName
                };
                CategoryDtos.Add(NewCategory);

            }

            return Ok(CategoryDtos);



        }

        
    }
}