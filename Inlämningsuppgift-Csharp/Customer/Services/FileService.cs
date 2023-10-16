namespace Assingment.Services;

internal class FileService
{
    private readonly static string filePath = @"C:\Users\masta\OneDrive\Skrivbord\customers.json";
    public static void SaveToFile(string contentAsJson)
    {

        try
        {
            using var sw = new StreamWriter(filePath);
            sw.WriteLine(contentAsJson);
            Console.WriteLine("Data sparad i filen.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Fel vid sparande av fil: " + ex.Message);
        }

    }

    public static string ReadFromFile()
    {
        if (File.Exists(filePath))
        {
            using var sr = new StreamReader(filePath);
            return sr.ReadToEnd();
        }
        return null!;
    }
}
