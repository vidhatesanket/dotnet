using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using webapp.Models;
using Catalog;
namespace webapp.Controllers;

public class SampleController: Controller
{
    private readonly ILogger<SampleController> _logger;

    public SampleController(ILogger<SampleController> logger)
    {
        _logger = logger;
    }

    
    public  IActionResult ProductDetails(){
        Product p= new Product();
        p.Id=34;
        p.Price=453;
        p.Qty=45;
        p.Name="Rose";
        ViewData["sampleabc"]=p;
        return View();

    }


}
