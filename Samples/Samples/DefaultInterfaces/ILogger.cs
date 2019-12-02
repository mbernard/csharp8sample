namespace Samples.DefaultInterfaces
{
    internal interface ILogger
    {
        void WriteCore(LogLevel level, string message);

        void WriteInformation(string message)
        {
            this.WriteCore(LogLevel.Information, message);
        }

        void WriteWarning(string message)
        {
            this.WriteCore(LogLevel.Warning, message);
        }

        void WriteError(string message)
        {
            this.WriteCore(LogLevel.Error, message);
        }
    }
}