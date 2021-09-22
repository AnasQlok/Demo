using System;
using System.Linq;

namespace konv
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ////Array
            //int[] myNumbers = new int[3];

            //myNumbers[0] = 1;
            //myNumbers[1] = 2;
            //myNumbers[2] = 3;
           
            //Console.WriteLine(myNumbers[2]);

            // Exampel
            string[] students = { "Erik", "Elin", "Mattias", "Elias" };

            Console.WriteLine(students[2]);

            //exampel
            string[] namn = new string[4];
            namn[0] = "Alf";
            namn[1] = "Jonas";
            namn[2] = "Jesper";
            namn[3] = "Kalle";
            
            

            for (int i = 0; i < namn.Length; i++)
            {
                Console.WriteLine(namn[i]);

            }

            //exampel
            int[] evenNumbers = { 2, 4, 6, 8, 10 };
            string[] cities = { "Mumbai", "London", "New York" };

            foreach (var num in evenNumbers)
                Console.WriteLine(num);

            foreach (var city in cities)
                Console.WriteLine(city);


            //////----------------------------------------------------------
            
            
            ////Dynamic types 
            
            //var num1 = 1;
            //num1 = "tex";

            dynamic number = 1;
            number = "text";

            // explane

            var text1 = "string1"; // early bounded // 


            int len = text1.Length;

            dynamic text2 = "string2"; // late bounded // at runtime 
            int len2 = text2.Length;

            //Console.WriteLine(len2);


            dynamic d11 = 7;

            dynamic d2 = "a string";
            dynamic d3 = System.DateTime.Today;
            dynamic d4 = System.Diagnostics.Process.GetProcesses();

            var v1 = 7;
            var v2 = "text";
            var v3 = System.DateTime.UtcNow;
            // Dynamic variables
            dynamic val1 = "Text";
            dynamic val2 = 3234;
            dynamic val3 = 32.55;
            dynamic val4 = true;

            // Get the actual type of
            // dynamic variables
            // Using GetType() method
            Console.WriteLine("Get the actual type of val1: {0}",
                                      val1.GetType().ToString());

            Console.WriteLine("Get the actual type of val2: {0}",
                                      val2.GetType().ToString());

            Console.WriteLine("Get the actual type of val3: {0}",
                                      val3.GetType().ToString());

            Console.WriteLine("Get the actual type of val4: {0}",
                                      val4.GetType().ToString());
            ///anonymos type
            var v = new { amount = 100, text = "Hello" };
            Console.WriteLine(v);

            

            //dynamic dy1 = 1;
            //dy1 = "text";
            //Console.WriteLine(dy1);

        }






    }
}
