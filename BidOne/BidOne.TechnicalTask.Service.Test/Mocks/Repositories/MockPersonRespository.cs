using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using BidOne.TechnicalTask.Lib.Repositories.Interfaces;
using BidOne.TechnicalTask.Lib.Models;

namespace BidOne.TechnicalTask.Tests.Mocks.Repositories
{
    public class MockPersonRespository : Mock<IPersonRepository>
    {
        public MockPersonRespository MockCreatePerson(Person result)
        {
            Setup(x => x.CreatePerson(It.IsAny<string>(), It.IsAny<string>()))
                .Returns(result);

            return this;
        }

        public MockPersonRespository VerifyCreatePerson(Times times)
        {
            Verify(x => x.CreatePerson(It.IsAny<string>(), It.IsAny<string>()),times);

            return this;
        }

    }
}
