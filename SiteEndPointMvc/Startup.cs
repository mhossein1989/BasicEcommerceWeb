using SadeghiBasicMarket.Application.Services.Commands.UserLogin;
using SadeghiBasicMarket.Persistence.Contexts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SadeghiBasicMarket.Application.Interfaces.Contexts;
using SadeghiBasicMarket.Application.Services.Commands.EditUser;
using SadeghiBasicMarket.Application.Services.Commands.RegisterUser;
using SadeghiBasicMarket.Application.Services.Commands.RemoveUser;
using SadeghiBasicMarket.Application.Services.Commands.UserLogin;
using SadeghiBasicMarket.Application.Services.Commands.UserSatusChange;
using SadeghiBasicMarket.Application.Services.Queries.GetRoles;
using SadeghiBasicMarket.Application.Services.Queries.GetUsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using SadeghiBasicMarket.Application.Interfaces.FacadPatterns;
using SadeghiBasicMarket.Application.Services.FacadPattern;
using SadeghiBasicMarket.Application.Services.Queries.GetMenuItem;
using SadeghiBasicMarket.Application.Services.Queries.GetCategory;
using SadeghiBasicMarket.Application.Services.Queries.GetMobileMenuItem;
using SadeghiBasicMarket.Application.Services.Commands.AddNewSlider;
using SadeghiBasicMarket.Application.Services.Commands.AddHomePageImages;
using SadeghiBasicMarket.Application.Services.Queries.GetSlider;
using SadeghiBasicMarket.Application.Services.Queries.GetHomePageImages;
using SadeghiBasicMarket.Application.Services.Carts;
using SadeghiBasicMarket.Application.Services.Commands.AddRequestPay;
using SadeghiBasicMarket.Common.Roles;
using SadeghiBasicMarket.Application.Services.Queries.GetRequestPayService;
using SadeghiBasicMarket.Application.Services.Commands.AddNewOrder;
using SadeghiBasicMarket.Application.Services.Queries.GetUserOrders;

namespace SiteEndPointMvc
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

            services.AddAuthorization(options =>
            {
                options.AddPolicy(UserRoles.Admin, policy => policy.RequireRole(UserRoles.Admin));
                options.AddPolicy(UserRoles.Customer, policy => policy.RequireRole(UserRoles.Customer));
                options.AddPolicy(UserRoles.Operator, policy => policy.RequireRole(UserRoles.Operator));
            });

            services.AddAuthentication(options =>
            {
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            }).AddCookie(options =>
            {
                options.LoginPath = new PathString("/Authentication/Signin");
                options.ExpireTimeSpan = TimeSpan.FromMinutes(5.0);
            });


            services.AddScoped<IDataBaseContext, DataBaseContext>();

            //User Services Inject
            services.AddScoped<IGetUsersService, GetUsersService>();
            services.AddScoped<IGetRolesService, GetRolesService>();
            services.AddScoped<IRegisterUserService, RegisterUserService>();
            services.AddScoped<IRemoveUserService, RemoveUserService>();
            services.AddScoped<IUserLoginService, UserLoginService>();
            services.AddScoped<IUserSatusChangeService, UserSatusChangeService>();
            services.AddScoped<IEditUserService, EditUserService>();

            //FacadeInject
            services.AddScoped<IProductFacad, ProductFacad>();

            //------------------
            services.AddScoped<IGetMobileMenuItemService, GetMobileMenuItemService>();
            services.AddScoped<IGetMenuItemService, GetMenuItemService>();
            services.AddScoped<IGetCategoryService, GetCategoryService>();
            services.AddScoped<IAddNewSliderService, AddNewSliderService>();
            services.AddScoped<IGetSliderService, GetSliderService>();
            services.AddScoped<IAddHomePageImagesService, AddHomePageImagesService>();
            services.AddScoped<IGetHomePageImagesService, GetHomePageImagesService>();
            services.AddScoped<ICartService, CartService>();
            services.AddScoped<IAddRequestPayService, AddRequestPayService>();
            services.AddScoped<IGetRequestPayService, GetRequestPayService>();
            services.AddScoped<IAddNewOrderService, AddNewOrderService>();
            services.AddScoped<IGetUserOrdersService, GetUserOrdersService>();

            services.AddEntityFrameworkSqlServer().AddDbContext<DataBaseContext>(option => 
            option.UseSqlServer(Configuration.GetConnectionString("myDb")));
            services.AddControllersWithViews();
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

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                 name: "areas",
                 pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
               );
            });

        }
    }
}
