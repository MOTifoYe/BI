using System;
using System.Numerics;

namespace Гипергеометрия
{
    class Program
    {
        static void Main()
        {
            double P;
            int n,m,N,M;
            N = 36;
            n = M = 5;
            m = 3;

            P = Gipergeometr(m, n, M, N);
            P = Math.Round(P * 100, 3);
            Console.WriteLine($"Вероятность {P}%");

            P = Gipergeometr(0, n, M, N) + Gipergeometr(1, n, M, N) + Gipergeometr(1, n, M, N);
            P = Math.Round(P, 3);
            Console.WriteLine($"Вероятность выигрыша {P}%");
            Console.WriteLine($"Вероятность проигрыша {100-P}%");

            
        }
        static BigInteger Factorial(int a)
        {
            BigInteger res = 1;

            for (int i = 1; i <= a; i++)
            {
                res *= i;
            }

            return res;
        }
        static double Sochetanie(int m, int n) => (double)(Factorial(n) / (Factorial(m) * Factorial(n - m)));
        static double Gipergeometr(int m, int n, int M, int N) => Sochetanie(m, M) * Sochetanie(n - m, N - M) / Sochetanie(n, N);
    }
}
