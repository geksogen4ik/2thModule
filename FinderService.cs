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


        public string FindFile(string locationToSearch, string fileName)
        {
            Console.WriteLine("Enter the file's name");
            
                        fileName = Console.ReadLine();
                    
                        locationToSearch = Path.GetFullPath(fileName);
                        return locationToSearch;
    
                }
            }
        }
    

    
        





        
     

  



    
