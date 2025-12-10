using ControleMensalDespesas.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleMensalDespesas.Web.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Despesa> Despesas { get; set; }
}