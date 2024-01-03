// using Microsoft.AspNetCore.Mvc;
// using BOL;
// using DAL;


// public class PlayerController : Controller{
//     private readonly ILogger<PlayerController> _logger;

//     public PlayerController(ILogger<PlayerController> logger)
//     {
//         _logger = logger;
//     }
//     public IActionResult PlayerList(){
//         List<Player> plist=DBManager.GetAll();
//         ViewData["player"]=plist;
//         return View();
//     }
//     // public IActionResult Edit(){
//     //    return View();
//     // }
//     // [HttpPost]
//     // public IActionResult Edit(int id,string name,string skills){
//     //     // int tempid=int.Parse(id);
//     //     DBManager.update(id,name,skills);
//     //    return View();

//     // }

//     // public IActionResult Insert(){
//     //    return View();
//     // }
//     // [HttpPost]
//     // public IActionResult Insert(int id,string name,string skills){
//     //     // int tempid=int.Parse(id);
//     //     DBManager.insert(id,name,skills);
//     //    return View();

//     // }


//     // public IActionResult Delete(){
//     //    return View();
//     // }
//     // [HttpPost]
//     // public IActionResult Delete(int id){
//     //     Console.WriteLine(id);

//     //    return View(id);

//     // }
  



// }