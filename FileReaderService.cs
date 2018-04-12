using System;
using System.IO;
using System.Linq;

namespace ModuleTwo
{
    public interface IFileReaderService
    {
        string GetFileContent(string location, string fileName);
    }

    public class FileReaderService : IFileReaderService
    {
        public string GetFileContent(string location, string fileName)
        {
            //your code here
            var file = location + fileName;

            string content = new string(ReadTextFile(file));
            Console.Write(content);
            return content;
        }

        public char[] ReadTextFile(string file)
        {
            var text = File.ReadAllText(file).ToCharArray().Reverse().ToArray();
            return text;
        }
    }
}
    
