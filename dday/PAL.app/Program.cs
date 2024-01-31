using Entprog.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using PAL.app.Configuration;
using PAL.app.Models.Repository;
using PAL.DataModel;
var builder = WebApplication.CreateBuilder(args);

// Dependency Injection:
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Development"));
});
builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
{
    options.Password.RequireDigit = false;
    options.Password.RequiredLength = 5;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;


    options.SignIn.RequireConfirmedEmail = false;
}).AddEntityFrameworkStores<AppDbContext>().AddRoles<IdentityRole>();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Account/SignIn";
    options.LogoutPath = "/Account/SignOut";
    options.ExpireTimeSpan = TimeSpan.FromMinutes(10);
    options.SlidingExpiration = true;
});


builder.Services.AddAutoMapper(typeof(MapperConfig));
builder.Services.AddScoped<IGenericRepository<DACSlot>, SlotRepository>();

builder.Services.AddScoped<IGenericRepository<AKICSlot>, AKICSlotRepository>();

builder.Services.AddScoped<IGenericRepository<PETERSlot>, PETERSlotRepository>();

builder.Services.AddScoped<IGenericRepository<DOMINGASlot>, DOMINGASlotRepository>();

builder.Services.AddScoped<IGenericRepository<CampusReservation>, CampusReservationRepository>();
// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
    var user = await userManager.FindByEmailAsync("entprogadmin@gmail.com");
    if (user != null)
    {
        await userManager.AddToRoleAsync(user, "Admin");
    }

    // Create the "Admin" role if it doesn't exist
    if (!await roleManager.RoleExistsAsync("Admin"))
    {
        await roleManager.CreateAsync(new IdentityRole("Admin"));
    }
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();



app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=HomeLog}/{action=IndexStart}/{id?}");

app.Run();
