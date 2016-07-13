namespace OnlineStore.Utilities
{
    public interface ILoggerProvider
    {
        ILogger CreateLogger(string name);
    }
}
