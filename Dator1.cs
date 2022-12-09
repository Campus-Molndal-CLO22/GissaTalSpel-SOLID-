using GissaTalSpel_SOLID_adam___hugo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GissaTalSpel_SOLID_adam___hugo
{
    internal class Dator1 : IGuesser
    {
        public int GuessNumber(int ValtNummer)
        {

            Random Random = new Random();
            int minVärde = 1;
            int maxVärde = 1000 + 1;
            int Dator1Gissning = Random.Next(minVärde, maxVärde);
            int Dator1Gissningar = 1;
            while (true)
            {
                if (Dator1Gissning > ValtNummer)
                {
                    Dator1Gissningar++;
                    maxVärde = TooHigh(Dator1Gissning, maxVärde);
                    Console.WriteLine("Dator1 gissade på " + Dator1Gissning + " och det var för högt");
                    Dator1Gissning = Random.Next(minVärde, maxVärde);
                    Console.ReadLine();
                }
                
                if (Dator1Gissning < ValtNummer)
                {
                    Dator1Gissningar++;
                    minVärde = TooLow(Dator1Gissning, minVärde);
                    Console.WriteLine("Dator1 gissade på " + Dator1Gissning + " och det var för lågt");
                    Dator1Gissning = Random.Next(minVärde, maxVärde);
                    Console.ReadLine();
                   
                }
                else
                {
                    Correct(Dator1Gissningar);
                    return Dator1Gissningar;
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
            Console.WriteLine("Dator 1 gissade på rätt nummer efter " + AntalGissningar + " försök.");
            int Dator1Gissningar = AntalGissningar;
            return Dator1Gissningar;
        }
    }
}
