using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
            string path = "temp.csv";
            string[] substrings = new string[group.Length];
            int j = 0;
            foreach(Human i in group)
            {
                substrings[j] = i.ToString();
                j++;
            }
            save("temp.csv", group);
            Console.WriteLine(Delimitr);

            Human[] exam = new Human[NumberOfLines(path)];
            load(path, exam);
            foreach (Human i in exam)
            {
                Console.WriteLine($"Exam - {i}");
            }
        }
        static async void save(string path, Human[] group)
        {
            using(StreamWriter sw = new StreamWriter(path)) 
            {
                foreach(Human i in group)
                {
                    sw.WriteLine(i.PrepearForFile());
                }
                Console.WriteLine($"Writing data to file {path} is completed.");
            }
        }
        static int NumberOfLines(string path)
        {
            int count = 0;
            if (File.Exists(path))
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while ((sr.ReadLine()) != null) { count++; }
                }
            }
            return count;
        }
        static async void load(string path, Human[] human)
        {
            if(File.Exists(path))
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    string str;
                    int count = 0;
                    while((str = sr.ReadLine()) != null)
                    {
                        string[] substring = str.Split(';');
                        switch (substring[0]) 
                        {
                            case "Academy.Student":
                                Student temp = new Student(substring[1], substring[2], Convert.ToInt32(substring[3]), 
                                    substring[4], substring[5], Convert.ToDouble(substring[6]), Convert.ToDouble(substring[7]));
                                human[count] = temp;
                                count++;
                                break;
                            case "Academy.Teacher":
                                Teacher temp2 = new Teacher(substring[1], substring[2],
                                    Convert.ToInt32(substring[3]), substring[4], Convert.ToInt32(substring[5]));
                                human[count] = temp2;
                                count++;
                                break;
                            case "Academy.Gradute":
                                Gradute temp3 = new Gradute(substring[1], substring[2], Convert.ToInt32(substring[3]),
                                    substring[4], substring[5], Convert.ToDouble(substring[6]), Convert.ToDouble(substring[7]), substring[8]);
                                human[count] = temp3;
                                count++;
                                break;
                            case "Academy.Human":
                                Human temp4 = new Human(substring[1], substring[2], Convert.ToInt32(substring[3]));
                                human[count] = temp4;
                                count++;
                                break;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("File not found, try again.");
            }
        }
    }
}
