using ASP_Task1_Product.Models;
using Microsoft.AspNetCore.Mvc;
namespace ASP_Task1_Product.Controllers;

public class ProductController:Controller
{
    private static List<Product> _products;

    static ProductController()
    {
        string imagePath = "/Images/fruit.png";
        _products = new()
        {
            new Product(1,imagePath, "Product 1", "0.70$"),
            new Product(2,imagePath, "Product 2", "0.75$"),
            new Product(3,imagePath, "Product 3", "0.80$"),
            new Product(4,imagePath, "Product 4", "0.85$"),
            new Product(5,imagePath, "Product 5", "0.90$"),
            new Product(6,imagePath, "Product 7", "1.00$"),
            new Product(7,imagePath, "Product 8", "1.05$"),
            new Product(8,imagePath, "Product 9", "1.10$"),
            new Product(9,imagePath, "Product 6", "0.95$"),
            new Product(10,imagePath, "Product 10", "1.15$"),
            new Product(11,imagePath, "Product 11", "1.20$"),
            new Product(12,imagePath, "Product 12", "1.25$"),
            new Product(13,imagePath, "Product 13", "1.30$"),
            new Product(14,imagePath, "Product 14", "1.35$"),
            new Product(15,imagePath, "Product 15", "1.40$"),
            new Product(16,imagePath, "Product 16", "1.45$"),
            new Product(17,imagePath, "Product 17", "1.50$"),
            new Product(18,imagePath, "Product 18", "1.55$"),
            new Product(19,imagePath, "Product 19", "1.60$"),
            new Product(20,imagePath, "Product 20", "1.65$")
        };
    }
    public IActionResult Index()
    {
        return View(_products);
    }
    
    public IActionResult GetById(int id)
    {
        var product = _products.FirstOrDefault(p => p.product_id == id);
        if (product == null)
        {
            return View("404");
        }
        return View(product);
    }

    public IActionResult DeleteById(int id)
    {
        var product = _products.FirstOrDefault(p => p.product_id == id);
        if (product != null)
        {
            _products.Remove(product);
            return RedirectToAction("Index");
        }
        return View("404");
    }
}
