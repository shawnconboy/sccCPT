var builder = WebApplication.CreateBuilder(args);

// Enable Razor Pages and static file serving
builder.Services.AddRazorPages();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseDefaultFiles(); // will serve wwwroot/index.html as the default document
app.UseStaticFiles();

app.UseRouting();

app.MapRazorPages();

app.Run();
