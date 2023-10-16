using System.Diagnostics;

namespace Shared.Handlers
{
    public class FileHandler
    {
        public static void SaveToFile(string path, string content)
        {
            try
            {
                using var sw = new StreamWriter(path);
                sw.WriteLine(content);
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
        }

        public static void ReadFromFile(string path)
        {
            if (File.Exists(path))
            {
                return
            }
        }
    }
}
