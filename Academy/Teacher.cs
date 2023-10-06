using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Teacher:Human
    {
        public string Speciality { get; set; }
        public int Experience { get; set; }
        public Teacher (string lastName, string firstName, int age, string speciality, int experience):base (lastName, firstName, age)
        {
            Speciality = speciality;
            Experience = experience;
            Console.WriteLine($"TConstructor:\t {this.GetHashCode()}");
        }
        public Teacher (Human human, string speciality, int experience):base(human)
        {
            Speciality = speciality;
            Experience = experience;
        }
        public Teacher(Teacher other):base (other)
        {
            Speciality = other.Speciality;
            Experience = other.Experience;
            Console.WriteLine($"TCopyConstructor:\t {this.GetHashCode()}");
        }
        ~Teacher()
        {
            Console.WriteLine($"Destructor:\t {this.GetHashCode()}");
        }

        public override string ToString()
        {
            return base.ToString() + $";{Speciality}; {Experience}";
        }
        public override void Print()
        {
            base.Print();
            Console.Write($"{Speciality} {Experience}");
        }
        public override void Init(string[] values)
        {
            base.Init(values);
            Speciality = values[4];
            Experience = Convert.ToInt32(values[5]);
        }
        public override string PrepearForFile()
        {
            return base.PrepearForFile() + $";{Speciality};{Experience}";
        }
    }
}
