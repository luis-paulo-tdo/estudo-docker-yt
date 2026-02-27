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
                options.UseSqlServer(connectionString: "Server=sql;User Id=sa;Password=SenhaDbLivros01;TrustServerCertificate=yes");
            });
        }
    }
}
