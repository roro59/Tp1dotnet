using System;

namespace ConsoleFirstProgram
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Facto(-1));
            Console.WriteLine(Facto(0));
            Console.WriteLine(Facto(1));
            Console.WriteLine(Facto(4));
        }

        private static int Facto(int nb)
        {
            if (nb < 0)
                return -1;
            int res = 1;
            for (int i = nb; i > 0; i--)
            {
                res *= i;
            }
            return res;
        }
    }
}