using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigure
{

    internal class Shape
    {
        // Ограничения до границ экрана
        const int MinStartX = 10;
        const int MinStartY = 10;       
        const int MaxStartX = 500;
        const int MaxStartY = 600;
        ////////////////////////////////
        public int StartX {  get; set; }
        public int StartY { get; set; }
        public int LineWidth { get; set; }
        public Color color { get; set; }
        public Pen Ppen {  get; set; }

        static Color ColorSelection(string select)
        {
            switch (select)
            {
                case "red":
                    return Color.Red;
                    break;
                case "green":
                    return Color.Green;
                    break;
                case "blue":
                    return Color.Blue;
                    break;
                default:
                    return Color.White;
                    break;
            }
            return Color.White;
        }

        public Shape(int startX, int startY, int lineWidth, string color)
        { 
            StartX = startX;
            StartY = startY;
            LineWidth = lineWidth;
            this.color = ColorSelection(color);
            Ppen = new Pen(this.color, lineWidth);
        }

        public virtual double GetArea() => 0;
        public virtual double GetPerimetr() => 0;
        public virtual void Draw() { }
        public virtual void Info() 
        {
            Console.WriteLine($"Area of the figure: {GetArea()}");
            Console.WriteLine($"Figure perimeter:\t {GetPerimetr()}");
            Draw();
        }


    }
}
