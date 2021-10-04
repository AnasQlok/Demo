using System;

namespace Felsök
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kompileringsfel
            //1 - Case sensitive
            //int tal = 10;
            //Console.WriteLine(Tal);

            ////2- Strongly typed

            //string namn = "Tobias";
            //namn = 10;

            // Logiska fel(Felsökning)
            //int tal = 3;

            //while (tal < 10)
            //{
            //    Console.WriteLine(tal);
            //    tal += 4;
            //    if (tal == 7)
            //    {
            //        Console.WriteLine("Talet är 7");
            //    }
            //}
            //Console.ReadLine();

            //Console.WriteLine("skriv ett helt tal:");
            //int userInput = int.Parse(Console.ReadLine());
            //Console.WriteLine("Du skrev : {0}", userInput);
            //Console.ReadKey();






            //try
            //{
            //    Console.WriteLine("skriv ett helt tal:");
            //    int userInput = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Du skrev : {0}", userInput);

            //}


            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            string textIn;
            int i;
            Console.Write("Ange vad du gjorde: ");
            textIn = Console.ReadLine();

            Console.Write("Hur länge gjorde du det: ");
            int v = int.Parse(Console.ReadLine());

            Console.Write("Vill du ange mer tid: ");

            string answer = Console.ReadLine();
            bool cont = false;
            if (answer.ToLower() == "yes")
            {
                cont = true;
            }

            while(cont == true); 
            {
                Console.Write("Ange vad du gjorde: ");
                textIn = Console.ReadLine();
                Console.Write("Hur länge gjorde du det: ");
                i = int.Parse(Console.ReadLine());

                Console.Write("Vill du ange mer tid: ");
                cont = bool.Parse(Console.ReadLine());
            } 


        }
    }
}
