
namespace FileManager
{
    public class Manager
    {
        public string ReadFile(string fileName)
        {
            return System.IO.File.ReadAllText(fileName);
        }

        public void WriteToTextFile(string contents, string fileName)
        {
            System.IO.File.WriteAllText(fileName, contents);
        }
    }
}