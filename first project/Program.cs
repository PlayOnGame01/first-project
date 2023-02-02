using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_project
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ввод данных
            //////Задание 1
            //Console.WriteLine("It's easy to win forgiveness for being wrong;");
            //Console.WriteLine("being right is what gets you into real trouble.");
            //Console.WriteLine("Bjarne Stroustrup ");

            //////Задание 2
            //double z = Convert.ToDouble(Console.ReadLine());
            //double x = Convert.ToDouble(Console.ReadLine());
            //double c = Convert.ToDouble(Console.ReadLine());
            //double v = Convert.ToDouble(Console.ReadLine());
            //double b = Convert.ToDouble(Console.ReadLine());
            //double n = Convert.ToDouble(Console.ReadLine());
            //double m = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(z);
            //Console.WriteLine(x);
            //Console.WriteLine(c);
            //Console.WriteLine(v);
            //Console.WriteLine(b);
            //Console.WriteLine(n);
            //Console.WriteLine($"{z} + {x} + {c} + {v} + {b} + {n} =");

            //////Задание 3
            ////////////////////////////////
            //string z = Console.ReadLine();
            //string x = Console.ReadLine();
            //string c = Console.ReadLine();
            //string v = Console.ReadLine();
            //string b = Console.ReadLine();
            //string n = Console.ReadLine();
            //Console.WriteLine($"{z}  {x}  {c}  {v}  {b}  {n} ");
            //Console.WriteLine($"{n}  {b}  {v}  {c}  {x}  {z} ");
            ////////////////////////////////
            //int num, res = 0;
            //Console.Write("enter number: ");
            //num = Int32.Parse(Console.ReadLine());
            //while (num > 0)
            //{
            //    res *= 10;
            //    res += num % 10;
            //    num /= 10;
            //}
            //Console.WriteLine(res);
            //////Задание 4
            int n = int.Parse(Console.ReadLine());
            long n1 = 0, n2 = 1, t;

            for (int i = 1; i < n; i++)
            {
                t = n1 + n2;
                n1 = n2;
                n2 = t;
            }

            Console.WriteLine(n == 0 ? 0 : n2);
            //////Задание 5
            //int a = 3, b = 7;
            //for (int i = a; i <= b; ++i)
            //{
            //    for (int j = 0; j < i; ++j)
            //    {
            //        Console.Write(i.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}
            //////Задание 6
            #endregion
        }
    }
}
