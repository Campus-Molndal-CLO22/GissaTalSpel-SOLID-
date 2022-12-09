using GissaTalSpel_SOLID_adam___hugo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GissaTalSpel_SOLID_adam___hugo
{
    internal class Dator2 : IGuesser
    {
        public int GuessNumber(int ValtNummer)
        {

            Random Random = new Random();
            int minVärde = 1;
            int maxVärde = 1000 + 1;
            int Dator2Gissning = Random.Next(minVärde+maxVärde/2, minVärde+maxVärde/2);
            int Dator2Gissningar = 1;
            while (true)
            {
                if (Dator2Gissning > ValtNummer)
                {
                    Dator2Gissningar++;
                    maxVärde = TooHigh(Dator2Gissning, maxVärde);
                    Console.WriteLine("Dator 2 gissade på " + Dator2Gissning + " och det var för högt");
                    Dator2Gissning = Random.Next(minVärde, maxVärde);
                    Console.ReadLine();
                }

                if (Dator2Gissning < ValtNummer)
                {
                    Dator2Gissningar++;
                    minVärde = TooLow(Dator2Gissning, minVärde);
                    Console.WriteLine("Dator 2 gissade på " + Dator2Gissning + " och det var för lågt");
                    Dator2Gissning = Random.Next(minVärde, maxVärde);
                    Console.ReadLine();
                    
                }
                else
                {
                    Correct(Dator2Gissningar);
                    return Dator2Gissningar;
                }
            }
        }

        public int TooHigh(int Gissning, int maxVärde)
        {
            maxVärde = Gissning - 1;
            return maxVärde;
        }
        public int TooLow(int Gissning, int minVärde)
        {
            minVärde = Gissning + 1;
            return minVärde;
        }
        public int Correct(int AntalGissningar)
        {
            Console.WriteLine("Dator 2 gissade på rätt nummer efter " + AntalGissningar + " försök.");
            int Dator2Gissningar = AntalGissningar;
            return Dator2Gissningar;
        }
    }
}

