using Microsoft.EntityFrameworkCore;

namespace AppDescontoUniver.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Produto> Produtos{ get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

    }
}
