using System;

namespace Oop3
{
    class SmsLoggerService : ILoggerService
    {
        public void log()
        {
            Console.WriteLine("SMS gönderildi.");
        }
    }
}
