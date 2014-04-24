using System;
using System.Collections.Generic;
using WebAPIDemo.WebAPI.Models;

namespace WebAPIDemo.WebAPI.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> products = new List<Product>();
        private int _nextId = 1;

        public ProductRepository()
        {
            var airtime = new Product { Name = "Airtime", };
            var vodacom = new Product { Name = "Vodacom" };
            var mtn = new Product { Name = "MTN" };
            var talk100 = new Product { Name = "Talk 100" };
            var talk200 = new Product { Name = "Talk 200" };
            var mtnChoice100 = new Product { Name = "MTN Choice 100" };
            var mtnChoice200 = new Product { Name = "MTN Choice 200" };

            Add(airtime);
            Add(vodacom, airtime);
            Add(mtn, airtime);
            Add(talk100, vodacom);
            Add(talk200, vodacom);
            Add(mtnChoice100, mtn);
            Add(mtnChoice200, mtn);
        }

        private void Add(Product item)
        {
            Add(item, null);
        }

        private void Add(Product item, Product parentItem)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.Id = _nextId++;
            item.ParentId = parentItem != null ? parentItem.Id : (int?)null;
            products.Add(item);
        }

        public IEnumerable<Product> GetAll()
        {
            return products;
        }

        public Product Get(int id)
        {
            return products.Find(p => p.Id == id);
        }
    }
}