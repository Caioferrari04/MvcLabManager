using Microsoft.AspNetCore.Mvc;
using MvcLabManager.Models;

namespace MvcLabManager.Controllers;

public class ComputerController : Controller
{
    private readonly Context _context;

    public ComputerController(Context context)
    {
        _context = context;
    }

    public IActionResult Index() {
        return View(_context.Computers);
    } 

    public IActionResult Show(int id)
    {
        Computer computer = _context.Computers.Find(id);

        if(computer == null)
        {
            return NotFound(); // RedirectToAction("Index")
        }

        return View(computer);
    }

    [HttpGet]
    public IActionResult Create() => View();

    [HttpPost]
    public IActionResult Create(Computer computer) 
    {
        _context.Computers.Add(computer);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult Update(int id) => View(_context.Computers.First(f => f.Id == id));

    [HttpPost]
    public IActionResult Update(Computer computer) 
    {
        _context.Computers.Update(computer);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Delete(int id) 
    {
        _context.Computers.Remove(_context.Computers.First(f => f.Id == id));
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }
}