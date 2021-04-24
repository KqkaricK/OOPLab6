using System;

namespace OOPLab6
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2, x3, y3, x4, y4;
            Console.Write("X1 = "); //0
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y1 = ");//1
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("X2 = ");//3
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y2 = ");//1
            y2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("X3 = ");//3
            x3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y3 = ");//-3
            y3 = Convert.ToDouble(Console.ReadLine());
            MainGeometry A = new MainGeometry(x1, y1, x2, y2, x3, y3);
            Console.WriteLine(A.PerimetrTraingle());
            Console.WriteLine(A.AreaTraingle());
            Console.Write("X1 = ");//4
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y1 = ");//2
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("X2 = ");//8
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y2 = ");//4
            y2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("X3 = ");//6
            x3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y3 = ");//8
            y3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("X4 = ");//2
            x4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y4 = ");//6
            y4 = Convert.ToDouble(Console.ReadLine());
            A = new MainGeometry(x1, y1, x2, y2, x3, y3, x4, y4);
            Console.WriteLine(A.PerimetrRectangle());
            Console.WriteLine(A.AreaRectangle());
            Console.ReadKey();
        }
    }
}
