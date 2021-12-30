

using FiorellaAllProcesses.DAL;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FiorellaAllProcesses.Utilities
{
    public static class Extension
    {
        public static bool CheckType(this IFormFile file, string type)
        {
            return file.ContentType.Contains(type);
        }
        public static bool CheckSize(this IFormFile file,int size)
        {
            return file.Length / 1024 > size;
        }
        public async static Task<string> SaveFileAsync(this IFormFile file,string root,string folder)
        {
            string fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            string rootPath = Path.Combine(root, folder, fileName);
            using (FileStream fileStream = new FileStream(rootPath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }
            return fileName;
        }
    }
}
