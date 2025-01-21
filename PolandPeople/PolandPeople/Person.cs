using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolandPeople
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Pesel { get; set; } = "";
        public DateTime BirthdayDate { get; set; }
        public string SkinColor { get; set; } = "";
        public int IdProvince { get; set; }
        public string Occupation { get; set; } = "";
    }
}
