using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BOL;
using DAL;
using System.ComponentModel.DataAnnotations;
namespace PlainWebAPI.Controllers;
[ApiController]
[Route("[controller]")]

public class PlayerController : Controller{
    private readonly ILogger<PlayerController> _logger;

    public PlayerController(ILogger<PlayerController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Player> GetPlayers(){
        List<Player> plist=DBManager.getall();
        return plist.ToArray();
    }

    public IActionResult Welcome(){
        
        return View();
    }
}