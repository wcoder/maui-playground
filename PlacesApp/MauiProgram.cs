using PlacesApp.Interfaces;
using PlacesApp.Services;
using PlacesApp.ViewModels;

namespace PlacesApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		GoogleMapsApiService.Initialize("TODO: ADD KEY");

		var builder = MauiApp.CreateBuilder();

		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		// Pages
		builder.Services.AddTransient<MainPage>();

		// ViewModels
		builder.Services.AddTransient<MainPageViewModel>();

		// Services
		builder.Services.AddSingleton<IGoogleMapsApiService, GoogleMapsApiService>();

		return builder.Build();
	}
}
