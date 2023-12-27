using System.Data.Common;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using webapp.Models;

using BLL;
using BOL;
// namespace webapp.Controllers;

public class ProductsController : Controller
{
    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

    public IActionResult ShowProducts()
    {

         CatalogManager c=new CatalogManager();
        List<Product> pr= c.GetAllProducts();
        ViewData["products"]=pr;
        return View();
    }

    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
