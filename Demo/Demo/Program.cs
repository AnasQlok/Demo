using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Program FN = new Program();
            string fullname = FN.FullName("Anas", "Alhussain");
            Console.WriteLine("Your Full Name is : {0}", fullname);
            

            //Program P = new Program();
            //P.DoSomthing();

            ////Program.DoSomthing();
            //Program.PrintNum();
            //Console.WriteLine("-----------------");
            //PrintNum();
            //PrintNum();
            //PrintNum();
            //PrintNum();
            //PrintNum();

            //Program P = new Program();
            //P.EvenNum(20);

            Program P = new Program();
            //P.OddNum(0);

            int result =P.Sum(10,20);
            Console.WriteLine("Result is : {0}",result);

            
        }

        public static void DoSomthing()
        {
            Console.WriteLine("Hello FRom Do some thing method");
        }

        public static void PrintNum()
        {
            Random NumGen = new Random();
            int number = NumGen.Next(10,20);
            Console.WriteLine(number);
        }

        public void EvenNum(int target)
        {
            int start = 0;

            while (start <= target)
            {
                Console.WriteLine(start);
                start = start + 2;
            }
        }

        public void OddNum(int target)
        {
            Console.WriteLine("Print Odd Numbers from 10 to {0} \n", target);
            for (int i = 10; i >= target; i--)
            {
                if (i % 2 != 0)
                {
                    
                    Console.WriteLine(i + " ");
                }
            }
        }


        public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }


        public string FullName(string firstName, string lastName)
        {
            string fullName = firstName + " " + lastName;
            return fullName;
        }

        Console.WriteLine("pleas write a number");
        int culty = Int32.Parse(Console.ReadLine());


    }
}
