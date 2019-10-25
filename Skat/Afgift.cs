using System;

namespace Skat
{
    public class Afgift
    {
        
        
        public static double BilAfgift(double pris)
        {
            double vbilAfGift = 0;  

            if (pris < 200000 || pris == 200000) // Tjekker om pris er mindre eller lige med 200000. 
            {
                vbilAfGift = pris * 0.85;  
            }
            else if (pris > 200000) // Tjekker om pris større end 200000
            {
                vbilAfGift = (pris * 1.50) - 130000; 
            }
            else if (pris < 0) // Tjekker om pris er under 0
            {
                throw new ArgumentException("Det tal du har indtastet er negativt."); // kaster en ny Exception hvis pris er negativt.
            }

            return vbilAfGift; // retunere vbilAfGift når en if eller else er mødt.

        }

        public static double ElBilAfgift(double pris)
        {
            
            double vbilAfgift = 0; 

            if (pris <= 200000) // Tjekker om pris er mindre eller lige med 200000. 
            {
                vbilAfgift = pris * 0.85;
            }
            else if (pris > 200000) // Tjekker om pris større end 200000
            {
                vbilAfgift = (pris * 1.50) - 130000;
            }

            else if (pris < 0) // Tjekker om pris er under 0
            {


                throw new ArgumentException("Det tal du har indtastet er negativt."); // kaster en ny Exception hvis pris er negativt.
            }

            double velbilsafgift = vbilAfgift * 0.20;


            return velbilsafgift; // retunere vbilAfGift når en if eller else er mødt.

        }

    }


    








}
   
            

