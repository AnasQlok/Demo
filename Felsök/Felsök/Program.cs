using System;

namespace Felsök
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kompileringsfel
            //1-Case sensitive
            //int tal = 10;
            //Console.WriteLine(Tal);

            ////2- Strongly typed

            //string namn = "Tobias";
            //namn = 10;

            //Logiska fel (Felsökning)
            //int tal = 0;

            //while(tal < 10)
            //{
            //    Console.WriteLine(tal);
            //    tal += 4;
            //    if (tal == 7)
            //    {
            //        Console.WriteLine("Talet är 7");
            //    }
            //}
            //Console.ReadLine();

            try
            {
                Console.WriteLine("skriv ett helt tal:");
                int? userInput = int.Parse(Console.ReadLine());
                Console.WriteLine("Du skrev : {0}", userInput);
               
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Fel ....... Null värde ! Du måste skriva en värde");
            }
            catch(FormatException) 
            {
                Console.WriteLine("Fel värde..... FormatException ");
            }
            Console.ReadKey();


        }
    }
}
