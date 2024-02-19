using Microsoft.Extensions.Logging;

namespace AppMarina;
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
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("JosefinSans-VariableFont_wght.ttf", "Josefin");
            });

#if DEBUG
		builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
