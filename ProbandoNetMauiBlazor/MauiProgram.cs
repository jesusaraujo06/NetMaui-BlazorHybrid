using Microsoft.Extensions.Logging;
using ProbandoNetMauiBlazor.Data;
using MudBlazor.Services;
using ProbandoNetMauiBlazor.Models;
using ProbandoNetMauiBlazor.Services;

namespace ProbandoNetMauiBlazor;

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

        

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif

        builder.Services.AddMudServices();
		builder.Services.AddSingleton<WeatherForecastService>();
        builder.Services.AddSingleton<IRickAndMortyService, RickAndMortyService>();

        return builder.Build();
	}
}
