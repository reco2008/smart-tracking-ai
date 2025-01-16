using Microsoft.EntityFrameworkCore;
using SmartTrackingAI.Data;
using SmartTrackingAI.Services;

namespace SmartTrackingAI
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<TrackingDbContext>(options =>
                options.UseMySql("your-mysql-connection-string", ServerVersion.AutoDetect("your-mysql-connection-string")));

            services.AddScoped<ProtocolProcessor>();
            services.AddScoped<ProtocolDataService>();

            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
