using _01_DataLogging.Interfaces;
using System.Linq.Expressions;

namespace _01_DataLogging.Services;

internal class FileManager : IFileManager
{
    public string ReadFromFile(string filePath)
    {
        throw new NotImplementedException();
    }

    public bool SaveToFile(string filePath, string content)
    {
        try
        {
            using StreamWriter sw = new StreamWriter();
            sw.WriteLine(content);
            return true;
        }
        catch { }

        return false;
    }
}
