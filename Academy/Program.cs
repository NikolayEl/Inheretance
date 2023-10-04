using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Program
    {
        public static readonly string Delimitr = "\n----------------------------------------------------\n";
        static void Main(string[] args)
        {
            Human human = new Human("Vercetty", "Tomy", 30);
            Console.WriteLine(human);
            Console.WriteLine(Delimitr);

            Student student = new Student("Pinkman", "Jessie", 25, "Chemistry", "WW_220", 90, 99);
            Console.WriteLine(student);
            Console.WriteLine(Delimitr);

            Teacher teacher = new Teacher("White", "Walter", 50, "Chemistry", 25);
            Console.WriteLine(teacher);
            Console.WriteLine(Delimitr);

            Gradute gradute = new Gradute("Hank", "SCHrader", 40, "Criminalistic", "OBN", 80, 70, "How to catch Heisenberg");
            Console.WriteLine(gradute);
            Console.WriteLine(Delimitr);

            Student tommy = new Student(human, "Theft", "Vice", 98, 99);
            Console.WriteLine(tommy);
            Console.WriteLine(Delimitr);

            Gradute tommyGradute = new Gradute(tommy, "How to catch Heisenberg");
            Console.WriteLine(tommyGradute);
            Console.WriteLine(Delimitr);

            Teacher tommyTacher = new Teacher(tommy, "Chemistry", 30);
            Console.WriteLine(tommyTacher);
            Console.WriteLine(Delimitr);

            Human[] group = new Human[] { student, teacher, gradute, tommy,
                new Teacher("Diaz", "Ricardo", 50, "Weapon distribution", 25) };

            Console.WriteLine(Delimitr);
            for(int i = 0; i < group.Length;i++)
            {
                //Console.WriteLine(group[i]);
                group[i].Print();
                Console.WriteLine(Delimitr);
            }
        }
    }
}
