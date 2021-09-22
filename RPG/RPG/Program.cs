using System;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output the text stating that we want the players name.
            Console.WriteLine("What is your name ?");
            // Store Players name entered.
             string playersName = Console.ReadLine();

            //Let the player see his/ her name.
            Console.WriteLine("Thank you for entering your name, " + playersName + ".");

            // Create a variable to track if the first enemy is dead.
            bool isFirstEnemyDead = false;

            // Write to the screen about the enemy attack
            Console.WriteLine();
            Console.WriteLine(playersName + " you ha encounterd an enemy ! What would you like to do ? \n \n 1. Single Attack  \n 2. Three strike Attack \n 3. Defend \n 4. Attempt to Run Away ");

            // while the first enemy is not dead, repeat the playable cycle.
            while (!isFirstEnemyDead)
            {
                // Store what action the player choose
                string playerAction = Console.ReadLine();

                //Check what action the player took.
                if (playerAction == "1")
                {
                    // Write ou that we chose 1.
                    Console.WriteLine("You Choos to Single attack !");
                }
                else if (playerAction == "2")
                {
                    // Write ou that we chose 2.
                    Console.WriteLine("You Choos to Three strike Attack !");
                }
                else if (playerAction == "3")
                {
                    // Write ou that we chose 3.
                    Console.WriteLine("You Choos to Defend !");
                }
                else if (playerAction == "4")
                {
                    // Write ou that we chose 4.
                    Console.WriteLine("You Choos to Run Away !");
                }
                else if (playerAction == "10")
                {
                    isFirstEnemyDead = true;

                    Console.WriteLine("The first enemy is dead !");
                }
                else
                {
                    Console.WriteLine("You choose somting else");
                }
               
            }

            
        }
    }
}
