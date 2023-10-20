using System.Reflection;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Persistencia;
public class SkeletonContext : DbContext
{

    public SkeletonContext(DbContextOptions<SkeletonContext> options) : base(options)
    {
    }

    public DbSet<Rol> Roles { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }

 
    protected override void OnModelCreating (ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }
        
        
}
