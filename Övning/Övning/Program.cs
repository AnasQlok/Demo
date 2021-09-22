using System;

namespace Övning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej! Vem prater jag med");
            // stor user name in a variable from type string
            string userName = Console.ReadLine();
            // print to the username with message 
            Console.WriteLine("Trevlig {0}",userName + "! Mår du bra idag? ");
            //take the answer 
            string answer = Console.ReadLine();
            // write the condetion 
            if (answer == "Ja")
            {
                Console.WriteLine("Skönt att höra!");
            }
            else if (answer == "Nej")
            {
                Console.WriteLine("Ojdå, tråkit.");
            }

            Console.WriteLine("Vad kan Jag hjälpa dig med då? ");


        }
    }
}
