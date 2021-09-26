using System;

namespace NativeApp.Shared.LogService
{
    public class LogService : ILogService
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
