namespace _01_Assignement_Example.Services;

public class FileService
{
    public static async Task SaveToFile(string filePath, string content)
    {
        using StreamWriter sw = new StreamWriter(filePath);
        await Task.Delay(15000);
        await sw.WriteLineAsync(content);
    }

    /*
    public static string ReadFromFile(string filePath)
    {
        using StreamReader sr = new StreamReader(filePath);
        return sr.ReadToEndAsync();

    }
    */
}
