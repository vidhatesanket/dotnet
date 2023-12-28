using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HRPortal.Models;
using System.ComponentModel.DataAnnotations;
namespace HRPortal.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult RegisterEmp(){

        return View();
    }
    [HttpPost]
    public IActionResult RegisterEmp(string name, string pwd){
        
        Console.WriteLine("register");
        return View();
    }
 
    public IActionResult Login(){
        return View();
    }

   [HttpPost]
    public IActionResult Login(string name, string pwd){
        Console.WriteLine(name +" "+pwd);
        if (name == "somesh" && pwd == "kudal"){
            return this.RedirectToAction("Welcome");
        }
        return View();
    }

    public IActionResult Welcome()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
