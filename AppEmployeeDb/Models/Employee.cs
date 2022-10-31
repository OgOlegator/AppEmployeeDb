using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEmployeeDb.Models
{
    public class Employee
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Birthday { get; set; }

        public string JobTitle { get; set; }

        public string Subdivision { get; set; }

    }
}
