using BidOne.TechnicalTask.Lib.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BidOne.TechnicalTask.Lib.Repositories.Interfaces
{
    public interface IPersonRepository
    {
        Person CreatePerson(string firstname, string lastname);
    }
}
