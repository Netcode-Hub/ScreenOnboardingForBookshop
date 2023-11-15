using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using ScreenOnboardingForBookshop.ViewModel;

namespace ScreenOnboardingForBookshop
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Services.AddScoped<BookViewModel>();
            builder.Services.AddScoped<MainPage>();
            builder.Services.AddScoped<BooksHomePage>();
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
