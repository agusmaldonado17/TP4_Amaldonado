using Microsoft.Extensions.Logging;

namespace TP4_Amaldonado
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();

            //Clase par conectarse con el servicio de api rest
            builder.Services.AddScoped(sp => new HttpClient
            {
                BaseAddress = new Uri("https://dummyjson.com/")
            });

            builder.Services.AddScoped<TP4_Amaldonado.Services.CartService>();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
