using System;

namespace Samples.DefaultInterfaces
{
    internal class ConsoleLogger : ILogger
    {
        public void WriteCore(LogLevel level, string message)
        {
            Console.WriteLine($"{level}: {message}");
        }
    }
}