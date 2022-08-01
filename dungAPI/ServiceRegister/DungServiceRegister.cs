using dungAPI.DAL.Context;
using dungEcommerce.BLL.IRepositories;
using dungEcommerce.BLL.Repositories;
using Microsoft.EntityFrameworkCore;

namespace dungEcommerceAPI.ServiceRegister
{
    public static class DungServiceRegister
    {
        public static void AddDungServiceRegister(this IServiceCollection Services,IConfiguration configuration)
        {
            // Add services to the container.

            Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            Services.AddEndpointsApiExplorer();
            Services.AddSwaggerGen();

            Services.AddDbContext<dungContext>(x => x.UseSqlServer(configuration.GetConnectionString("dungConnectionString")));

            Services.AddTransient<ICategoryRepository, CategoryRepository>();

            Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}
