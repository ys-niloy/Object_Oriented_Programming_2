using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStart
{
    struct OurPoint
    {
        public int x;
        public int y;

        public OurPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void PrintPoint()
        {
            Console.WriteLine("({0},{1})", this.x, this.y);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            OurPoint p1;
            p1.x = 5;
            p1.y = 7;
            p1.PrintPoint();
            //Console.WriteLine("({0},{1})", p1.x, p1.y);
            //Console.WriteLine("(" + p1.x + "," + p1.y + ")");

            OurPoint p2;
            p2.x = Convert.ToInt32(Console.ReadLine());
            p2.y = Convert.ToInt32(Console.ReadLine());
            p2.PrintPoint();
            //Console.WriteLine("({0},{1})", p2.x, p2.y);

            OurPoint p3 = p1;
            p3.x++;
            p3.y--;
            p3.PrintPoint();
            p1.PrintPoint();
            //Console.WriteLine("({0},{1})", p3.x, p3.y);
            //Console.WriteLine("({0},{1})", p1.x, p1.y);

            OurPoint p4 = new OurPoint();
            p4.x++;
            p4.y++;
            p4.PrintPoint();

            OurPoint p5 = new OurPoint(Convert.ToInt32(Console.ReadLine()), 13);
            p5.PrintPoint();

            OurPoint p6 = new OurPoint(-4, 2);
            p2 = p6;

            //System.out.println();
            //System.out.print();
            //Console.WriteLine("Welcome to \"C#\"");
            //Console.Write("Welcome to Summer semester");

            //int z = 10;
            //z = 10;
            //z++;
            //printf("info = %d", p);

            //int p = 10, q = 20, r = 30;
            //string k = "hello";

            //Console.WriteLine("p:" + p + " q:" + q + " r:" + r);
            //Console.WriteLine("p:{0} q:{1} r:{2}", p+5, k, r);
            //Console.WriteLine($"p:{p} q:{q} r:{r}");
            ////Console.WriteLine("{0}")

            //string s1 = Console.ReadLine();
            //Console.WriteLine("output: {0}", s1);

            //string s2 = Console.ReadLine();
            //int w = Convert.ToInt32(s2);
            //int w1 = Convert.ToInt32(Console.ReadLine());
            //int w2 = Int32.Parse(Console.ReadLine());
        }
    }
}
