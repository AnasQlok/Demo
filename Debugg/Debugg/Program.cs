using System;

namespace Debugg
{
    class Program
    {
        static void Main(string[] args)
        {
            string textIn ;
            int i;
            Console.Write("Ange vad du gjorde: ");
            textIn = Console.ReadLine();

            Console.Write("Hur länge gjorde du det: ");
            int v = int.Parse(Console.ReadLine());
            
            Console.Write("Vill du ange mer tid (Ja / Nej): ");

            string answer = Console.ReadLine();
            bool cont = false;

            if (answer.ToLower() == "yes")
            {
                cont = true;
            }
            do
            {
                Console.Write("Ange vad du gjorde: ");
                textIn = Console.ReadLine();
                Console.Write("Hur länge gjorde du det: ");
                i = int.Parse(Console.ReadLine());
                
                Console.Write("Vill du ange mer tid: ");
                cont = bool.Parse(Console.ReadLine());
            } while (cont == true);
        }
    }
}
