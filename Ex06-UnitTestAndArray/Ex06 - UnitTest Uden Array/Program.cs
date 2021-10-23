using System;

namespace Ex06___UnitTest_Uden_Array
{
    class arrayProgram
    {
       public static void Main(string[] args)
        {
            /*int AgeStefan = 26;
            Console.WriteLine("Stefan, {0}år", AgeStefan);
            int AgeJonathan = 23+1;
            Console.WriteLine("Jonathan, {0}år", AgeJonathan);
            int AgeKaroline = 74;
            Console.WriteLine("Karoline, {0}år", AgeKaroline);
            int AgeCecil = 64;
            Console.WriteLine("Cecil, {0}år", AgeCecil);
            int AgeCamilla = 13;
            Console.WriteLine("Camilla, {0}år", AgeCamilla);
            int GennemsnitsAlder = (AgeStefan + AgeJonathan + AgeKaroline + AgeCecil + AgeCamilla) / 5;

            Console.WriteLine(GennemsnitsAlder);
            Console.ReadKey();
            */

            //Øvelse 3.3: Findes der en med alderen
            /*
            int[] alder = new int[] { 26, 24, 74, 64, 13}; //Array af aldere
            double GnAlder = 0;
            Console.WriteLine("indtast tallet du leder efter");
            int UserInput = Convert.ToInt32(Console.ReadLine());
            
            /* alder[0] = 26;
             alder[1] = 24;
             alder[2] = 74; */
            /*
            for (int i = 0; i < 5; i++) //kører FOR loopet indtil den har været igennem alle arrays.
            {
                if (UserInput == alder[i])
                {
                    Console.WriteLine("Findes i Arrayet.");
                    break;
                }
                
                Console.WriteLine(alder[i]);
                GnAlder = GnAlder + alder[i]; 
            }
            Console.WriteLine("SUM {0}",GnAlder/5);
            Console.ReadKey();
            */

            
            Console.WriteLine("Indtast antal personer i gruppen: ");
            int brugerInput = Convert.ToInt32(Console.ReadLine());
            int[] gruppeAldre = new int[brugerInput];
            int i = 0;
            while (i < brugerInput)
            {
                
                Console.WriteLine("indtast alder: ");
                gruppeAldre[i] = Convert.ToInt32(Console.ReadLine());
                i++;
            }
            for (int j = 0; j < gruppeAldre.Length; j++)
            {
                Console.WriteLine("{0}", gruppeAldre[j]);
            }
            Console.ReadKey();



            /*  for (int i = 0; i < brugerInput; i++)
              {
                  Console.WriteLine("indtast alder: ");
                  gruppe[i] = Convert.ToInt32(Console.ReadLine());

                  while(i >= brugerInput)
                  {
                     Console.WriteLine("{0}, {1}", gruppe[i], brugerInput);
                  }
              } */

            //Kalder på Minus Metoden.

            //   Console.WriteLine("{0}, {1}", gruppe[i], brugerInput);
            //   Console.ReadKey();

        }
    }
}
