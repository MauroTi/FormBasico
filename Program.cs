var builder = WebApplication.CreateBuilder(args);

// 1) Registre seus serviços antes de Build()
builder.Services.AddScoped<FormBasico.Services.OsService>();
builder.Services.AddScoped<FormBasico.Services.MySqlConnectionService>();

// 2) Adicione MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// 3) Configure o pipeline HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();        // para arquivos estáticos (css, js, imagens)
app.UseRouting();

app.UseAuthorization();

// 4) Rota padrão
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
