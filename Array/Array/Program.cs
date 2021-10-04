using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] evenNums1 = new int[5] { 2, 4, 6, 8, 10 };

            //int[] Num = new int[3];
            //Num[0] = 2;
            //Num[1] = 4;
            //Num[2] = 6;

            //Console.WriteLine(Num[2]);

            //string[] cities = new string[3] { "Mumbai", "London", "New York" };


            //foreach (var item in evenNums1)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in cities)
            //{
            //    Console.WriteLine(item);
            //}

            //int[] evenNums2 = new int[5];
            //evenNums2[0] = 2;
            //evenNums2[1] = 4;
            ////evenNums[6] = 12;  //Throws run-time exception IndexOutOfRange

            //Console.WriteLine(evenNums2[0]);  //prints 2
            //Console.WriteLine(evenNums2[1]);  //prints 4



            //int[] evenNums3 = { 2, 4, 6, 8, 10 };

            //for (int i = 0; i < evenNums3.Length; i++)
            //    Console.WriteLine(evenNums3[i]);

            //for (int i = 0; i < evenNums3.Length; i++)
            //    evenNums3[i] = evenNums3[i] + 10;

            //two - dimensional Array

            int[,] arr2d = new int[3, 2]{
                                {1, 2},
                                {3, 4},
                                {5, 6}
                            };

            // eller  
            int[,] arr2d1 = {
                    {1, 2},
                    {3, 4},
                    {5, 6}
                };


            //Console.WriteLine(arr2d[0, 0]);
            //Console.WriteLine(arr2d[0, 1]);
            //Console.WriteLine(arr2d[1, 0]);
            //Console.WriteLine(arr2d[1, 1]);
            //Console.WriteLine(arr2d[2, 0]);
            //Console.WriteLine(arr2d[2, 1]);


            //Example: Jagged Array

            int[][] jArray = new int[4][]{

                new int[3]{1, 2, 3},

                new int[4]{4, 5, 6, 7},
                new int[5]{4, 5, 6, 7,9},
                new int[3]{4, 5, 6}
        };

            Console.WriteLine(jArray[0][0]);
            Console.WriteLine(jArray[0][1]);
            Console.WriteLine(jArray[0][2]);
            Console.WriteLine(jArray[1][0]);
            Console.WriteLine(jArray[1][1]);
            Console.WriteLine(jArray[1][2]);
            Console.WriteLine(jArray[1][3]);








        }
    }
}
