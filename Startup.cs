using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using MeuHelp.Models;
using MeuHelp.Services;
using MeuHelp.Data;

namespace MeuHelp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddDbContext<MeuHelpContext>(options =>
                    options.UseMySql(Configuration.GetConnectionString("MeuHelpContext"), builder => builder.MigrationsAssembly("MeuHelp")));
            services.AddScoped<PhysicalpersonService>();
            services.AddScoped<SaleschannelService>();
            services.AddScoped<LegalpersonService>();
            services.AddScoped<TypeserviceService>();
            services.AddScoped<PlanService>();
            services.AddScoped<ShippingwayService>();
            services.AddScoped<CollaboratorService>();
            services.AddScoped<ServiceproviderService>();
            services.AddScoped<PartnerService>();
            services.AddScoped<DiscountService>();
            services.AddScoped<RepresentativeService>();
        }
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}