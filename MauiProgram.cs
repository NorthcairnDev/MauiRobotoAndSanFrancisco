using Microsoft.Extensions.Logging;

namespace MauiRobotoAndSanFrancisco
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
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Roboto-Thin.ttf", "RobotoThin");
                    fonts.AddFont("Roboto-ExtraLight.ttf", "RobotoExtraLight");
                    fonts.AddFont("Roboto-Light.ttf", "RobotoLight");
                    fonts.AddFont("Roboto-Regular.ttf", "RobotoRegular");
                    fonts.AddFont("Roboto-Medium.ttf", "RobotoMedium");
                    fonts.AddFont("Roboto-SemiBold.ttf", "RobotoSemiBold");
                    fonts.AddFont("Roboto-Bold.ttf", "RobotoBold");
                    fonts.AddFont("Roboto-ExtraBold.ttf", "RobotoExtraBold");
                    fonts.AddFont("Roboto-Black.ttf", "RobotoBlack");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
