using System;

namespace Debugg
{
    class Program
    {
        static void Main(string[] args)
        {
            string textIn ;
            int i;
            Console.Write("Enter what you did: ");
            textIn = Console.ReadLine();

            Console.Write("How long did you do it for: ");
            int v = int.Parse(Console.ReadLine());
            
            Console.Write("Do you want to enter more time:");
            bool cont = bool.Parse(Console.ReadLine());
            do
            {
                Console.Write("Enter what you did: ");
                textIn = Console.ReadLine();
                Console.Write("How long did you do it for: ");
                i = int.Parse(Console.ReadLine());
                
                Console.Write("Do you want to enter more time:");
                cont = bool.Parse(Console.ReadLine());
            } while (cont == true);
        }
    }
}
