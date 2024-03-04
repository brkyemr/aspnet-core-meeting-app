var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

//mvc şablonu bu servisin eklenmesi ile oluyor.
var app = builder.Build();



//  controller{default değeri /home }/action {default değeri /index }/id?
//app.MapDefaultControllerRoute();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
