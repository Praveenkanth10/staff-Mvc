using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StaffManagement.Models;

public class StaffController : Controller
{
    private readonly ApplicationDbContext _context;

    public StaffController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var staff = await _context.Set<Staff>().ToListAsync();
        return View(staff);
    }

    public IActionResult Create() => View();

    [HttpPost]
    public async Task<IActionResult> Create(Staff staff)
    {
        if (ModelState.IsValid)
        {
            _context.Add(staff);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(staff);
    }
}
