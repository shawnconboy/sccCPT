namespace CPT206RazorProject
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection services) 
        {
            services.AddRazorPages();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (!env.IsDevelopment()) { app.UseHsts(); }
            app.UseRouting(); // start endpoint routing
            app.UseHttpsRedirection(); 
            app.UseStaticFiles();
            app.UseDefaultFiles();
            app.UseEndpoints(endpoints => 
            { endpoints.MapGet("/hello", () => "Hello World!"); }); 
        }
    }
}
