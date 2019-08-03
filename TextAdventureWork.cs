using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Forest!");
            Console.WriteLine("How are you today? (good/ great)");
            string batman = Console.ReadLine();

            if (batman == "good") 
            {
                Console.WriteLine("Byee, Return to street to be killed by a school bus filled with Bats");
               
            }
            else if (batman == "great")
            {
                Console.WriteLine("Well enter into the house");
                Console.WriteLine("Choose the Bathroom, the Bedroom or the Kitchen. Good Luck!");
                string harley = Console.ReadLine();

                if (harley == "Bathroom")
                {
                    Console.WriteLine("Slipped on the tile breaking your neck in three different places, while the rats slowly feast on you flesh");
                }
                else if (harley == "Bedroom")
                {
                    Console.WriteLine("Attacked by wild boars while they eat you alive");
                }
                else
                {
                    Console.WriteLine("Walked into the kitchen and slipped on a beer bottle, watch a dark figure slowly hover over you");
                }
            }
            else
            {
                Console.WriteLine("You will be attacked by Zombies that have been sleeping on Ice");
            }
            

        }
    }
}
