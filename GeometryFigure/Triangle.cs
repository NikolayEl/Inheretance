using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace GeometryFigure
{
    internal class Triangle: Shape
    {
        const int MinSide = 20;
        const int MaxSide = 500;
        public double SideOne {  get; set; }
        public double SideTwo { get; set; }
        public double SideThree {  get; set; }
        public double Heigth { get
            {
                return (2 * GetArea()) / Math.Max(Math.Max(SideOne, SideTwo), SideThree);
            }
            set { }  }
        public Triangle(double sideOne,  double sideTwo, double sideThree, 
            int startX = 10, int startY = 10, int lineWidth = 5, string color = "") : base(startX, startY, lineWidth, color)
        {
            double maxSide = Math.Max(Math.Max(sideOne, sideTwo), sideThree);
            double minSide = Math.Min(Math.Min(sideOne, sideTwo), sideThree);
            double threeSide = (sideOne + sideTwo + sideThree) - (maxSide + minSide);
            if (maxSide >= (minSide + threeSide)) maxSide = (minSide + threeSide) - 10;
            SideOne = maxSide;
            SideTwo = minSide;
            SideThree = threeSide;
            this.color = base.color;
        }

        Triangle(double cattleA, double cattleB,
            int startX = 10, int startY = 10, int lineWidth = 5, string color = "") : base(startX, startY, lineWidth, color)
        {
            SideTwo = cattleA;
            SideOne = cattleB;
            SideThree = Math.Round(Math.Sqrt((cattleA * cattleA) + (cattleB * cattleB)), 1);
            this.color = base.color;
            base.Ppen = new Pen(this.color, lineWidth);
        }

        public override double GetArea()
        {
            double pPerimetr = GetPerimetr() / 2;
            return Math.Round(pPerimetr * (pPerimetr - SideOne) * (pPerimetr - SideTwo) * (pPerimetr - SideThree), 1);
        }

        public override double GetPerimetr()
        {
            return SideOne + SideTwo + SideThree;
        }

        public void PolygonTriangle(object sender, PaintEventArgs e, Point[] point)
        {
            Graphics g = e.Graphics; // Описать поверхность рисования
            DrawTriangle(g, point); // Нарисовать треугольник
        }
        public void DrawTriangle(Graphics g, Point[] point)
        {
            g.DrawPolygon(Ppen, point);
        }

        public override void Draw()
        {
            base.Draw();
            double aCattle = Math.Round(Math.Sqrt((SideTwo * SideTwo) - (Heigth * Heigth)));
            double bCattle = SideOne - aCattle;
            base.Ppen = new Pen(this.color, LineWidth);
            Point[] point = new Point[3];
            point[0].X = StartX; point[0].Y = StartY;
            point[1].X = StartX + (int)bCattle; point[1].Y = StartY + (int)Heigth;
            point[2].X = StartX - (int)aCattle; point[2].Y = StartY + (int)Heigth;
            PaintEventArgs e;
            PolygonTriangle(MouseButtons.Left, e, point);

        }

    }
}
