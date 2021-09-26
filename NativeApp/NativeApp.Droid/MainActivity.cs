using NativeApp.Shared.LogService;

namespace NativeApp.Droid
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);


            ILogService logger = new LogService();
            logger.Log("test message from Android");

        }
    }
}