using _01_ApiLivros.Repository;
using Microsoft.EntityFrameworkCore;

namespace _01_ApiLivros.Extensions
{
    internal static class LivroExtensions
    {
        public static void AddLivroContext(this IServiceCollection services)
        {
            services.AddDbContext<LivroContext>(optionsAction: options =>
            {
                options.UseSqlite(connectionString: "Data Source=db/Livros.db");
                // options.UseSqlServer(connectionString: "Server=localhost,1200;User Id=sa;Password=SenhaDbLivros01;TrustServerCertificate=yes");
            });
        }
    }
}
