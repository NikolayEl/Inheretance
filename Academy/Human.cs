using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Human
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public Human(string lastName, string firstName, int age)
        {
            LastName = lastName;
            FirstName = firstName;
            Age = age;
            Console.WriteLine($"HConstructor:\t {this.GetHashCode()}");
        }
        public Human(Human other)
        {
            LastName = other.LastName;
            FirstName = other.FirstName;
            Age = other.Age;
            Console.WriteLine($"HCopyConstructor:\t {this.GetHashCode()}");
        }
        ~Human()
        {
            Console.WriteLine($"HDesstructor:\t {this.GetHashCode()}");
        }
        public override string ToString()
        {
            return $"{LastName} {FirstName} {Age}";
        }
        public virtual void Print()
        {
            Console.WriteLine(this.GetType());
            Console.WriteLine($"{LastName} {FirstName} {Age}");
        }
        public virtual string PrepearForFile()
        {
            return $"{this.GetType()};{LastName};{FirstName};{Age}";
        }
    }
}
