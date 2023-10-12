using Application.Features.Bookings.Interfaces;
using Application.Features.Bookings.Services;
using Application.Features.Bookings.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Persistence.Identity;
using Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<DBContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("DbContextConnectionString"));
});

builder.Services.AddIdentity<ApplicationUser, ApplicationRole>(
    options =>
    {
        options.SignIn.RequireConfirmedAccount = true;
        options.User.AllowedUserNameCharacters += "'";
    })
    .AddDefaultTokenProviders()
    //.AddDefaultUI()
    .AddEntityFrameworkStores<DBContext>();

//options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+'"

builder.Services.Configure<IdentityOptions>(options =>
{
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(60);
    options.Lockout.MaxFailedAccessAttempts = 5;
    options.Lockout.AllowedForNewUsers = true;
});

builder.Services.Configure<DataProtectionTokenProviderOptions>(o =>
       o.TokenLifespan = TimeSpan.FromDays(5));


builder.Services.AddTransient<IRepository, Repository>();
builder.Services.AddScoped<IBookingService, BookingService>();

builder.Services.AddHttpClient();

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
