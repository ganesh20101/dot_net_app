var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Enable serving default files like index.html
app.UseDefaultFiles();
// Enable serving static files from wwwroot
app.UseStaticFiles();

app.UseRouting();

app.Run();

