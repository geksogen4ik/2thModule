using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleTwo
{
    public class ModuleTwoInvoker : IModuleTwoInvoker
    {
        public ModuleTwoInvoker()
        {
            _finderService = new FinderService();
            _fileReaderService = new FileReaderService();
            _fileSaverService = new FileSaverService();
        }

        private IFinderService _finderService { get; }
        private IFileReaderService _fileReaderService { get; }
        private IFileSaverService _fileSaverService { get; }

        public string FindFile(string locationToSearch, string fileName)
        {
            var result = string.Empty;

            try
            {
                result = _finderService.FindFile(locationToSearch, fileName);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The system could not retrieve the absolute path");
            }
            catch(PathTooLongException)
            {
                Console.WriteLine("The specified path, file name, or both exceed the system-defined maximum length");
            }
            catch(NotSupportedException)
            {
                Console.WriteLine("path contains a colon (':') that is not part of a volume identifier");
            }
            catch(Exception Error)
            {
                Console.WriteLine(Error.Message);
            }

            return result;
        }

        public string GetFileContent(string location, string fileName)
        {
            var result = string.Empty;

            try
            {
               result =  _fileReaderService.GetFileContent(location, fileName);
            }
            catch (Exception e)
            {
                // your code here
                Console.WriteLine(e.Message);
            }

            return result;
        }

        public bool SaveFile(string content, string location, string fileName)
        {
            var result = false;

            try
            {
                result = _fileSaverService.SaveFile(content, location, fileName);
            }
            catch (Exception e)
            {
                // your code here
                Console.WriteLine(e.Message);
            }

            return result;
        }
    }
}