using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayApp.Models
{
    public class Person
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Department { get; set; }

        public bool IsActive { get; set; }
    }
}
