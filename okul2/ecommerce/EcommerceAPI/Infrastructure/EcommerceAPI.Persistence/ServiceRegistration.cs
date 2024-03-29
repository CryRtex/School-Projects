using EcommerceAPI.Application.Abstrations;
using Microsoft.EntityFrameworkCore;
using EcommerceAPI.Persistence.Concretes;
using EcommerceAPI.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcommerceAPI.Application.Repositories;
using EcommerceAPI.Persistence.Repositories;

namespace EcommerceAPI.Persistence
{
  public static class ServiceRegistration
  {
    public static void AddPersistenceServices(this IServiceCollection services)
    {
      services.AddSingleton<IProductService, ProductService>();
      services.AddDbContext<EcommerceAPIDbContext>(options => options.UseNpgsql("User ID=myusername;Password=mypassword; Host =localhost;Port=5432;Database=ecommerceAPIDb;"));
      services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
      services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
      services.AddScoped<IOrderReadRepository, OrderReadRepository>();
      services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
      services.AddScoped<IProductReadRepository, ProductReadRepository>();
      services.AddScoped<IProductWriteRepository, ProductWriteRepository>();

    }

  }
}
