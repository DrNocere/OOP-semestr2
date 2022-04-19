namespace lab_3
{
    public interface ILogger : IDisposable
    {
        void Log(params String[] messages);
    }
}