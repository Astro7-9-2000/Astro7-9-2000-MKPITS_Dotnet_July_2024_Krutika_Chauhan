using CRUD.Services;
using Microsoft.EntityFrameworkCore;

// This line initializes a new instance of a web application builder, which is used to configure services and the application's request pipe
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// This line adds support for MVC (Model-View-Controller) pattern, allowing the application to handle HTTP requests and return views.
builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    // This code registers the ApplicationDbContext with the dependency injection container.
    // It configures the context to use SQL Server as the database provider, using a connection string named "DefaultConnection" from the application's configuration settings
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    options.UseSqlServer(connectionString);
});

// This line builds the application pipeline based on the services that have been configured.
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// app.UseHttpsRedirection() forces all HTTP requests to be redirected to HTTPS.
app.UseHttpsRedirection();

// app.UseStaticFiles() enables serving static files (like CSS, JavaScript, images) from the wwwroot folder.
app.UseStaticFiles();

// app.UseRouting() enables routing capabilities, allowing the application to match incoming requests to the appropriate endpoints.
app.UseRouting();

// app.UseAuthorization() adds authorization capabilities, ensuring that only authorized users can access certain resources.
app.UseAuthorization();

// This line sets up the default route for the application.
// It specifies that if no controller or action is provided in the URL, the application should use the Home controller and the Index action. 
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
