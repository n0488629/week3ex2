using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3ex2
{
    internal class Program
    {
        // One single random generator to be called twice, I had 2 different ones in each Rolldice method but that did not work because they seed at the same time
        public static Random rnd = new Random(); // create a random seed method 
        public static int RollDice1() // first roll dice method
        {      
            
            return (rnd.Next(1, 7)); // return random value
        }
        public static int RollDice2() // second roll dice method
        {
           
            return (rnd.Next(1, 7)); // return a second random value
        }
        static void Main(string[] args)
        {
            bool again = true; // bool for while loop to keep program running
            Random rnd = new Random();
            // Program title
            Console.WriteLine("Roll the Dice program!");
            
            while (again == true) // while loop to keep program running
            {
                // display first dice roll
                
                    Console.WriteLine("First dice rolled: " + RollDice1());
                
                // display second dice roll
                Console.WriteLine("Second dice rolled: " + RollDice2());
                Console.WriteLine("Would you like to roll the dice again? Y or N?");
                string input = Console.ReadLine();
                if (input.ToLower().StartsWith("n")) // if user inputs "n", assign false to again variable to end loop
                {
                    again = false;
                }
            } 
            
        }
    }
}
