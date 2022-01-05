using Foundation;
using Microsoft.Maui.Hosting;

namespace HelloComet;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	protected override MauiApp CreateMauiApp() => App.CreateMauiApp();
}

