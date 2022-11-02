using Microsoft.AspNetCore.Mvc;
using MvcLabManager.Models;

namespace MvcLabManager.Controllers;

public class LabController : Controller
{
    private readonly Context _context;

    public LabController(Context context)
    {
        _context = context;
    }

    public IActionResult Index() => View(_context.Labs);

    public IActionResult Show(int id)
    {
        Lab lab = _context.Labs.Find(id);

        if(lab is null)
            return NotFound();

        return View(lab);
    }

    [HttpGet]
    public IActionResult Create() => View();

    [HttpPost]
    public IActionResult Create(Lab lab) 
    {
        _context.Labs.Add(lab);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult Update(int id) => View(_context.Labs.First(f => f.ID == id));

    [HttpPost]
    public IActionResult Update(Lab lab) 
    {
        _context.Labs.Update(lab);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Delete(int id) 
    {
        _context.Labs.Remove(_context.Labs.First(f => f.ID == id));
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }
}