using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Web.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Http;
using Web.Models.Helpers;
using Web.Models.Configuration;

namespace Web
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

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.Configure<EmailConfiguration>(Configuration.GetSection("EmailConfiguration"));
            services.Configure<MapConfiguration>(Configuration.GetSection("MapConfiguration"));

            //Choosing a db service
            CheckDB check = new CheckDB();

            //check for environment variables (described in docs/dbconfig.md)
            //if variable is not set, grab from appsettings.json
            String ConnectionString = check.getConnectionStringEnvVar() ?? Configuration.GetConnectionString("DefaultConnection");

            //if not set just use sqlite
            String DatabaseType = check.checkType() ?? "sqlite";

            switch (DatabaseType)
            {
                case "mssql":
                    var host = Configuration["DBHOST"] ?? "172.19.0.1";
                    var db = Configuration["DBNAME"] ?? "openvoting";
                    var port = Configuration["DBPORT"] ?? "1433";
                    var username = Configuration["DBUSERNAME"] ?? "sa";
                    var password = Configuration["DBPASSWORD"] ?? "Sql!Expre55";

                    string connStr = $"Data Source={host},{port};Integrated Security=False;";
                    connStr += $"User ID={username};Password={password};Database={db};";
                    connStr += $"Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    services.AddDbContext<ApplicationDbContext>(options =>
                        options.UseSqlServer(connStr));
                    break;
                case "mysql":
                    host = Configuration["DBHOST"] ?? "localhost";
                    port = Configuration["DBPORT"] ?? "3306";
                    password = Configuration["DBPASSWORD"] ?? "secret";
                    db = Configuration["DBNAME"] ?? "openvoting";
                    services.AddDbContext<ApplicationDbContext>(options =>
                    {
                        options.UseMySql($"server={host}; userid=root; pwd={password};"
                            + $"port={port}; database={db}");
                    });
                    break;
                default: //sqlite
                    services.AddDbContext<ApplicationDbContext>(options =>
                        options.UseSqlite(ConnectionString));
                    break;
            }

            // Add Cors
            services.AddCors(o => o.AddPolicy("PlanVotePolicy", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));

            services.AddDefaultIdentity<IdentityUser>(
                options =>
                {
                    options.SignIn.RequireConfirmedAccount = true;
                }
            ).AddEntityFrameworkStores<ApplicationDbContext>();


            // OLD CODE
            // services.AddIdentity<IdentityUser, IdentityRole>(
            //     option =>
            //     {
            //         option.Password.RequireDigit = false;
            //         option.Password.RequiredLength = 6;
            //         option.Password.RequireNonAlphanumeric = false;
            //         option.Password.RequireUppercase = false;
            //         option.Password.RequireLowercase = false;
            //     }
            // ).AddEntityFrameworkStores<ApplicationDbContext>()
            // .AddDefaultTokenProviders();

            //MAIN ERROR: Scheme already exists: Identity.Application

            //Added this. Fixed the problem - Bryce
            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 1;
            });

            services.AddLocalization(opts =>
            {
                opts.ResourcesPath = "Resources";
            });

            services.AddControllersWithViews();
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(
            IApplicationBuilder app,
            ApplicationDbContext context,
            IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseCors("EmailPolicy");
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseCors();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
                endpoints.MapControllers();
            });

            //AccountsInit.InitializeAsync(app);
            StateInit.Initialize(context);
            if (!context.Themes.Any())
            {
                ThemesInit.Initialize(context);
            }
        }
    }
}
