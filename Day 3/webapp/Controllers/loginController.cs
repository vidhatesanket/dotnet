using System.Diagnostics;
using System.Runtime.Serialization;
using Microsoft.AspNetCore.Mvc;
using r;
using webapp.Models;

namespace webapp.Controllers;

public class LoginController : Controller
{
    private readonly ILogger<LoginController > _logger;

    public LoginController (ILogger<LoginController > logger)
    {
        _logger = logger;
    }

    public IActionResult Resume()
    {   Rsume r1=new Rsume();
       r1.Fname="Sanket";
       r1.Lname="Vidhate";
       r1.Prn="108";
       ViewData["details"]=r1;
        return View();
    }

    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
