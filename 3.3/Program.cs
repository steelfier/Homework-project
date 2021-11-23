using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace TestConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //преобразование с помощью convert

            double x1 = 1.3412312312;
            int x2 = Convert.ToInt32(x1);

            string x3 = "s";
            char x4 = Convert.ToChar(x3);

            float x5 = 0.333333F;
            byte x6 = Convert.ToByte(x5);

            string x7 = "123";
            int x8 = Convert.ToInt32(x7);

            //неявное преобразование

            sbyte x = 1;
            int y = x;

            short a = 12222;
            long b = a;

            ushort c = 11111;
            int d = c;

            int e = 2/3;
            decimal f = e;

            //явное преобразование

            int g = 100;
            byte h = (byte)g;

            long i = 2222222222222222222;
            short j = (short)i;

            double k = 3/4;
            int l = (int)k;

            decimal m = 2 / 3;
            double n = (double)m;

            //преобразование с помощью Parse и TryParse

            //string y1 = "123456";
            //if (TryParsce)
            int o, p;
            bool q = int.TryParse("125", out o);
            p = int.Parse("125");
            if (q)
            { Console.WriteLine($"Преобразование удалось, o ={ o}, b ={ p}"); 
            }
            else
            { Console.WriteLine("Преобразование невозможно"); }

            double r, s;
            bool t = double.TryParse("1.111", out r);
            s = double.Parse("5.74");
            if (t)
            {
                Console.WriteLine($"Преобразование удалось, o ={ r}, b ={ s}");
            }
            else
            { Console.WriteLine("Преобразование невозможно"); }

            int u;
            Console.WriteLine(int.TryParse("123.321", out u));

        }
    }
}