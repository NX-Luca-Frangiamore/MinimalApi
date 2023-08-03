using Microsoft.EntityFrameworkCore;

namespace MinimalApi.Model
{
    public class Context:DbContext
    {
        public Context(DbContextOptions opt) :base(opt) { }
        public DbSet<Utente> utente { set; get; }
        public DbSet<NEmail> nemail { set; get; }
        public DbSet<NTelefono> ntelefono { set; get; }

    }
}
