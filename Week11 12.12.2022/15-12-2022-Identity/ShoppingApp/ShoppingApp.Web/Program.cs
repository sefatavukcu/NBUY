using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ShoppingApp.Business.Abstract;
using ShoppingApp.Business.Concrete;
using ShoppingApp.Data.Abstract;
using ShoppingApp.Data.Concrete;
using ShoppingApp.Data.Concrete.EfCore.Contexts;
using ShoppingApp.Entity.Concrete.Identity;
using ShoppingApp.Web.EmailServices.Abstract;
using ShoppingApp.Web.EmailServices.Concrete;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); //mvc uygulamas�

builder.Services.AddDbContext<IdentityContext>(options=>options.UseSqlite("Data Source=ShoppingApp.db"));
builder.Services.AddDbContext<ShopAppContext>();

builder.Services.AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<IdentityContext>()
    .AddDefaultTokenProviders();

builder.Services.Configure<IdentityOptions>(options=>
{
    #region PasswordSettings
        options.Password.RequireDigit=true;//Şifre içinde mutlaka rakam bulunsun
        options.Password.RequireLowercase=true;//Şifre içinde küçük harf bulunsun
        options.Password.RequireUppercase=true;//Şifre içinde büyük harf bulunsun
        options.Password.RequiredLength=6;//Şifre en az 6 karakter olsun
        options.Password.RequireNonAlphanumeric=true;//Şifre içinde en az bir alfanümerik karaktarler bulunsun.
    #endregion

    #region LoginSettings
        options.Lockout.MaxFailedAccessAttempts=5;//Başarısız erişim denemesi en fazla kaç olsun.
        options.Lockout.DefaultLockoutTimeSpan=TimeSpan.FromMinutes(5);//Ne kadar kilitli kalsın.
    #endregion
    
    #region UserSettings
        options.User.RequireUniqueEmail=true;//Benzersiz email adres ile kayıt olunabilir.
    #endregion

    #region SignInSettings
        options.SignIn.RequireConfirmedEmail=false;//Kullanıcı giriş yaparken email onayı true ise aktiftir.
        options.SignIn.RequireConfirmedPhoneNumber=false;//Sms ile onaylama vs.
    #endregion
});

builder.Services.ConfigureApplicationCookie(options=>
{
    options.LoginPath="/account/login";//Eğer açılabilmesi için login olması zorunlu olduğu bir istekte bulunulursa, bu sayfa açılacak.
    options.LogoutPath="/account/logout";//Kullanıcı çıkış yaptığında yönlendirilecek sayfa
    options.AccessDeniedPath="/account/accessdenies";//Yetkisiz giriş sırasında yönlendirilecek sayfa
    options.SlidingExpiration=true;//Dotnette bir cookienin yaşam süresi 20dk. Ama bu komut true ise, her istekte her tıklamada 20dk yeniden başlar.
    options.ExpireTimeSpan=TimeSpan.FromMinutes(5);//varsayılan 20 dk yı 5 dk yapar. Yaşam süresini ayarlar.
    options.Cookie= new CookieBuilder
    {
        HttpOnly=true,
        Name=".ShoppingApp.Security.Cookie",
        SameSite=SameSiteMode.Strict //saldırılardan korumak için vs
    };
});
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<IProductService, ProductManager>();

builder.Services.AddScoped<IEmailSender, SmtpEmailSender>(x => new SmtpEmailSender(
    "smtp.office365.com",587,true,"wissen_core@hotmail.com","Wissen123."
));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseAuthentication();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "products",
    pattern: "kategori/{categoryurl?}",
    defaults: new { controller = "Shop", action = "ProductList" }
    );

app.MapControllerRoute(
    name:"productdetails",
    pattern:"urunler/{producturl}",
    defaults: new {controller="Shop", action="ProductDetails"}
    );


app.MapAreaControllerRoute(
    name: "Admin",
    areaName: "Admin",
    pattern: "Admin/{controller=Home}/{action=Index}/{id?}"); ;

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
