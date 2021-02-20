using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Moq;
using BidOne.TechnicalTask.Lib.Repositories.Interfaces;
using BidOne.TechnicalTask.Lib.Models;

namespace BidOne.TechnicalTask.Tests.Mocks.Repositories
{
    public class MockFileRepository : Mock<IFileRepository>
    {
        public MockFileRepository MockWriteFile(bool result)
        {
            Setup(x => x.WriteFile(It.IsAny<Person>(), It.IsAny<string>(), It.IsAny<string>()))
                .Returns(result);

            return this;
        }

        public MockFileRepository VerifyWriteFile(Times times)
        {
            Verify(x => x.WriteFile(It.IsAny<Person>(), It.IsAny<string>(), It.IsAny<string>()));

            return this;
        }
    }
}
