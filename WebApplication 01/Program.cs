namespace WebApplication_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Register Any Services
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure Any Middleware
            app.UseRouting();

            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}
