namespace blazor_server_app.Models;
using System.Text.Json;
using System.Text.Json.Serialization;




public class ProductModel
{
  
    public string id { get; set; }


    public string Name { get; set; }


    public double price { get; set; }


    public string img { get; set; }


    public string Description { get; set; }


    public string type { get; set; }


    public bool deleted { get; set; }
}
