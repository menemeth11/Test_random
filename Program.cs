using System;

namespace testRandom
{
    class Program
    {

        static void Main(string[] args)
        {
            int parzysta = 0;
            int nieparzysta = 0;
            int remis = 0;

            for (int i = 0; i < 10000000; i++) //1 - parzysta, 2 - nieparszysta, 3 - remis;
            {
                int zmienna = jedenSto();

                if (zmienna == 1)
                {
                    parzysta += 1;
                } 
                else if (zmienna == 2)
                {
                    nieparzysta += 1;
                }
                else
                {
                    remis += 1;
                }
            }

            Console.WriteLine("Dla liczb od 1 do 100 przy 10000000 testów po 100 przejsć: "); // 10tyś rand
            Console.WriteLine("Wygrała liczba parzysta: " + parzysta);
            Console.WriteLine("Wygrała liczba nieparzysta: " + nieparzysta);
            Console.WriteLine("Wygrała liczba remis: " + remis);
            Console.WriteLine("");


            int parzysta1 = 0;
            int nieparzysta1 = 0;
            int remis1 = 0;

            for (int i = 0; i < 10000000; i++) //1 - liczba 0, 2 - liczba 1, 3 - remis;
            {
                int zmienna1 = jedenZero();

                if (zmienna1 == 1)
                {
                    parzysta1 += 1;
                }
                else if (zmienna1 == 2)
                {
                    nieparzysta1 += 1;
                }
                else
                {
                    remis1 += 1;
                }
            }

            Console.WriteLine("Dla liczb 0 do 1 przy 10000000 testów po 100 przejsć: "); // 10tyś rand
            Console.WriteLine("Wygrała liczba 0: " + parzysta1);
            Console.WriteLine("Wygrała liczba 1: " + nieparzysta1);
            Console.WriteLine("Wygrała liczba remis: " + remis1);
        }

        public static int jedenZero()
        {
            Random rnd = new Random();
            int x;
            int x0 = 0;
            int x1 = 0;

            for (int i = 0; i < 100; i++)
            {
                x = rnd.Next(0, 2);
                if (x == 0)
                    x0 += 1;
                else
                    x1++;
            }
            //Console.WriteLine("Liczba 0 wystąpiła: " + x0 + " a liczba 1 wystąpiła: " + x1);

            if (x0 > x1)
                return 1;
            else if (x1 > x0)
                return 2;
            else
                return 3;
        }

        public static int jedenSto()
        {
            Random rnd2 = new Random();
            int y;
            int y0 = 0;
            int y1 = 0;

            for (int i = 0; i < 100; i++)
            {
                y = rnd2.Next(1, 101);
                if (y % 2 == 0)
                    y0 += 1;
                else
                    y1 += 1;
            }
            //Console.WriteLine("Liczba parzysta wystąpiła: " + y0 + " a liczba nieparzysta wystąpiła: " + y1);

            if (y0 > y1)
                return 1;
            else if (y1 > y0)
                return 2;
            else
                return 3;
        }
    }
}
