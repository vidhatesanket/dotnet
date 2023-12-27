using System.Diagnostics;
using System.Runtime.Serialization;
using Microsoft.AspNetCore.Mvc;
using play;
using r;
using webapp.Models;

namespace webapp.Controllers;

public class PlayerController : Controller
{
    private readonly ILogger<PlayerController > _logger;

    public PlayerController (ILogger<PlayerController > logger)
    {
        _logger = logger;
    }
    public IActionResult PlayerDetails(){
   
  return View();
    }

   

    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
