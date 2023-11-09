using System.Diagnostics.CodeAnalysis;
using Hw8.Calculator;
using Hw8.Parser;

namespace Hw8;

[ExcludeFromCodeCoverage]
public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllersWithViews();

        builder.Services.AddSingleton<ICalculator, DoubleCalculator>();
        builder.Services.AddSingleton<IParser, DoubleParser>();

        var app = builder.Build();

        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();
        app.UseAuthorization();

        app.MapControllerRoute(
            "default",
            "{controller=Calculator}/{action=Index}");

        app.Run();
    }
}