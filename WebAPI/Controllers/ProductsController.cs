using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIDemo.WebAPI.Models;
using WebAPIDemo.WebAPI.Repositories;

namespace WebAPIDemo.WebAPI.Controllers
{
    public class ProductsController : ApiController
    {
        static readonly IProductRepository repository = new ProductRepository();

        // GET api/products
        public IEnumerable<Product> GetAll()
        {
            return repository.GetAll();
        }

        // GET api/products/5
        public IHttpActionResult Get(int id)
        {
            Product item = repository.Get(id);

            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }
    }
}
