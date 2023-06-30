using System.Data;
using Microsoft.Data.SqlClient;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.
builder.Services.AddControllersWithViews();

//adddbcontext

builder.Services.AddDbContext<Context>();


var app = builder.Build();

// Configure the HTTP request pipeline.
           if (app.Environment.IsDevelopment())
            {
                 app.UseDeveloperExceptionPage();
                 //app.UseExceptionHandler("/Home/offline");
                
            }
            else
            {
                // app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                // app.UseHsts();
                  app.UseExceptionHandler("/Home/offline");
            }
app.UseHttpsRedirection();
app.UseStaticFiles();
//dappper


app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=login}/{action=Index}/{id?}");

app.Run();
