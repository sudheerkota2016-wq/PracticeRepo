using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SampleForAzure.Models;

namespace SampleForAzure.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.Message = $"Welcome to ASP.NET Core MVC on Azure! {DateTime.Now}";
        System.Diagnostics.Trace.TraceInformation("If you're seeing this, something bad happened, Sudheer");
        return View();
    }

    public IActionResult Privacy()
    {
        throw new Exception($"You can't catch me! {DateTime.Now}");
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
