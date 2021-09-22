using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1;  
            int num2;
            num1 = 10;
            num2 = 20;
            num1++;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            /* 11111111
             * //Numbers in C# 
            int number = 10;
            int numberMax = int.MaxValue;
            int numberMin = int.MinValue;

           

            //Floating point
            double pris = 20.99;
            double prisMAx = double.MaxValue;
            double prisMin = double.MinValue;


            float height = 4.22f;
            float heightMax = float.MaxValue;
            float heightMin = float.MinValue;

            decimal salary = 10000.50m;

            //Text in C# 
            char letter = '2';
            string name = "Tobias";

            //logical in C#

            bool check = true;*/


            /*222222222222222222222222222222222
             * Read an Write to Console
            Console.WriteLine("Please, Enter Your Name");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello {0}" ,userName);


            Console.WriteLine("Please, Enter Your First Name");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Please, Enter Your Last Name");
            string lastName = Console.ReadLine();

            Console.WriteLine("Hello {0} {1}",FirstName,lastName);


            Console.WriteLine("Please Eneter your age");
            string age =Convert.ToString(Console.ReadLine());

            Console.WriteLine("Hello {0} {1}  And your age is {2}", FirstName,lastName,age);




            /*333333333333333333333333333333333
             Nullable Types
            string name = null; // it can be because is a reference type

            int? i = null ; // By default  value types are not nullable

            bool? AreYouAdmin = null;

            if(AreYouAdmin == true) { Console.WriteLine("User is Admin") }
            else if(AreYouAdmin == false) { Console.WriteLine("User is Not Admin") }
            else { Console.WriteLine("User Did not answer the question") }

             /// Null Coalescing Operator 
             int? TicketsOnSale = null;
             int AvailableTickets ;
            
            if(TicketsOnSale == null ) {AvailableTickets = 0}
            else { AvailableTickts = (int)TicketsOnSale;}

            Console.WriteLine("Available Tickets ={0}", AvailableTickets);

            /// Null Coalescing Operator here come

             int? TicketsOnSale = null;
             int AvailableTickets = TicketOnSale ?? 0 ; 
            Console.WriteLine("Available Tickets ={0}", AvailableTickets);
             
            




            Console.WriteLine(number);
            Console.WriteLine(numberMax);
            Console.WriteLine(numberMin);
            Console.WriteLine("------------------------");
            Console.WriteLine(pris);
            Console.WriteLine(prisMAx);
            Console.WriteLine(prisMin);
            Console.WriteLine("--------------------------");
            Console.WriteLine(height);
            Console.WriteLine(heightMax);
            Console.WriteLine(heightMin);
            Console.WriteLine("---------------------------");
            Console.WriteLine(letter);
            Console.WriteLine(salary);
            Console.WriteLine(name);
            Console.WriteLine(check);

            */

        }
    }
}
