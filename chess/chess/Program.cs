using System;

namespace chess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a number");
            int dim = Convert.ToInt32(Console.ReadLine());
            int rowSize = dim;
            int colSize = dim;
            char Black = '\u2588';
            char White = '\u2591';

            //Calculation
            for (int row = 0; row < rowSize; row++) //Loopa ROW
            {
               
                for (int col = 0; col < colSize; col++) //Loopa COL
                {
                    
                    if ((row + col) % 2 == 0) //Check Jämna siffror
                    {
                        Console.Write(Black); //
                    }
                    else
                    {
                        Console.Write(White); //
                    }
                    
                }
                Console.WriteLine(); //Switch to a new line
            }
        }
    }
}