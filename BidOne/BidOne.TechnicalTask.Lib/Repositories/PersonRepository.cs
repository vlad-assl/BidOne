using System;
using System.Collections.Generic;
using System.Text;
using BidOne.TechnicalTask.Lib.Models;
using BidOne.TechnicalTask.Lib.Repositories.Interfaces;
using Newtonsoft.Json;

namespace BidOne.TechnicalTask.Lib.Repositories 
{
    /// <summary>
    /// Class implements PersonRepository interface and provides functionality to create a new person
    /// </summary>
    public class PersonRepository : IPersonRepository
    {
       

        /// <summary>
        /// Create new person
        /// </summary>
        /// <param name="firstname">First name of the person</param>
        /// <param name="lastname">Last Name of the person</param>
        public Person CreatePerson(string firstname, string lastname)
        {
            return new Person
            {
                FirstName = firstname,
                LastName = lastname

            };
        }
    }
}
