namespace OnlineStore.Utilities
{
    public interface ILogger
    {
        void AddProvider(ILoggerProvider provider);
    }
}
