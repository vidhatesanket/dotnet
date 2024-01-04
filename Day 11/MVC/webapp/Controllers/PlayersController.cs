using System.Diagnostics;
using BOL;
using DAL;
using Microsoft.AspNetCore.Mvc;
using webapp.Models;

namespace webapp.Controllers;

public class PlayerController : Controller
{
    private readonly ILogger<PlayerController> _logger;

    public PlayerController(ILogger<PlayerController> logger)
    {
        _logger = logger;
    }
    public IActionResult PlayerList(){
        List<Player> plist=DBManager.getAll();
        ViewData["pl"]=plist;
        return View();
    }

    public IActionResult Edit(int id){
        List<Player> plist=DBManager.getAll();
        Player p= plist.Find((p)=>p.id==id);
        ViewData["pl"]=p;
        return View();
    }

    [HttpGet]
    public IActionResult Update(int id,string name,string skills){
        Console.WriteLine(id+ " "+ name+ " "+skills);
         DBManager.updatePlayer(id,name,skills);
        return View();
    }
    [HttpGet]
    public IActionResult Delete(int id){
        DBManager.delete(id);
        return View();
    }
    [HttpGet]
    public IActionResult AddNew(int id,string name,string skills){
        DBManager.addPlayer(id,name,skills);
        return View();
    }
}
