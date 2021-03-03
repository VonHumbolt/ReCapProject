using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.Utilities.Helpers
{
    public class FileHelper
    {
        public static string Add(IFormFile formFile)
        {
            var path = CreateImageDirectoryPath();
            string defaultImage = "default.png";

            if (formFile != null)
            {
                string filePath = CreateFileNameWithGuid(formFile.FileName);

                string imagePath = Path.Combine(path, filePath);

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                using (FileStream stream = new FileStream(imagePath, FileMode.Create))
                {
                   
                    formFile.CopyTo(stream);
                   
                }
                return imagePath;
            }
            else
            {
                return Path.Combine(path, defaultImage);
            }
     
        }

        public static void Delete(string imagePath)
        {
            if (File.Exists(imagePath))
            {
                File.Delete(imagePath);
            }
        }

        public static string Update(string oldPath, IFormFile formFile)
        {
            string updatedImagePath = CreateFileNameWithGuid(oldPath);

            var path = CreateImageDirectoryPath();

            string imagePath = Path.Combine(path, updatedImagePath);

            if (File.Exists(oldPath))
            {
                using (FileStream stream = new FileStream(imagePath, FileMode.Create))
                {
                    formFile.CopyTo(stream);
                }
                File.Delete(oldPath);
            }
            return imagePath;
        }


        public static string CreateFileNameWithGuid(string fileName)
        {
            string fileExtension = Path.GetExtension(fileName);

            string newFileName = $"{Guid.NewGuid()}{fileExtension}";

            return newFileName;
        }

        public static string CreateImageDirectoryPath()
        {
            string directory = Environment.CurrentDirectory + @"\wwwroot\";

            string path = Path.Combine(directory, "Images");

            return path;
        }
    }
}
