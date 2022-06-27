using CommunityToolkit.Maui;
using ScycareApp.ViewModel;
using Telerik.Maui.Controls.Compatibility;

namespace ScycareApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
            .UseTelerik()
            .UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("Poppins-Regular.ttf", "Poppins");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
		builder.Services.AddSingleton<ForgetPassword>();
		builder.Services.AddSingleton<RegisterViewModel>();	
		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<MainPageViewModel>();
		builder.Services.AddSingleton<VerifyCode>();
		builder.Services.AddSingleton<VerifyCodeViewModel>();

        builder.UseMauiApp<App>().UseMauiCommunityToolkit();

        return builder.Build();
	}
}
