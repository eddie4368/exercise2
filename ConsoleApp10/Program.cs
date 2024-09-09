using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();//The random variable is used to reference this instance, allowing you to call methods on it to generate random values.
            int[] diceRoll;//The line int[] diceRoll; declares an array of integers named "diceRoll".


            while (true)//The while statement checks the condition true. Since true is always true.
            {
                Console.WriteLine("Press 'enter' to roll the dice, or 'q' to quit");//It displays a message asking the user to press "enter" to roll the dice or "q" to quit.
                if (Console.ReadLine().ToLower() == "q")//to read the user's input as a string and using ToLower() to make the comparison case-insensitive.
                {
                    break;//statement is used to exit the switch statement after the conversion is performed.
                }

                diceRoll = RollDice(random);//RollDice method presumably returns an array of integers, which represents the results of rolling the dice. This returned value is then assigned to the diceRoll array.
                Console.WriteLine("You rolled: " + diceRoll[0] + " and " + diceRoll[1]);//It combines the string "You rolled: " with the values of diceRoll[0] and diceRoll[1]. The + operator is used for string concatenation
                Console.WriteLine();
            }
        }
    static int[] RollDice(Random random)//defines a static method named RollDice that takes a Random object as an argument and returns an array of integers.
        {
        int[] dice = new int[2];//creates a new array of integers named dice.
            dice[0] = random.Next(1, 6);//imulates rolling a single die and stores the random result (between 1 and 6) in the first element of the dice array
            dice[1] = random.Next(1, 6);//imulates rolling a single die and stores the random result (between 1 and 6) in the second element of the dice array
            return dice;//code is used to return the dice array from the RollDice method.
        }
    }
}