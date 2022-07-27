using Almacen.Domain.Repositories;
using Almacen.Infraestructura.Repositories;
using Almacen.Infraestructura.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Infrastructure
{
    public static class DependencyInjection
    {

        public static void AddInfraestructure(
            this IServiceCollection services, string connectionStringDB
            )
        {
            services.AddAppDbContext(connectionStringDB);                                          
            services.AddRepositories();
        }

        private static void AddAppDbContext(
            this IServiceCollection services, string connectionStringDB)
        {
            services.AddDbContext<AlmacenDbContext>(
                options => options.UseSqlServer(connectionStringDB)
                );

        }

        private static void AddRepositories(this IServiceCollection services)
        {

            services.AddScoped<ICategoriaRepository, CategoriaRepository>();
            services.AddScoped<IAlmacenRepository, AlmacenRepository>();
            services.AddScoped<IEmpleadoRepository, EmpleadoRepository>();
            services.AddScoped<IProductoRepository, ProductoRepository>();




        }
    }

}
