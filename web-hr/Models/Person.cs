using System;
using System.ComponentModel.DataAnnotations;

namespace webhr.Models
{
    public class Person
    {
        public int ID { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display (Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Patronymic")]
        public string PatronymicName { get; set; }
        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }
        public string Title { get; set; } // Mr., Ms., Mrs, Miss, Dr.
        public decimal Salary { get; set; }
        public int Sex { get; set; }

        [Display(Name = "Dept ID")]
        public int DepartmentID { get; set; }
        public Department Department { get; set; }
        

        public String FullName
        {
            get { return $"{FirstName} {LastName} {PatronymicName}"; }            
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {PatronymicName}; {BirthDate}; {Title}; {Salary}; {Sex}; {DepartmentID}";
        }
    }

    
}
