using System;
using System.Collections.Generic;
using System.Text;

namespace BidOne.TechnicalTask.Lib.Services.Interfaces
{
    public interface IWriteJsonToFileService
    {
        bool WriteJsonToFile(string firstname, string lastname, string filepath, string filename);
    }
}
