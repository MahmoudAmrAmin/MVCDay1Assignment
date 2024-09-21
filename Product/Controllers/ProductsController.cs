using Microsoft.AspNetCore.Mvc;
using Product.Models;


namespace Product.Controllers
{
    public class ProductsController:Controller
    {
        // /Products/ShowAllProducts
        public IActionResult ShowAllProducts ()
        {

            ProductsBL products = new ProductsBL ();

            List<Products> resultModel = products.GetAllProducts();

            return View("showAllProducts", resultModel); 
        }


        // Products/GetProductDetails?id=1
        public IActionResult GetProductDetails(int id )
        {

            ProductsBL product = new ProductsBL ();  

            Products ProductDetailModel = product.GetProductById(id);

            return View("GetProductDetails", ProductDetailModel); 

        }







    }
}
