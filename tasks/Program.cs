using System;
using MyLib;

namespace tasks;
class Program
{
    static void Main(string[] args)
    {
        int Recursion64(int m, int n)
        {
            if (m > n) return;

            if (m % 3 == 0)
            {
                Console.WriteLine(m);
                m++;
            }

            return Recursion64(m, n);
        }

        // Console.Clear();

        // int m = MyLib.MyLibClass.Input("Введите 1-е число: ");
        // int n = MyLib.MyLibClass.Input("Введите 2-е число: ");

        // Recursion64(m, n);


        int Recursion66(int m, int n, int sum = 0)
        {
            if (m > n)
            {
                return sum;
            }

            sum += m;
            m++;

            return Recursion66(m, n, sum);
        }

        // Console.Clear();

        // int m = MyLib.MyLibClass.Input("Введите 1-е число: ");
        // int n = MyLib.MyLibClass.Input("Введите 2-е число: ");

        // int sum = Recursion66(m, n);
        // Console.WriteLine(sum);


        int Recursion68(int m, int n, int result = 0)
        {
            if (m == 0)
            {
                return n + 1;
            }
            else if (m > 0 && n == 0)
            {
                return Recursion68(m - 1, 1);
            }
            else
            {
                return Recursion68(m - 1, Recursion68(m, n - 1));
            }
        }   

        // Console.Clear();

        // int m = MyLib.MyLibClass.Input("Введите 1-е число: ");
        // int n = MyLib.MyLibClass.Input("Введите 2-е число: ");

        // int result = Recursion68(m, n);
        // Console.WriteLine($"A({m},{n}) = {result}");
    }
}