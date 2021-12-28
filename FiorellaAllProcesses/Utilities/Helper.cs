using FiorellaAllProcesses.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.IO;
using System.Threading.Tasks;

namespace FiorellaAllProcesses.Utilities
{
    public static class Helper
    {
         public static void RemoveFile(string root,string folder,string image)
         {
            string path = Path.Combine(root, folder, image);
            if (File.Exists(path))
            {
                File.Delete(path);
            }
         }
        
    }
}
