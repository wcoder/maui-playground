namespace net6_ios;

[Register(nameof(AppDelegate))]
public class AppDelegate : UIApplicationDelegate
{
	public override UIWindow? Window { get; set; }

	public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
	{
		// create a new window instance based on the screen size
		Window = new UIWindow (UIScreen.MainScreen.Bounds);

		// create a UIViewController with a single UILabel
		var vc = new UIViewController ();
		vc.View!.AddSubview (new UILabel (Window!.Frame) {
			BackgroundColor = UIColor.White,
			TextAlignment = UITextAlignment.Center,
			Text = "Hello, iOS!"
		});
		var btn = new UIButton(new CGRect(0, 0, 100, 100)) {
			BackgroundColor = UIColor.Red,
		};
		btn.TouchUpInside += (sender, e) => {
			Console.WriteLine("Button clicked");
		};
		vc.View!.AddSubview(btn);
		Window.RootViewController = vc;

		// make the window visible
		Window.MakeKeyAndVisible ();

		return true;
	}
}
