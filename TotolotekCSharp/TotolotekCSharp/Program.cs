using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotolotekCSharp
{
    class Program
    {
        static int[] LosowanieLiczb(int[] tab)
        {
            Random random = new Random();
             for (int i = 0; i < 6; i++)
             {
                 tab[i] = random.Next(0, 49);
             }
            for(int i = 0; i < 6; i++) // Sprawdzanie powtórzonych liczb.
            {
                for(int j = 0; j < 6; j++)
                {
                    if((tab[i] == tab[j]) && (i != j)) // Zapobieganie powtórzeniu liczb.
                    {
                        tab[i] = random.Next(0, 49);
                        i = 0;
                        break;
                    }
                }
            }
            return tab;
        }
        static int[] SkreślanieLiczb(int[] tab)
        {
            Console.WriteLine("Proszę o skreślenie sześciu liczb od 1 do 49:");
            Console.WriteLine();
            for(int i = 0; i < 6; i++)
            {
                Console.WriteLine("Skreśl " + (i + 1) + " liczbę");
                tab[i] = int.Parse(Console.ReadLine());
                
                while((tab[i] < 1) || (tab[i] > 49))
                {
                        Console.WriteLine("Podałeś liczbę poza zakresem, spórbuj ponownie: ");
                        tab[i] = int.Parse(Console.ReadLine());
                }
            }
            return tab;
        }
        static void PorównywanieLiczb()
        {
            int a = 0;
            int b = 0;
            int[] TabPom = new int[6];
            int[] tablica1 = new int[6];
            int[] tablica2 = new int[6];
            LosowanieLiczb(tablica1);
            SkreślanieLiczb(tablica2);
            for(int i = 0; i < 6; i++)
            {
                for(int j = 0; j < 6; j++)
                {
                    if (tablica1[i] == tablica2[j])
                    {
                        a++;
                        TabPom[b] = tablica1[i];
                        b++;
                    }
                }
            }
            if (a == 0)
            {
                Console.WriteLine("Ups :( Nic nie trafiłeś!");
            }
            else if (a > 2)
            {
                Console.WriteLine("Gratulacje! Trafiłeś " + a + " liczb :-) - Wygrałeś pewną kwotę");
            }
            else
            {
                Console.WriteLine("Brawo! Trafiłeś " + a + " liczb ;-)");
            }
            Console.WriteLine();
            if (a > 0)
            {
                Console.Write("Liczby, które trafiłeś, to: ");
                for (int x = 0; x < a; x++)
                {
                    Console.Write(TabPom[x] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("--------------------");
            Console.Write("Wylosowane liczby: ");
            Console.WriteLine();
            for(int i = 0; i < 6; i++)
            {
                Console.Write(tablica1[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("--------------------");
            Console.Write("Twoje liczby: ");
            Console.WriteLine();
            for (int i = 0; i < 6; i++)
            {
                Console.Write(tablica2[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("--------------------");
        }
        static void Main(string[] args)
        {
            PorównywanieLiczb();
            Console.ReadKey();
        }
    }
}
