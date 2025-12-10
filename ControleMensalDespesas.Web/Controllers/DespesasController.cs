using ControleMensalDespesas.Web.Data;
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
}