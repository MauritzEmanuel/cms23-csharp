namespace _02_SaveAndReadToFromFile.Services
{
    internal class FileService
    {
        private static readonly string filePath = @"C:\Users\masta\OneDrive\Skrivbord\customer.json";
        public static void SaveToFile(string contentAsJson)
        {
            using var sw = new StreamWriter(filePath);
            sw.WriteLine(contentAsJson);

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
}
