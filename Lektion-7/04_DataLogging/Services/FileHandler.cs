using _04_DataLogging.Interfaces;

namespace _04_DataLogging.Services;

internal class FileHandler : IFileHandler
{
    public IEnumerable<string> ReadFromFile(string filePath)
    {
        if (File.Exists(filePath))
            return File.ReadAllLines(filePath);

        return null!;
    }

    public void SaveToFile(string filePath, string content)
    {
        throw new NotImplementedException();
    }

}
