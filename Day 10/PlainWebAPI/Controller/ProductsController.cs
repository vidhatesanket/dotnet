using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PlainWebAPI.BOL;
using PlainWebAPI.DAL;
using System.ComponentModel.DataAnnotations;
namespace PlainWebAPI.Controllers;
[ApiController]
[Route("[controller]")]

public class ProductsController : Controller{
    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Product> func(){
        List<Product> plist=DBManager.GetAllProducts();
        return plist.ToArray();
    }



    [HttpPut] 
    public void post([FromBody]Product p) {  
        Console.WriteLine(p.Id);
        // DBManager.insertData(Id,pname,price);
    } 
   

    
    public IActionResult Welcome(){
        
        return View();
    }
}
