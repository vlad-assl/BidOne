using System;
using System.Collections.Generic;
using System.Text;
using BidOne.TechnicalTask.Lib.Models;
using BidOne.TechnicalTask.Lib.Repositories.Interfaces;
using Newtonsoft.Json;

namespace BidOne.TechnicalTask.Lib.Repositories
{
    public class FileRepository : IFileRepository
    {

        public File ReadFile(string filePath)
        {
            return JsonConvert.DeserializeObject<File>(System.IO.File.ReadAllText(filePath));
        }

        public bool WriteFile(Person model, string filePath, string fileName)
        {
            File newFile = new File
            {
                FileName = fileName,
                FilePath = filePath

            };
            try
            {
                System.IO.File.WriteAllText(newFile.FilePath, JsonConvert.SerializeObject(model));
            }
            catch (System.IO.IOException)
            {
                return false;
            }
            return true;
        }
    }
}
