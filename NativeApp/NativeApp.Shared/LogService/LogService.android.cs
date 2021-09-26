namespace NativeApp.Shared.LogService
{
    public class LogService : ILogService
    {
        public void Log(string message)
        {
            Android.Util.Log.Debug("XXX_LOG_SERVICE", message);
        }
    }
}
