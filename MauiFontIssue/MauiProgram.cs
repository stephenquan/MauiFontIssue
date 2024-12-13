using Microsoft.Extensions.Logging;

namespace MauiFontIssue
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

                    fonts.AddFont("NotoSans-Regular.ttf", "NotoSansRegular");
                    fonts.AddFont("NotoSans-Bold.ttf", "NotoSansBold");
                    fonts.AddFont("NotoSans-Italic.ttf", "NotoSansItalic");
                    fonts.AddFont("NotoSans-BoldItalic.ttf", "NotoSansBoldItalic");

                    fonts.AddFont("arial.ttf", "Arial");
                    fonts.AddFont("arialbd.ttf", "ArialBold");
                    fonts.AddFont("arialbi.ttf", "ArialBoldItalic");
                    fonts.AddFont("ariali.ttf", "ArialItalic");

                    fonts.AddFont("times.ttf", "Times");
                    fonts.AddFont("timesbd.ttf", "TimesBold");
                    fonts.AddFont("timesbi.ttf", "TimesBoldItalic");
                    fonts.AddFont("timesi.ttf", "TimesItalic");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
