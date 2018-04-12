using System;
using System.IO;

namespace FileSaverService
{
    public interface IFileSaverService
    {
        bool SaveFile(string content, string location, string fileName);
    }

    public class FileSaverService : IFileSaverService
    {
       
        public bool SaveFile(string content, string location, string fileName)
        {
            bool result = false;

            try
            {
                string newFileName = fileName.Replace(".txt", "_reverse.txt");

                string newLocation = Path.Combine(Path.GetDirectoryName(location), newFileName);

                File.Move(location, newLocation);
                File.WriteAllText(newLocation, content);

                result = true;
            }
            catch (FileNotFoundException)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("file location" + location + " not found.");
                Console.ResetColor();
            }
            catch (IOException)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Incorrect file name. ");
                Console.ResetColor();
            }

            return result;
        }
    }
}
