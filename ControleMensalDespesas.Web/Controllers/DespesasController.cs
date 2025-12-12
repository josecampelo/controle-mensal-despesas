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

    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null) return NotFound();

        var despesa = await _context.Despesas.FindAsync(id);

        if (despesa == null) return NotFound();

        return View(despesa);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(Despesa despesa)
    {
        if (!ModelState.IsValid) return View(despesa);

        var despesaExistente = await _context.Despesas.FindAsync(despesa.Id);

        if (despesaExistente == null) return NotFound();

        despesaExistente.Nome = despesa.Nome;
        despesaExistente.Categoria = despesa.Categoria;
        despesaExistente.Valor = despesa.Valor;
        despesaExistente.EstaPago = despesa.EstaPago;
        despesaExistente.DataVencimento = despesa.DataVencimento;
        despesaExistente.ParcelaAtual = despesa.ParcelaAtual;
        despesaExistente.TotalParcelas = despesa.TotalParcelas;
        
        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Delete(int id)
    {
        var despesa = await _context.Despesas.FindAsync(id);

        if (despesa == null) return NotFound();

        return View(despesa);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var despesaExistente = await _context.Despesas.FindAsync(id);

        if (despesaExistente == null) return NotFound();

        _context.Despesas.Remove(despesaExistente);

        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }
}