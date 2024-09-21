using System.Numerics;
using System.Reflection;

namespace Product.Models
{
    public class ProductsBL
    {
        List<Products> products;

        public ProductsBL()
        {
            products = new List<Products>();

            products.Add(new Products()
            {
                Id = products.Count+1,
                Name = "iphone",
                Description = "Mobile phone.",
                ImageUrl = "iphone.jpg",
                Price = 10000m 
            });
            products.Add(new Products()
            {
                Id = products.Count + 1,
                Name = "tv",
                Description = "tv screen",
                ImageUrl = "tv.jpg",
                Price = 15000m
            });

            products.Add(new Products()
            {
                Id = products.Count + 1,
                Name = "laptop",
                Description = "lap top divce",
                ImageUrl = "laptop.jpg",
                Price = 30000m
            });

        }

        public List<Products> GetAllProducts()
        {

            return products;
        }

        public Products GetProductById(int id)
        {

            return products.FirstOrDefault(product => product.Id == id); 

        }










    }
}
