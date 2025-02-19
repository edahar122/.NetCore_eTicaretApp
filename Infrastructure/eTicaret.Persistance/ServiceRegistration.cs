using ETicaret.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace eTicaret.Persistance {
    public static class ServiceRegistration {
        public static void AddPersistanceServices(this IServiceCollection services) {
            //string connectionString = "User ID=postgres;Password=123;Host=localhost;Port=5432;Database=postgres;\r\n";

            services.AddDbContext<ETicaretDBContext>(options => options.UseNpgsql("User ID=postgres;Password=123;Host=localhost;Port=5432;Database=eTicaret;\r\n"));
        }
    }
}
