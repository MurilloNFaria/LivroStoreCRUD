using LivroStore.Models;
using Microsoft.EntityFrameworkCore;

namespace LivroStore.Data;

public class LivroContext : DbContext
{
    public DbSet<Livro> Livros { get; set; }

    public LivroContext(DbContextOptions<LivroContext> opts) : base(opts)
    {
        
    }
}
