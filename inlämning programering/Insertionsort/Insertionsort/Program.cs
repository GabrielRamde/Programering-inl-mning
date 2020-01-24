using System;

namespace Insertionsort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] storlek = { 100, 10000, 100000 };
            int[] List = rndnr(storlek[2]); //Skriv in 0, 1 eller 2 för att få ut 100, 10000 eller 100000
            Insertionsort(List);
        }
        static void Insertionsort(int[] List)
        {
            DateTime starttid = DateTime.Now;


            for (int i = 1; i < List.Length; i++)
            {

                for (int b = i; b > 0; b--)
                {

                    if (List[b] < List[b - 1])
                    {

                        int a = List[b - 1];
                        List[b - 1] = List[b];
                        List[b] = a;
                    }
                }
            }

            TimeSpan tid = DateTime.Now - starttid;

            for (int i = 0; i < List.Length; i++)
            {
                Console.WriteLine(List[i]);
            }

            Console.WriteLine($"{tid.TotalMilliseconds} ms");
        }
        static int[] rndnr(int size)
        {
            Random slump = new Random();
            int[] tal = new int[size];
            for (int i = 0; i < tal.Length; i++)
            {
                tal[i] = slump.Next(tal.Length);
            }
            return tal;
        }

    }
} 


    