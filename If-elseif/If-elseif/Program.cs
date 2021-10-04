using System;

namespace If_elseif
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej ! Vad heter du ? ");
            string naem = Console.ReadLine();

            Console.WriteLine("Hej {0} , Hur gammal är du ? ",naem);


            //int age = int.Parse(Console.ReadLine());

            //if (age < 18)
            //{
            //    Console.WriteLine("Sorry {0} ! Du kan inte ha körkort !", naem);
            //}
            //else if (age > 18)
            //{
            //    Console.WriteLine("Woho ! Dags att skaffa körkort {0}", naem);
            //}
            //else if (age == 18)
            //{
            //    Console.WriteLine("Woho ! Dags att skaffa körkort {0}", naem);
            //}
            //else
            //{
            //    Console.WriteLine("Kör försiktigt");
            //}
            //Console.ReadKey();


            Console.WriteLine("Du har flera alternativ \n 1- 18 år  \n 2- Minder än 18 år \n 3- Över 18 år");
            int auserInput = int.Parse(Console.ReadLine());

            switch (auserInput)
            {
                case 1:
                    Console.WriteLine("Woho ! Dags att skaffa körkort {0}", naem);

                    break;
                case 2:
                    Console.WriteLine("Sorry {0} ! Du kan inte ha körkort ! Du måste var 18 år !", naem);
                    break;
                case 3:
                    Console.WriteLine("Kör försiktigt");
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}
