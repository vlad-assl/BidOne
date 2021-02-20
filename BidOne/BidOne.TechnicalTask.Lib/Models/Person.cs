using System.ComponentModel;

namespace BidOne.TechnicalTask.Lib.Models
{
    public class Person
    {
        [DisplayName("First Name")]

        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }
    }
}
