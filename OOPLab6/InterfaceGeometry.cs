using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLab6
{
    public interface InterfaceGeometry
    {
        double PerimetrTraingle();
        double AreaTraingle();
        double PerimetrRectangle();
        double AreaRectangle();
    }
    class MainGeometry : InterfaceGeometry
    {
        double My_x1, My_y1, My_x2, My_y2, My_x3, My_y3, My_x4, My_y4;
        public double x1
        {
            set { My_x1 = value; }
            get { return My_x1; }
        }
        public double y1
        {
            set { My_y1 = value; }
            get { return My_y1; }
        }
        public double x2
        {
            set { My_x2 = value; }
            get { return My_x2; }
        }
        public double y2
        {
            set { My_y2 = value; }
            get { return My_y2; }
        }
        public double x3
        {
            set { My_x3 = value; }
            get { return My_x3; }
        }
        public double y3
        {
            set { My_y3 = value; }
            get { return My_y3; }
        }
        public double x4
        {
            set { My_x4 = value; }
            get { return My_x4; }
        }
        public double y4
        {
            set { My_y4 = value; }
            get { return My_y4; }
        }
        public MainGeometry() { }
        public MainGeometry(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
        }
        public MainGeometry(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
            this.x4 = x4;
            this.y4 = y4;
        }
        public virtual double PerimetrTraingle()
        {
            double Dlina1 = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            double Dlina2 = Math.Sqrt((x2 - x3) * (x2 - x3) + (y2 - y3) * (y2 - y3));
            double Dlina3 = Math.Sqrt((x3 - x1) * (x3 - x1) + (y3 - y1) * (y3 - y1));
            return Dlina1 + Dlina2 + Dlina3;
        }
        public virtual double AreaTraingle()
        {
            return Math.Abs((x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2);
        }
        public virtual double PerimetrRectangle()
        {
            double Dlina1 = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            double Dlina2 = Math.Sqrt((x2 - x3) * (x2 - x3) + (y2 - y3) * (y2 - y3));
            double Dlina3 = Math.Sqrt((x3 - x4) * (x3 - x4) + (y3 - y4) * (y3 - y4));
            double Dlina4 = Math.Sqrt((x4 - x1) * (x4 - x1) + (y4 - y1) * (y4 - y1));
            return Dlina1 + Dlina2 + Dlina3 + Dlina4;
        }
        public virtual double AreaRectangle()
        {
            double Dlina1 = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            double Dlina2 = Math.Sqrt((x2 - x3) * (x2 - x3) + (y2 - y3) * (y2 - y3));
            double Dlina3 = Math.Sqrt((x3 - x4) * (x3 - x4) + (y3 - y4) * (y3 - y4));
            double Dlina4 = Math.Sqrt((x4 - x1) * (x4 - x1) + (y4 - y1) * (y4 - y1));
            double PoluPer = (Dlina1 + Dlina2 + Dlina3 + Dlina4) / 2;
            return Math.Round(Math.Sqrt((PoluPer - Dlina1) * (PoluPer - Dlina2) * (PoluPer - Dlina3) * (PoluPer - Dlina4)));
        }
    }
}