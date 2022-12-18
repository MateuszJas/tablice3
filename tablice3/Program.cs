using System;

namespace tablice3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Podaj rozmiar tablicy:");
            int n = int.Parse(Console.ReadLine());

            
            int[] t1 = new int[n];

            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj wartość dla elementu o indeksie {0}:", i);
                t1[i] = int.Parse(Console.ReadLine());
            }

            
            int[] t2 = new int[n];

            
            for (int i = 0; i < n; i++)
            {
                if (t1[i] > 0)
                {
                    t2[i] = t1[i];
                }
            }

            
            Console.Write("t1 :");
            foreach (int elek in t1)
            {
                Console.Write(elek + "\t ");
            }
            Console.WriteLine();
            Console.Write("t2 :");
            foreach (int elek in t2)
            {
                Console.Write(elek + "\t ");
            }

            Console.ReadKey();
        }
    }
}
