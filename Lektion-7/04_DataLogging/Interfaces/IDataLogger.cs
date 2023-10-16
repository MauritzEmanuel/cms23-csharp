namespace _04_DataLogging.Interfaces;

public interface IDataLogger
{
    void Run();
    void LogMessage();
    IEnumerable<string> Messages();
}
