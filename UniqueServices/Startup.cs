using UniqueServices.Services.Configuration;
using UniqueServices.IoC;

namespace Template
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
            services.Configure<EmailServerOptions>(Configuration.GetSection("Smtp"));
            services.AddTemplateServices();
            services.AddControllersWithViews();

            // Allows the use of UseMvc routing below replaces app.UseEndpoints(endpoints => {} )
            services.AddMvc(options => options.EnableEndpointRouting = false);

            // Allows caching
            services.AddResponseCaching();

            // Allows Razor pages
            services.AddRazorPages();

            // Minify the css and js files
            services.AddWebOptimizer(pipeline =>
            {
                pipeline.MinifyCssFiles("css/site.css");

                pipeline.MinifyJsFiles("js/site.js");
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
            }

            // Handle Page Not Found Error 404
            app.Use(async (context, next) =>
            {
                await next();
                if (context.Response.StatusCode == 404)
                {
                    context.Request.Path = "/Home/Error404";
                    await next();
                }
            });

            app.UseWebOptimizer();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            //Routing for all the pages in the solution
            app.UseMvc(routes =>
            {
                routes.MapRoute(name: "AboutUs", template: "about-us", defaults: new { controller = "Home", action = "AboutUs" });
                routes.MapRoute(name: "Privacy", template: "privacy", defaults: new { controller = "Home", action = "Privacy" });
                routes.MapRoute(name: "Error404", template: "error", defaults: new { controller = "Home", action = "Error404" });
                routes.MapRoute(name: "Blog", template: "blog", defaults: new { controller = "Home", action = "Blog" });
                routes.MapRoute(name: "Contact", template: "contact", defaults: new { controller = "Home", action = "Contact" });
                routes.MapRoute(name: "AirConditioning", template: "air-conditioning-heating", defaults: new { controller = "Home", action = "AirConditioning" });
                routes.MapRoute(name: "AirConditioningRepair", template: "air-conditioning-repair", defaults: new { controller = "Home", action = "AirConditioningRepair" });
                routes.MapRoute(name: "Plumbing", template: "plumbing", defaults: new { controller = "Home", action = "Plumbing" });
                routes.MapRoute(name: "AirDuctCleaning", template: "air-duct-cleaning", defaults: new { controller = "Home", action = "AirDuctCleaning" });
                routes.MapRoute(name: "IndoorAirQuality", template: "air-quality", defaults: new { controller = "Home", action = "IndoorAirQuality" });
                routes.MapRoute(name: "Offers", template: "offers", defaults: new { controller = "Home", action = "Offers" });
                routes.MapRoute(name: "ProsClub", template: "pros-club", defaults: new { controller = "Home", action = "ProsClub" });
                routes.MapRoute(name: "ServicePlans", template: "service-plans", defaults: new { controller = "Home", action = "ServicePlans" });
                routes.MapRoute(name: "ScheduleService", template: "schedule-service", defaults: new { controller = "Home", action = "ScheduleService" });


                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}