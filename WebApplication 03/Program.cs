namespace WebApplication_03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();  // Register Built-in MVC Service


            var app = builder.Build();

            //app.MapGet("/", () => "Hello World!");
            ////app.MapGet("/login", () => "u r signed in!");
            //app.MapGet ("/login", Signin);
            //MVC

            app.MapControllerRoute(
                name : "default",
                pattern : "{controller=Movie} /{action=GetMovie}/{id}"
                //pattern : "{controller=Movie} /{action=GetMovie}/{id:alpha:length(5)=12}"
                //pattern : "{controller=Movie} /{action=GetMovie}/{id:alpha:length(5,8)=12}"
                //pattern : "{controller=Movie} /{action=GetMovie}/{id:regex=12}"
                //pattern : "{controller=Movie} /{action=GetMovie}/{id?=12}"
                );


            app.Run();
        }

        public static string Signin()
        {
            return $"u r signed in!";
        }
    }
}
