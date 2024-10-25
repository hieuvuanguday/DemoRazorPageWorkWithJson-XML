using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DemoXmlSerializer02
{
    public class Person
    {
        public Person() { }
        public Person(decimal initialSalary) => Salary = initialSalary;
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public HashSet<Person> Children { get; set; }

        protected decimal Salary { get; set; }
    }
}
