using BidOne.TechnicalTask.Lib.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BidOne.TechnicalTask.Lib.Repositories.Interfaces
{
    public interface IFileRepository
    {
        File ReadFile(string filePath);
        bool WriteFile(Person model, string filePath, string fileName);
       

    }
}
