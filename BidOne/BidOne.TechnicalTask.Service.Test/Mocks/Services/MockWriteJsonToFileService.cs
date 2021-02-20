using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using BidOne.TechnicalTask.Lib.Services.Interfaces;
using BidOne.TechnicalTask.Lib.Models;

namespace BidOne.TechnicalTask.Service.Test.Mocks.Services
{
    public class MockWriteJsonToFileService
    {
        public class MockTeamService : Mock<IWriteJsonToFileService>
        {
            public MockTeamService WriteJsonToFile(bool result)
            {
                Setup(x => x.WriteJsonToFile(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()))
                    .Returns(result);

                return this;
            }

            public MockTeamService VerifyWriteJsonToFile(Times times)
            {
                Verify(x => x.WriteJsonToFile(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()),times);

                return this;
            }
        }
    }
}
