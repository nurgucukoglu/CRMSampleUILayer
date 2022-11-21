using CrmSample.BusinessLayer.Abstract;
using CrmSample.BusinessLayer.Concrete;
using CrmSample.DataAccessLayer.Abstract;
using CrmSample.DataAccessLayer.Concrete;
using CrmSample.DataAccessLayer.EntityFramework;
using CrmSample.EntityLayer.Concrete;
using CrmSample.UILayer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrmSample.UILayer
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EFCategoryDal>();

            services.AddScoped<IEmployeeService,EmployeeManager>();
            services.AddScoped<IEmployeeDal, EFEmployeeDal>();

            services.AddScoped<IEmployeeTaskService, EmployeeTaskManager>();
            services.AddScoped<IEmployeeTaskDal , EfEmployeeTaskDal>();

            services.AddScoped<IEmployeeTaskDetailService, EmployeeTaskDetailManager>();
            services.AddScoped<IEmployeeTaskDetailDal, EfEmployeeTaskDetail>();

            services.AddScoped<IMessageService, MessageManager>();
            services.AddScoped<IMessageDal, EFMessageDal>();

            services.AddDbContext<Context>(); 

            services.AddIdentity<AppUser,AppRole>().AddErrorDescriber<CustomIdentityValidator>().AddEntityFrameworkStores<Context>();  //AddEntityFrameworkStore: entity fr. içinde kullan ve içine parametre olarak: bizim yazdýðýmýz Context alýcak. VE üstteki DbContext.i de ekledik.
            services.AddControllersWithViews();

            services.AddMvc(config =>
            {
                var policy = new AuthorizationPolicyBuilder()
                            .RequireAuthenticatedUser()//bu kýsým tüm sayfalarda yetkilendirme yani kullanýcý login olmadan hiçbir sayfaya eriþememesini saðlar
                            .Build();
                config.Filters.Add(new AuthorizeFilter(policy));


            });
            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Login/Index";//kullanýcý login olmadan eriþmeye çalýþýrsa login sayfasýna yönlendirilmesini saðlar
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseAuthentication();    

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}
