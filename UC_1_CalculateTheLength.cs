using System;

namespace UC_2_CalculateTheLength
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable
            double x1, x2, y1, y2;
            double f1, f2, g1, g2;

            Console.WriteLine("Enter co-ordinates of line1");
            Console.WriteLine("Enter co-ordinates of (x1,y1): ");
            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());


            Console.WriteLine("Enter co-ordinates of line1");
            Console.WriteLine("Enter co-ordinates of (x2,y2): ");
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());


            Console.WriteLine("Enter co-ordinates of line1");
            Console.WriteLine("Enter co-ordinates of (f1,g1): ");
            f1 = double.Parse(Console.ReadLine());
            g1 = double.Parse(Console.ReadLine());



            Console.WriteLine("Enter co-ordinates of line1");
            Console.WriteLine("Enter co-ordinates of (f2,g2): ");
            f2 = double.Parse(Console.ReadLine());
            g2 = double.Parse(Console.ReadLine());


            double Length1 = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1)) * ((y2 - y1)));
            double Length2 = Math.Sqrt(((f2 - f1) * (f2 - f1)) + ((g2 - g1)) * ((g2 - g1)));

            Console.WriteLine("Length of line1 is = " +Length1);
            Console.WriteLine("Length of line2 is = " +Length2);
            Console.ReadLine();
        }
    }
}
    
  