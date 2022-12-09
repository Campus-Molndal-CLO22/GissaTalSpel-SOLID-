using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GissaTalSpel_SOLID_adam___hugo.Interfaces
{
    internal interface IGuesser
    {
        
        int GuessNumber(int ValtNummer);
        int TooHigh(int Gissning, int maxVärde);
        int TooLow(int Gissning, int minVärde);
        int Correct(int AntalGissningar);
    }
    
}

    
        
        

        //public class Dator2
        //{
        //    void Dator2Gissning(int ValtNummer)
        //    {
        //        Random Random2 = new Random();
        //        int minVärde = 1;
        //        int maxVärde = 1000 + 1;
        //        int Dator2Gissning = Random2.Next(minVärde + 499, maxVärde - 501);
        //        int Dator2Gissningar = 0;
        //        while (true)
        //        {
        //            if (Dator2Gissning > ValtNummer)
        //            {
        //                Dator2Gissningar++;
        //                maxVärde = Dator2Gissning;
        //                Console.WriteLine("Dator2 gissade på " + Dator2Gissning + " och det var för högt");
        //                Dator2Gissning = Random2.Next(minVärde, maxVärde);
        //                Console.ReadLine();
        //            }
        //            if (Dator2Gissning < ValtNummer)
        //            {
        //                Dator2Gissningar++;
        //                minVärde = Dator2Gissning;
        //                Console.WriteLine("Dator2 gissade på " + Dator2Gissning + " och det var för lågt");
        //                Dator2Gissning = Random2.Next(minVärde, maxVärde);
        //                Console.ReadLine();
        //            }
        //            else
        //            {
        //                Console.WriteLine("Dator2 gissade på rätt nummer efter " + Dator2Gissningar + " försök.");
        //                Console.ReadLine();
        //                break;
        //            }
        //        }
        //    }
//        }
//    }
//}
