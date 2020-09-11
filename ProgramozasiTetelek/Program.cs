using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramozasiTetelek
{
    class Program
    {
        static int[] tomb = new int[] {12,7,2,4,45,99,1,8,95,50};

        static void TombKiiras()
        {

            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write("{0},",tomb[i]);
                
            }
            

        }


        static void osszegzes()
        {
            Console.WriteLine();
            int osszeg = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                osszeg += tomb[i];

            }
            Console.WriteLine(osszeg);


        }


        static void megszamlalas()
        {
            Console.WriteLine();
            int darab = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] %3 ==0)
                {
                    darab++;
                }
            }
            Console.WriteLine("3-al osztható számok darabszáma: {0}",darab);

        }



        static void eldontes()
        {
            int i = 0;
            bool van = true;
            while (i < tomb.Length && van)
            {
                if (tomb[i] == 69)
                {
                    van = false;
                    Console.WriteLine("van ilyen");
                }
                i++;
            }
            if (van)
            {
                Console.WriteLine("\n nincs ilyen");
            }
            


        }


        static void kivalasztas()
        {
            Console.WriteLine("\n");
            int i = 0;
            while (tomb[i] != 50)
            {
                i++;
            }
            Console.WriteLine("A kiválasztott szám a {0}. helyen van.", i+1);





        }

        static void kereses()
        {
            Console.WriteLine("\n");
            int i = 0;
            while (i< tomb.Length && tomb[i] !=50)
            {
                i++;

            }
            if (i< tomb.Length)
            {
                Console.WriteLine("van és a {0}. helyen van",i+1);
            }
            else
            {
                Console.WriteLine("A keresett szám nincs a tömbben!");
            }
              
        }
        

        static void maximumkereses()
        {
            int max = tomb[0];
            
            for (int i = 0; i < tomb.Length; i++)
            {
                if (max<tomb[i])
                {
                    max = tomb[i];
                    
                }

            }
            Console.WriteLine("a legnagyobb érték {0}",max);



        }
        static void Main(string[] args)
        {
            TombKiiras();
            osszegzes();
            megszamlalas();
            eldontes();
            kivalasztas();
            kereses();
            maximumkereses();
            Console.ReadKey();

        }
    }
}
