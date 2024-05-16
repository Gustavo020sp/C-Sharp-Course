using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SalesWebMvc.Data;
using SalesWebMvc.Services;

namespace SalesWebMvc
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);
			builder.Services.AddDbContext<SalesWebMvcContext>(options =>
				options.UseMySql(builder.Configuration.GetConnectionString("SalesWebMvcContext"), new MySqlServerVersion(new Version()) ?? throw new InvalidOperationException("Connection string 'SalesWebMvcContext' not found.")));

			// Add services to the container.
			builder.Services.AddControllersWithViews();
			builder.Services.AddScoped<SeedingService>();
			builder.Services.AddScoped<SellerService>();
			builder.Services.AddScoped<DepartmentService>();

			var app = builder.Build();

			//unico metodo que funcionou -- sem implementar no Startup.cs
			SeedDatabase();
			void SeedDatabase()
			{
				using (var scope = app.Services.CreateScope())
				{
					var dbInitializer = scope.ServiceProvider.GetRequiredService<SeedingService>();
					dbInitializer.Seed(app);
				}
			}

			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthorization();

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}/{id?}");

			app.Run();
		}
	}
}
