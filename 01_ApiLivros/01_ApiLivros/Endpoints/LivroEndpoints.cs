using _01_ApiLivros.DTO.Requests;
using _01_ApiLivros.Models;
using _01_ApiLivros.Repository;

namespace _01_ApiLivros.Endpoints
{
    internal static class LivroEndpoints
    {
        public static void MapLivroEndpoints(this WebApplication app)
        {
            var livroRotas = app.MapGroup(prefix: "livros");

            livroRotas.MapGet(string.Empty, (LivroContext db) => db.Livros.ToList());
            livroRotas.MapPost(string.Empty, (LivroInsert req, LivroContext db) =>
            {
                var livro = new Livro(Guid.NewGuid(), req.Nome!);
                db.Livros.Add(livro);
                db.SaveChanges();
                return Results.Ok(livro);
            });
        }
    }
}
