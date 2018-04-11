using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;


namespace ModuleTwo
{
    public interface IFinderService
    {
        string FindFile(string locationToSearch, string fileName);
    }

    public class FinderService : IFinderService
    {
        private object directory;

        public string FindFile(string locationToSearch, string fileName)
        {
            //Console.WriteLine("What file do you search?");
            fileName = "CatchMeIfYouCan.txt";
            locationToSearch = @"D:\";

            foreach (string file in Directory.GetFiles(locationToSearch))
            {
                if (new FileInfo(file).Name.Equals(fileName))
                {
                    Console.WriteLine(file);
                    Console.ReadKey();
                    return file;
                }
            }
            Console.ReadKey();
            return "";

        }

    }

}

    


            
        
    

    
        





        
     

  



    
