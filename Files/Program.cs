﻿//#define WRITE_TO_FILE
//#define READ_FROM_FILE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Convert.ToInt32(" 235"));
#if WRITE_TO_FILE
            //. - это ссылка на текущий каталог
            //.. - это ссылка на родительский каталог
            Directory.SetCurrentDirectory("..\\..");
            string currentDirectory = Directory.GetCurrentDirectory();
            Console.WriteLine(currentDirectory);
            string filename = "File.txt";
            StreamWriter sw = new StreamWriter(filename, true);
            sw.WriteLine("Hello files");
            sw.Close();
            string cmd = $"{currentDirectory}\\{filename}";
            System.Diagnostics.Process.Start("notepad", cmd);

#endif
#if READ_FROM_FILE

            Directory.SetCurrentDirectory("..\\..");
            string currentDirectory = Directory.GetCurrentDirectory();
            string filename = "File.txt";
            StreamReader sr = new StreamReader(filename);
            while(!sr.EndOfStream)
            {
                string buffer = sr.ReadLine();
                Console.WriteLine(buffer);
            }
#endif

        }
    }
}
