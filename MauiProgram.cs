using Microsoft.Extensions.Logging;

namespace smartstick1
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
                    fonts.AddFont("Futura Book font.ttf", "OpenSansRegular");
                    fonts.AddFont("Futura Heavy font.ttf", "OpenSansRegular");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
