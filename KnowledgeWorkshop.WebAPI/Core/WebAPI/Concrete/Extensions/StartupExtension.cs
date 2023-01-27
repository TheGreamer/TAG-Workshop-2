using KnowledgeWorkshop.WebAPI.Business.Abstract;
using KnowledgeWorkshop.WebAPI.Business.Concrete;
using KnowledgeWorkshop.WebAPI.DataAccess.Abstract;
using KnowledgeWorkshop.WebAPI.DataAccess.Concrete.Contexts;
using KnowledgeWorkshop.WebAPI.DataAccess.Concrete.Layers;
using Microsoft.EntityFrameworkCore;

namespace KnowledgeWorkshop.WebAPI.Core.WebAPI.Concrete.Extensions
{
    public static class StartupExtension
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<IProductDal, ProductDal>()
                    .AddScoped<IProductService, ProductService>();

            return services;
        }

        public static IServiceCollection ConfigureMsSqlServer(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<EfContext>(options => options.UseSqlServer(connectionString));
            return services;
        }
    }
}