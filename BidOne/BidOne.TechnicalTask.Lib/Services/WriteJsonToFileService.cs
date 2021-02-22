using System;
using System.Collections.Generic;
using System.Text;

using BidOne.TechnicalTask.Lib.Services.Interfaces;
using BidOne.TechnicalTask.Lib.Repositories.Interfaces;
using BidOne.TechnicalTask.Lib.Models;

namespace BidOne.TechnicalTask.Lib.Services
{
    /// <summary>
    /// Main service class called by the Home Controller to write data to file
    /// </summary>
    public class WriteJsonToFileService : IWriteJsonToFileService
    {
        private readonly IFileRepository _fileRepo;
        private readonly IPersonRepository _personRepo;
        public WriteJsonToFileService (IFileRepository fileRepo, IPersonRepository personRepo)
        {
            _fileRepo = fileRepo;
            _personRepo = personRepo;
        }

        public bool WriteJsonToFile(string firstname, string lastname, string filepath, string filename)
        {
            Person person = _personRepo.CreatePerson(firstname, lastname);

            return _fileRepo.WriteFile(person, filepath, filename);
        }
    }
}
