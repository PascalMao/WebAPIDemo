
namespace WebAPIDemo.WebAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; }
    }
}