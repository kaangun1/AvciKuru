using AvciKoru.Entities.Contexts;
using AvciKoru.Entities.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace AvciKoru.WebApi
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

            #region IdentityApiEndPoint Ayarlari
            // Appsetting icerisindeki connectionstrigi alir
            string constr = builder.Configuration.GetConnectionString("MySql"); 
            //DbContext Nesnesini service'lere ekler
            builder.Services.AddDbContext<AppDbContext>(p => p.UseMySQL(constr));
            //Authorization icin gerekli servisleri ekler
            builder.Services.AddAuthorization();
            //Identity paketi icin gerekli EndPoint'leri ekler
            builder.Services.AddIdentityApiEndpoints<AppUser>()
                .AddEntityFrameworkStores<AppDbContext>(); 
            #endregion
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.MapIdentityApi<AppUser>();
            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}