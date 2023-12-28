using Duende.IdentityServer.AspNetIdentity;
using Duende.IdentityServer.Services;
using Inveon.Services.Identity.Models;
using Inveon.Services.Identity.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Inveon.Services.Identity;
using Inveon.Services.Identity.DbContexts;
using Inveon.Services.Identity.DbContexts;
using Inveon.Services.Identity.Initializer;
using Inveon.Services.Identity.Models;
using Inveon.Services.Identity.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();

var builderProvider = builder.Services.AddIdentityServer(options =>
{
    options.Events.RaiseErrorEvents = true;
    options.Events.RaiseInformationEvents = true;
    options.Events.RaiseFailureEvents = true;
    options.Events.RaiseSuccessEvents = true;
    options.EmitStaticAudienceClaim = true;
    // options.UserInteraction.LoginUrl = "http://localhost:3000/login";
    // options.UserInteraction.ErrorUrl = "http://localhost:3000/loginError";
    // options.UserInteraction.LogoutUrl = "http://localhost:3000/logout";
}).AddInMemoryIdentityResources(SD.IdentityResources)
.AddInMemoryApiScopes(SD.ApiScopes)
.AddInMemoryClients(SD.Clients)
.AddAspNetIdentity<ApplicationUser>();
builder.Services.AddScoped<IDbInitializer, DbInitializer>();
builder.Services.AddScoped<IProfileService, ProfileService>();
builderProvider.AddDeveloperSigningCredential();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// This policy is required to make cookies work on Chrome in HTTP.
// Apparently, Chrome won't accept Samesite: none cookies without Secure tag
// and thats not allowed?
app.UseCookiePolicy(new CookiePolicyOptions { MinimumSameSitePolicy = SameSiteMode.Lax });

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseIdentityServer();
app.UseAuthorization();

using (var serviceScope = app.Services.CreateScope())
{
    var service = serviceScope.ServiceProvider.GetService<IDbInitializer>();
    service.Initialize();
}

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.UseCors(
    options => options.WithOrigins("http://localhost:3000").AllowAnyMethod().AllowCredentials().AllowAnyHeader()
);

app.Run();
