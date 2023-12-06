using Microsoft.Extensions.Logging;
using ProvaPDMI6.Data;
using ProvaPDMI6.Services;

namespace ProvaPDMI6;

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
			}).UseMauiMaps();

		builder.Services.AddMauiBlazorWebView();


#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif

		builder.Services.AddSingleton<ILivroService, LivroService>();

		return builder.Build();
	}
}
