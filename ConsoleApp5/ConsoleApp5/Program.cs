using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
             //implicit Convert

            //int i = 100;

            //float f = i;

            //Console.WriteLine(f);


            //Explicit convert
            float f = 12125585878999663.3f;
            int i = Convert.ToInt32(f);
            //int i = (int)f;
            Console.WriteLine(i);

            //Parse & Tryparse

            string stringNum = "123abc";

            int x = int.Parse(stringNum);
            Console.WriteLine(x);

            string stringNum = "12345a";
            int result = 0;

            //bool isConverted = int.TryParse(stringNum, out result);

            //if (isConverted)
            //{
            //    Console.WriteLine(result);
            //}
            //else
            //{
            //    Console.WriteLine("Please Enter a valid number");
            //}

            //string[] students = new string[3];
            //students[0] = "Erik";
            //students[1] = "Elias";
            //students[2] = "Mattias";

            //Console.WriteLine(students[1]);

            //int[] evenNumbers = {2,4,6,8};

            //Console.WriteLine(evenNumbers[2]);

            //int[] evenNum = { 2, 4, 6, 8, 10 };
            //string[] cities = { "London", "New Your" };

            //foreach(var num in evenNum)
            //{
            //    Console.WriteLine(num);
            //}
            //foreach (var city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //var text = "string";
            //text = 1;

            //dynamic text1 = "string";
            //text1 = 1;

            //var v1 = "text";
            //var v2 = 1;
            //var v3 = true;


            dynamic d1 = 1;
            dynamic d2 = true;
            dynamic d3 = DateTime.UtcNow;

            Console.WriteLine("Data type of d3 : {0}", d3.GetType().ToString());


            //var text1 = "string1"; // early bounded
            //int len = text1.Length;

            //dynamic text2 = "string2"; // late bounded
            //int len2 = text2.Length;

            //Console.WriteLine(len2);



        }
    }
}
