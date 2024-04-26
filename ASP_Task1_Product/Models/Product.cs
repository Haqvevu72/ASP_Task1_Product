namespace ASP_Task1_Product.Models;

public class Product
{
    public  int product_id { get; set; }
    public string product_img { get; set; }
    public string product_name { get; set; }
    public string product_cost { get; set; }

    public Product(int product_id,string product_img , string product_name , string product_cost)
    {
        this.product_id = product_id;
        this.product_img = product_img;
        this.product_name = product_name;
        this.product_cost = product_cost;
    }
}