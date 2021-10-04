using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
			string[] userNames = { "User1", "User2", "User3", "User4" };

            foreach (var item in userNames)
            {
                Console.WriteLine( item );
            }

			int[,] codes = new int[,]
						{
							{200, 400},
							{2000, 4000},
							{20000, 40000}
						};

			// Get all bounds before looping.
			int bound0 = codes.GetUpperBound(0);
			int bound1 = codes.GetUpperBound(1);
			// ... Loop over bounds.
			for (int i = 0; i <= bound0; i++)
			{
				for (int x = 0; x <= bound1; x++)
				{
					// Display the element at these indexes.
					Console.WriteLine(codes[i, x]);
				}
				Console.WriteLine();
			}
		}
        
        
    }
}
