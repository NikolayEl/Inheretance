using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace GeometryFigure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(10, 8, 7, 10, 10, 5, "red");
            triangle.Draw();
        }
    }
}
