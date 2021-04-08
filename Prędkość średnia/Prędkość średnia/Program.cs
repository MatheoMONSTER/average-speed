using System;

namespace Prędkość_średnia
{
    class averageSpeed
    {
        private int s;
        private int t;

        public averageSpeed(int a, int b)
        {
            s = a;
            t = b;
        }
        public void calculateSpeed()
        {
            Console.WriteLine("Input route distance (in kilometers): ");
            s = int.Parse(Console.ReadLine());
            Console.WriteLine("Input time: ");
            t = int.Parse(Console.ReadLine());
            Console.WriteLine("Average speed is: {0} ", s / t);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            averageSpeed speed1 = new averageSpeed(0,0);
            speed1.calculateSpeed();
            Console.ReadKey();
        }
    }
}
