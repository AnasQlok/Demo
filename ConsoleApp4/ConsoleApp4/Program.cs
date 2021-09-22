using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - implicit convert
 
             int i = 100;


             float f = i;

             Console.WriteLine(f);

            // 2 Explicit Convertion
            //A- casting  can not get an exeption

            float speed = 123.45f;
            int casting = (int)speed;
            Console.WriteLine(casting);

            //the diffrence between cast and convert class is 
            //B- Convert class kan get an exception
             float hieght = 1231.20f;

             int x = Convert.ToInt32(hieght);


             Console.WriteLine(x);

             //System.OverflowException:



            //tow way to convert a string to an int

            //Parse and tryParse
             string stringNumber1 = "123";


             int y = int.Parse(stringNumber1);


             Console.WriteLine(y);

            //tryParse sen back a bool 
             string stringNumber = "123abc";

             int result = 0;

             bool isConverted = int.TryParse(stringNumber, out result);

            if (isConverted)
             {

                 Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Please Enter a valid number");
            }


            Console.WriteLine("What is your name ? ");

            string name = Console.ReadLine();

            Console.WriteLine("Hello {0} ", name);

            Console.WriteLine("How old are you ?");
            int age = 0;

            string myAge = age.ToString(Console.ReadLine());

            Console.WriteLine("Hello {0} You are {1} Years old! ", name, myAge);
        }
    }
}
