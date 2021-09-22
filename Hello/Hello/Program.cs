using System;

namespace Hello
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Varsåg och skriv in ett heltal");
            string chesspeice = Console.ReadLine();



            string chessblack = " \u2588";
            string chesswhite = " \u2591";



            int Rows = 8;
            int Col = 8;

            for (int row = 0; row < Rows; Rows++)
            {
                for (int co = 0; co < Col ; Col++)
                {
                    if (co % 2!= 0)
                    {
                        Console.Write(chesswhite);

                    }
                if (row % 2 == 0)
                {
                    Console.Write(chessblack);
                }
                    //else
                    //{
                    //    Console.Write(chessblack);
                    //}
                }




            }
        }
    }
}