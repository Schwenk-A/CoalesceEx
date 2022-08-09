using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoalesceExample
{
    public class Employer
    {
        public Company PlaceOfEmployment { get; set; }

        public List<Person> Employees { get; set; }
    }
}
