using dotnet_store.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_store.Controllers;

public class UrunController : Controller
{
    // Dependecy Injection => DI
    private readonly DataContext _context;
    public UrunController(DataContext context)
    {
        _context = context;
    }

    public ActionResult Index()
    {
        return View();
    }

    public ActionResult List(string url, string q)
    {
        var query = _context.Urunler.Where(i=>i.Aktif);
        if (!string.IsNullOrEmpty(url))
        {
            query = query.Where(i => i.Kategori.Url == url);
        }

        if (!string.IsNullOrEmpty(q))
        {
            query = query.Where(i => i.UrunAdi.ToLower().Contains(q.ToLower()));
            ViewData["q"] = q;
        }
        return View(query.ToList());
    }

    public ActionResult Details(int id)
    {
        // var urun = _context.Urunler.FirstOrDefault(urun => urun.Id == id);
        var urun = _context.Urunler.Find(id);

        if (urun == null)
        {
            return RedirectToAction("Index", "Home");
        }

        ViewData["BenzerUrunler"] = _context.Urunler
        .Where(i => i.Aktif && i.KategoriId == urun.KategoriId && i.Id != id)
        .Take(4)
        .ToList();
        return View(urun);
    }
}