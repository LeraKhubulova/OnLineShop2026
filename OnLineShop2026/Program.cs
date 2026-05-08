using OnLineShop2026.Data;

var builder = WebApplication.CreateBuilderhttps://github.com/NOSUmit-PM-2/OnLineShop2026/pull/28/conflict?name=OnLineShop2026%252FViews%252FShared%252F_Layout.cshtml&ancestor_oid=ec9b9c56cd0e17a5a715ae83ba3f6d2176dcfa2b&base_oid=d298037c86575e94bcd389b4323f6f9ddd633aa3&head_oid=403a94c29ec9268a052fc358c63f965ac371e403(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IProductRepository, ProductRepositoryInMemory>();
builder.Services.AddSingleton<IUserRepository, UserRepositoryInMemory>();
builder.Services.AddSingleton<ICartRepository, CartRepositoryInMemory>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Catalog}/{id?}");


app.Run();
