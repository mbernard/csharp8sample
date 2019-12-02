using System.Diagnostics;

namespace Samples.DefaultInterfaces
{
    internal class TraceLogger : ILogger
    {
        public void WriteCore(LogLevel level, string message)
        {
            switch (level)
            {
                case LogLevel.Information:
                    Trace.TraceInformation(message);
                    break;

                case LogLevel.Warning:
                    Trace.TraceWarning(message);
                    break;

                case LogLevel.Error:
                    Trace.TraceError(message);
                    break;
            }
        }
    }
}