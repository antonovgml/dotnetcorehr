using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace webhr.Models
{
    public class Department
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int State { get; set; }
        public ICollection<Person> Persons { get; set; }

    }
}
