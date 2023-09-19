using System.Diagnostics;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using DIServiceLifetimeDemo.Models;
using DIServiceLifetimeDemo.Services;

namespace DIServiceLifetimeDemo.Controllers;

public class HomeController : Controller
{
    private readonly IScopedGuidService _scoped1;
    private readonly IScopedGuidService _scoped2;

    private readonly ITransientGuidService _transient1;
    private readonly ITransientGuidService _transient2;

    private readonly ISingletonGuidService _singleton1;
    private readonly ISingletonGuidService _singleton2;
    

    public HomeController(IScopedGuidService scoped1, 
        IScopedGuidService scoped2, 
        ITransientGuidService transient1, 
        ITransientGuidService transient2, 
        ISingletonGuidService singleton1, 
        ISingletonGuidService singleton2)
    {
        _scoped1 = scoped1;
        _scoped2 = scoped2;
        _transient1 = transient1;
        _transient2 = transient2;
        _singleton1 = singleton1;
        _singleton2 = singleton2;
    }

    public IActionResult Index()
    {
        List<string> messages = new List<string>();
        messages.Add($"Transient 1 : {_transient1.GetGuid()}");
        messages.Add($"Transient 2 : {_transient2.GetGuid()}");
        messages.Add("");
        messages.Add($"Scoped 1 : {_scoped1.GetGuid()}");
        messages.Add($"Scoped 2 : {_scoped2.GetGuid()}");
        messages.Add("");
        messages.Add($"Singleton 1 : {_singleton1.GetGuid()}");
        messages.Add($"Singleton 2 : {_singleton2.GetGuid()}");

        ViewBag.Messages = messages;
        
        return View();
    }

    public IActionResult Privacy()
    {
        List<string> messages2 = new List<string>();
        messages2.Add($"Transient 1 : {_transient1.GetGuid()}");
        messages2.Add($"Transient 2 : {_transient2.GetGuid()}");
        messages2.Add("");
        messages2.Add($"Scoped 1 : {_scoped1.GetGuid()}");
        messages2.Add($"Scoped 2 : {_scoped2.GetGuid()}");
        messages2.Add("");
        messages2.Add($"Singleton 1 : {_singleton1.GetGuid()}");
        messages2.Add($"Singleton 2 : {_singleton2.GetGuid()}");

        ViewBag.Messages2 = messages2;
        
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}