using eTicaret.Application.Abstraction;
using eTicaret.Persistance.Concretes;
using Microsoft.Extensions.DependencyInjection;

namespace eTicaret.Persistance {
    public static class ServiceRegistration {
        public static void AddPersistanceServices(this IServiceCollection services) {

            services.AddSingleton<IProductService, ProductService>(); 
        }
    }
}
