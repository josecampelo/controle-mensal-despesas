using ControleMensalDespesas.Web.Data;
using ControleMensalDespesas.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ControleMensalDespesas.Web.Controllers;

public class DespesasController : Controller
{
    private readonly ApplicationDbContext _context;

    public DespesasController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var despesas = await _context.Despesas.ToListAsync();

        return View(despesas);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Despesa despesa)
    {
        if (ModelState.IsValid)
        {
            _context.Add(despesa);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        return View(despesa);
    }
}