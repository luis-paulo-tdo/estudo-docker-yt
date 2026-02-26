using _01_ApiLivros.Models;
using Microsoft.EntityFrameworkCore;

namespace _01_ApiLivros.Repository
{
    internal sealed class LivroContext : DbContext
    {
        public LivroContext(DbContextOptions<LivroContext> options) : base(options) { }

        public DbSet<Livro> Livros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed
            Livro[] livros = [
                new Livro(Id: new Guid(g:"7cda12f6-8f89-4304-af49-881b22635ec3"), Nome: "As Crônicas de Nárnia"),
                new Livro(Id: new Guid(g:"4e0ccd88-97f4-4b52-842c-ba5a8d1fee98"), Nome: "O Senhor dos Anéis")
            ];

            modelBuilder.Entity<Livro>().HasData(livros);

            base.OnModelCreating(modelBuilder);
        }
    }
}
