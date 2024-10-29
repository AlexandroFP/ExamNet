using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Text.RegularExpressions;

public class AutosDbContext : DbContext
{
    public DbSet<Marca> Marca { get; set; }
    public DbSet<Submarca> Submarca { get; set; }
    public DbSet<Modelo> Modelo { get; set; }
    public DbSet<Descripcion> Descripcion { get; set; }

    public AutosDbContext(DbContextOptions<AutosDbContext> options) : base(options) { }

  
}

