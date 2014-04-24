using System.Collections.Generic;
using WebAPIDemo.WebAPI.Models;

namespace WebAPIDemo.WebAPI.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product Get(int id);
    }
}
