using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dotnet_store.Models;

namespace dotnet_store.Controllers;

public class HomeController : Controller
{
    // Dependecy Injection => DI
    private readonly DataContext _context;
    public HomeController(DataContext context)
    {
        _context = context;
    }

    public ActionResult Index()
    {
        var urunler = _context.Urunler.ToList();
        return View(urunler);
    }
}
