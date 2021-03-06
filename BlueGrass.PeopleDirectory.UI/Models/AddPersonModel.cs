using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueGrass.PeopleDirectory.UI.Models
{
    public class AddPersonModel
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string ProfilePicture { get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public int Gender { get; set; }
        public int City { get; set; }
        public int Country { get; set; }
    }
}
