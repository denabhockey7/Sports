using DenchikSportsRu.Core;
using DenchikSportsRu.Models.Page;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

public class HomeController : Controller
{
    private readonly ApplicationDbContext _context;

    public HomeController(ApplicationDbContext context)
    {
        _context = context;
    }
    [HttpGet]
    [Route("/NBA")]
    public IActionResult NBA(NBA frm)
    {
        NBA m = SiteBL.GetNBA(frm);
        return View(m);
    }

    [HttpGet]
    [Route("/EPL")]
    public IActionResult EPL(Teams frm)
    {
       Teams m = SiteBL.GetEPL(frm);
        return View(m);
    }
    [HttpGet]
    [Route("/Bundes")]
    public IActionResult Bundes(Teams frm)
    {
        Teams m = SiteBL.GetBundes(frm);
        return View(m);
    }

    [HttpGet]
    [Route("/LL")]
    public IActionResult LL(Teams frm)
    {
        Teams m = SiteBL.GetLL(frm);
        return View(m);
    }

    [HttpGet]
    [Route("/L1")]
    public IActionResult L1(Teams frm)
    {
        Teams m = SiteBL.GetL1(frm);
        return View(m);
    }

    [HttpGet]
    [Route("/RPL")]
    public IActionResult RPL(Teams frm)
    {
        Teams m = SiteBL.GetRPL(frm);
        return View(m);
    }

    [HttpGet]
    [Route("/SA")]
    public IActionResult SA(Teams frm)
    {
        Teams m = SiteBL.GetSA(frm);
        return View(m);
    }

    [HttpGet]
    [Route("/Football")]
    public IActionResult Football(Football frm)
    {
        Football m = SiteBL.GetFootball(frm);
        return View(m);
    }


    [HttpGet]
    [Route("/Hockey")]
    public IActionResult Hockey(Hockey frm)
    {
        Hockey m = SiteBL.GetHockey(frm);
        return View(m);
    }

    [HttpGet]
    [Route("/Tennis")]
    public IActionResult Tennis(Tennis frm)
    {
        Tennis m = SiteBL.GetTennis(frm);
        return View(m);
    }

    [HttpGet]
    [Route("/Formula")]
    public IActionResult Formula(Formula frm)
    {
        Formula m = SiteBL.GetFormula(frm);
        return View(m);
    }

    [HttpGet]
    [Route("/NHL")]
    public IActionResult NHL(Clubs frm)
    {
        Clubs m = SiteBL.GetNHL(frm);
        return View(m);
    }


    [HttpGet]
    [Route("/KHL")]
    public IActionResult KHL(Clubs frm)
    {
        Clubs m = SiteBL.GetKHL(frm);
        return View(m);
    }


    public IActionResult Index()
    {
        var model = SiteBL.GetSports(new Sports());
        return View(model);
    }

    public IActionResult Details(int id)
    {
        var model = SiteBL.GetSports(new Sports { id = id });
        return View(model);
    }

}
