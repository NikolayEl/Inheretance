using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Gradute:Student
    {
        public string Thesis {  get; set; }

        public Gradute(string lastName, string firstName, int age, string speciality,
            string group, double rating, double attendance, string thesis):base(lastName, firstName, age, speciality, group, rating, attendance)
        { 
            Thesis = thesis;
            Console.WriteLine($"GConstructor:\t {this.GetHashCode()}");
        }
        public Gradute(Student student, string thesis):base(student) 
        {
            Thesis = thesis;
        }
        ~Gradute()
        {
            Console.WriteLine($"GConstructor:\t {this.GetHashCode()}");
        }

        public override string ToString()
        {
            return base.ToString() + $" {Thesis}";
        }
        public override string PrepearForFile()
        {
            return base.PrepearForFile() + $";{Thesis}";
        }
    }
}
