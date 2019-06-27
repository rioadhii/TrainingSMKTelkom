using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamentals.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string FullName
        {
            get
            {
                return String.Join(' ', this.FirstName, this.MiddleName, this.LastName);
            }
        }

        public int Age
        {
            get
            {
                return DateTime.Now.Year - BirthDate.Year;
            }
        }
    }
}
