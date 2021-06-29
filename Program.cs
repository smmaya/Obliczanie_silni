using System;

namespace Oblicz_Silnię
{
    /// Silnia.
    class Silnia
    {
        /// Silnia rekurencyjnie
        private static int silnia1(int i)
        {
            if (i < 1)
                return 1;
            else
                return i * silnia1(i - 1);
        }

        static void Main(string[] args)
        {
            String line;
            int n = 0;

            Console.WriteLine("Podaj dla jakiej liczby obliczyć silnię: \n");
            line = Console.ReadLine();
            n = int.Parse(line);

            //Console.WriteLine(n + "! = " + silnia1(5));
            Console.WriteLine(n + "! = " + silnia1(n));
            Console.ReadKey();
        }
       
    }
}