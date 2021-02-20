using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BidOne.TechnicalTask.Lib.Models;
using BidOne.TechnicalTask.Lib.Services;
using BidOne.TechnicalTask.Lib.Repositories;
using System.Configuration;
using System.Reflection;
using System.IO;
using File = BidOne.TechnicalTask.Lib.Models.File;
using Moq;
using BidOne.TechnicalTask.Tests.Mocks.Repositories;


namespace BidOne.TechnicalTask.Tests.Services

{
    [TestClass]
    public class WriteJsonToFileServiceTests
    {
     
        [TestMethod]
        public void WritePersonToFileSuccess()
        {
           
            Person person = new Person { FirstName = "Vladan", LastName = "Neziri" };
            
            File f = new File { FileName = person.FirstName + "_" + person.LastName, FilePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) };

            var mockPersonRepo = new MockPersonRespository().MockCreatePerson(person);
            var mockFileRepo = new MockFileRepository().MockWriteFile(true);

            var writeJsonToFileService = new WriteJsonToFileService(mockFileRepo.Object, mockPersonRepo.Object);

            var result = writeJsonToFileService.WriteJsonToFile(person.FirstName, person.LastName, f.FileName, f.FilePath);

            Assert.IsTrue(result);
            mockPersonRepo.VerifyCreatePerson(Times.Once());
            mockFileRepo.VerifyWriteFile(Times.Once());
        }
    }
}
