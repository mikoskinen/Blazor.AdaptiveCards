using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using AdaptiveCards.Blazor.Samples.Data;
using AdaptiveCards.Blazor.Extensions;

namespace AdaptiveCards.Blazor.Samples
{

    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();
            services.AddHttpClient("samples", x => {
                x.BaseAddress = new System.Uri("https://raw.githubusercontent.com/mikoskinen/Blazor.AdaptiveCards/master/samples/AdaptiveCards.Blazor.Samples/Pages/");
            });

            services.AddBlazorAdaptiveCards()
                .AddTemplate<WeatherForecast>(Schemas.WeatherTemplated)
                .AddTemplate<Customer>(Schemas.CustomerTemplated)
                .AddFileTemplate("Alternative", "AlternativeTemplatedAdaptiveCard.json");
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
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
