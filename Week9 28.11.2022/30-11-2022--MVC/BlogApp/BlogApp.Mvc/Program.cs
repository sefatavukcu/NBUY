using BlogApp.Data.Abstract;
using BlogApp.Data.Concrete;
using BlogApp.Data.Concrete.EntityFramework.Contexts;
using BlogApp.Services.Abstract;
using BlogApp.Services.Concrete;
using BlogApp.Services.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
#region Serviceler burada yazýlýrsa
/*
    builder.Services.AddDbContext<BlogAppContext>();
    builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
    builder.Services.AddScoped<IArticleService, ArticleManager>();
    builder.Services.AddScoped<ICategoryService, CategoryManager>(); 
*/
#endregion

#region Service Extension ile çaðrýlýrsa
builder.Services.LoadMyServices();
#endregion
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}
else
{
    app.UseDeveloperExceptionPage(); // hatanýn açýklayýcý bir þekilde gösterilmesini saðlar
    app.UseStatusCodePages();
}

app.UseHttpsRedirection();
app.UseStaticFiles();  // wwwroot kýsmý

app.UseRouting();

app.UseAuthorization();

app.MapAreaControllerRoute(
    name:"Admin",
    areaName:"Admin",
    pattern: "/admin/{controller=Home}/{action=Index}/{id?}"
    );

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
