using System;

namespace Meth
{
    
    class Program
    {
        //[Obsolete("Don't use OldMethod, use NewMethod instead", true)]

        //static void OldMethod()
        //{
        //    Console.WriteLine("It is the old method");
        //}
        //static void NewMethod()
        //{
        //    Console.WriteLine("It is the new method");
        //}
        static void Main(string[] args)
        {






            //OldMethod();
            //1
            Program.JämnaSiffror();

            Program EvNu = new Program();
            EvNu.EvenNum(10);

            Program OddSif = new Program();
            OddSif.OddNum(0);


            Program sum = new Program();
            int s = sum.Sum(10, 90);
            Console.WriteLine("Sum = {0}", s);


            Program FN = new Program();
            string fullname = FN.FullName("Anas", "Alhussain");
            Console.WriteLine("Your Full Name is : {0}", fullname);


            //Out int Parameter
            int Totale = 0;
            int Product = 0;
            Calculate(10, 20, out Totale, out Product);

            Console.WriteLine("Sum = {0} & Product = {1}", Totale, Product);

            ///Array PArams method
            int[] Numbers = new int[3];

            Numbers[0] = 100;
            Numbers[1] = 200;
            Numbers[2] = 300;

            
            //ParamMethod();
            ParamMethod(Numbers);
            ParamMethod(1,2,3,4,5,6,7,8,9,10);
        }

        //[attribute]
        // 1-access-modifiers 2-return-type 3-method-name(parameters)
        //{
        //Method Body
        //{
        //

       static void Multiply(int num1, int num2)
        {
            int result = num1 * num2;
            Console.WriteLine("The result is : " + result);
        }



        static int Multi(int num1, int num2)
        {
            int result = num1 * num2;
            return result;
        }


        public void MeetAnewPerson()
        {
            Random numGen = new Random();

            string name = "X-" + numGen.Next(150,999);
            int age = numGen.Next(10 , 500);

            Console.WriteLine("Hi ,I'm " + name);
            Console.WriteLine("I'm" + age + "Years old.");
            Console.WriteLine("Oh, an I'm a new person");

        }

        //1 
        public void PrintNumber()
        {
            Random numGen = new Random();
            int number = numGen.Next(0,10);
            Console.WriteLine(number);
        }


        public static void JämnaSiffror()
        {
            int start = 0;

            while (start <= 20)
            {
                Console.WriteLine(start);
                start = start + 2;
            }
        }

        //2
        public void EvenNum(int target)
        {
            Console.WriteLine("Print Even Numbers from 0 to {0} ", target);
            
            for (int i = 0; i <= target; i++)
            {
                if (i % 2==0)
                {
                    Console.WriteLine(i + "");
                }
            }
        }

        //3
        public void OddNum(int target)
        {
            Console.WriteLine("Print Odd Numbers from 10 to {0} \n", target);
            for (int i = 10; i >=  target ; i--)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i + " ");
                }
            }
        }

        //4
        public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        //5
        public string FullName(string firstName, string lastName)
        {
            string fullName = firstName + " " + lastName;
            return fullName;
        }


        //Out 
        public static void Calculate(int firstNum, int secondNum, out int Sum, out int Product)
        {
            Sum = firstNum + secondNum;
            Product = firstNum * secondNum;
        }


        // Array 

        public static void ParamMethod(params int[] Numbers)
        {
            Console.WriteLine("There are {0} elements ", Numbers.Length);

            foreach (int  i in Numbers)
            {
                Console.WriteLine(i);
            }
        }

        //reference type

        public static void SimpleMethod(int x)
        {
            x = 111;
        }
    }
}
