using AirsoftMAUI.MVVM.ViewModels;
using AirsoftMAUI.MVVM.Views;
using AirsoftMAUI.Services;
using Microsoft.Extensions.Logging;

namespace AirsoftMAUI
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
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<ProductosService>();
            builder.Services.AddSingleton<AuthService>();
            builder.Services.AddSingleton<ComprasService>();

            builder.Services.AddTransient<LoginPage>();

            builder.Services.AddSingleton<ProductosViewModel>();
            builder.Services.AddSingleton<ProductsView>();
            builder.Services.AddTransient<LoginUserViewModel>();
            
            builder.Services.AddTransient<ProductDetails>();
            builder.Services.AddTransient<ProductDetailViewModel>();
            builder.Services.AddTransient<PerfilViewModel>();
            builder.Services.AddTransient<PerfilView>();
            builder.Services.AddTransient<RegisterView>();
            builder.Services.AddTransient<RegisterViewModel>();
            return builder.Build();
        }
    }
}
