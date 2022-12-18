using System;

namespace tablice3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pobierz rozmiar tablicy od użytkownika
            Console.WriteLine("Podaj rozmiar tablicy:");
            int n = int.Parse(Console.ReadLine());

            // Stwórz tablicę t1 o podanym rozmiarze
            int[] t1 = new int[n];

            // Wypełnij tablicę t1 wartościami podanymi przez użytkownika
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj wartość dla elementu o indeksie {0}:", i);
                t1[i] = int.Parse(Console.ReadLine());
            }

            // Stwórz tablicę t2 o takim samym rozmiarze, jak t1
            int[] t2 = new int[n];

            // Przepisz dodatnie elementy z tablicy t1 do tablicy t2
            for (int i = 0; i < n; i++)
            {
                if (t1[i] > 0)
                {
                    t2[i] = t1[i];
                }
            }

            // Wyświetl zawartość tablicy t2
            Console.WriteLine("Zawartość tablicy t2:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(t2[i]);
            }

            Console.ReadKey();
        }
    }
}
