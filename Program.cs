using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;

namespace WebAppLayout
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            //app.MapGet("/", () => "Hello World!");
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
                //endpoints.MapControllerRoute(
                //    name:"default",
                //    pattern:"{controller=About}/{action=Index}"

                //    );
            });

            app.Run();
        }
    }
}