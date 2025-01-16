public void ConfigureServices(IServiceCollection services)
{
    services.AddDbContext<VehicleTrackingContext>(options =>
        options.UseMySql(Configuration.GetConnectionString("VehicleTrackingConnection"), ServerVersion.AutoDetect(Configuration.GetConnectionString("VehicleTrackingConnection"))));
    services.AddControllersWithViews();
}
