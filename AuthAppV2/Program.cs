
using AuthAppV2.Context;
using AuthAppV2.Managers;
using AuthAppV2.Services;
using Microsoft.EntityFrameworkCore;

namespace AuthAppV2
{
    public class Program
    {
        public static void Main(string[] args)
        {






            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var cs = builder.Configuration.GetConnectionString("DefaultConnection");

            builder.Services.AddDbContext<AuthAppDbContext>(options => options.UseSqlServer(cs));


            builder.Services.AddScoped<IUserService, UserManager>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
           
            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();












        }
    }
}
