using ETicaret.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace eTicaret.Persistance {
    public static class ServiceRegistration {
        public static void AddPersistanceServices(this IServiceCollection services) {
            services.AddDbContext<ETicaretDBContext>(options => options.UseNpgsql(Configurations.ConnectionString));
        }
    }
}
