using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using BidOne.TechnicalTask.Lib.Models;
using BidOne.TechnicalTask.Lib.Repositories.Interfaces;
using Newtonsoft.Json;

namespace BidOne.TechnicalTask.Lib.Repositories
{
    /// <summary>
    /// This class will be used to create the file and save it to the App_Data/JsonFiles folder
    /// </summary>
    public class FileRepository : IFileRepository
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

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
                string localName = newFile.FilePath + newFile.FileName;

                if (!System.IO.File.Exists(localName))
                {
                    System.IO.File.WriteAllText(localName, JsonConvert.SerializeObject(model));
                    logger.Info("File successfully created");
                }

            }
            catch (System.IO.IOException ex)
            {
                logger.Error(ex.Message);
                return false;
            }
            return true;
        }
    }
}
