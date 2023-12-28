using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HRPortal.Models;
using dal;
using EmployeePackage;
namespace HRPortal.Controllers;
using System.Collections;
public class EmployeeController : Controller
{
    private readonly ILogger<EmployeeController> _logger;

    public EmployeeController(ILogger<EmployeeController> logger)
    {
        _logger = logger;
    }

    public IActionResult ShowEmployeeList()
    {
        List<Employee> plist=HRDBManager.getList();
        ViewData["Employees"]=plist;
        return View();
    }
    public IActionResult ShowEmployee(int id)
    {
        List<Employee> plist=HRDBManager.getList();
        var e=plist.Find((emp)=>emp.Id==id);
        return View(e);
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
