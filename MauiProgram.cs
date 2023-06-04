using Microsoft.Extensions.Logging;
using SkyPlanner.Data;
using SkyPlanner.Pages.BookPages;

namespace SkyPlanner;

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

		string dbPath = Path.Combine(FileSystem.AppDataDirectory, "skyplanner.db");
		builder.Services.AddSingleton(s =>
		ActivatorUtilities.CreateInstance<UserFlightRepository>(s, dbPath));


		//builder.Services.AddSingleton<SkyPlannerDatabase>();
		builder.Services.AddTransient<OneWay>();
        builder.Services.AddTransient<RoundTrip>();
#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
