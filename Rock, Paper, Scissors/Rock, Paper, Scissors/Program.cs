using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock__Paper__Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            int Tally1 = 0;
            int Tally2 = 0;
            int win1 = 0;
            int win2 = 0;
            int count = 0;
            int count4 = 0;
            //List of Win/Lose rounds
            var Results = new List<string>();
            string[] ThreeOptions = {"Rock","Paper","Scissors"};
            Console.WriteLine("Rock,Paper,Scissors!");
            Console.WriteLine("Your turn first!");
            while (count4 != 3)
            {
                        String Readline = Console.ReadLine();
                        //If User types Rock
                        if (Readline == "Rock")
                        {
                            Random random = new Random();
                            int RandomNumber = random.Next(0, 3);
                            Console.WriteLine("The Console says " + ThreeOptions[RandomNumber] + "!");
                            if (ThreeOptions[RandomNumber] == "Rock")
                            {
                                Console.WriteLine("Its a Tie!");
                            }
                            if (ThreeOptions[RandomNumber] == "Paper")
                            {
                                Console.WriteLine("Console Won the turn!");
                                Tally2++;
                            }
                            if (ThreeOptions[RandomNumber] == "Scissors")
                            {
                                Console.WriteLine("You won the turn!");
                                Tally1++;
                            }
                        }
                        //If User Types Paper
                        if (Readline == "Paper")
                        {
                            Random random = new Random();
                            int RandomNumber = random.Next(0, 3);
                            Console.WriteLine("The Console says " + ThreeOptions[RandomNumber] + "!");
                            if (ThreeOptions[RandomNumber] == "Paper")
                            {
                                Console.WriteLine("Its a Tie!");
                            }
                            if (ThreeOptions[RandomNumber] == "Scissors")
                            {
                                Console.WriteLine("Console Won the turn!");
                                Tally2++;
                            }
                            if (ThreeOptions[RandomNumber] == "Rock")
                            {
                                Console.WriteLine("You won the turn!");
                                Tally1++;
                            }
                        }
                        //If User Types Scissors
                        if (Readline == "Scissors")
                        {
                            Random random = new Random();
                            int RandomNumber = random.Next(0, 3);
                            Console.WriteLine("The Console says " + ThreeOptions[RandomNumber] + "!");
                            if (ThreeOptions[RandomNumber] == "Scissors")
                            {
                                Console.WriteLine("Its a Tie!");
                            }
                            if (ThreeOptions[RandomNumber] == "Rock")
                            {
                                Console.WriteLine("Console Won the turn!");
                                Tally2++;
                            }
                            if (ThreeOptions[RandomNumber] == "Paper")
                            {
                                Console.WriteLine("You won the turn!");
                                Tally1++;
                            }
                        }
                        // If Console Won three turns in one round
                        if (Tally2 == 3)
                        {
                            Tally2 = 0;
                            Tally1 = 0;
                            win2++;
                            count++;
                            count4++;
                            Results.Add("You Lost the Round!");
                            Console.WriteLine("Console won the round!");
                        }
                        //If player won 3 turns in one round
                        if (Tally1 == 3)
                        {
                            Tally1 = 0;
                            Tally2 = 0;
                            win1++;
                            count++;
                            count4++;
                            Results.Add("You Won the Round!");
                            Console.WriteLine("You won the round!");
                        }
                        //If player wins the game
                        if (win1 == 2)
                        {
                            count4 = 3;
                            Console.WriteLine("YOU WON THE GAME!!!!");
                        }
                        //If Console wins the game
                        if (win2 == 2)
                        {
                            count4 = 3;
                            Console.WriteLine("YOU LOST THE GAME!!!!");
                        }
                    }
             
            int count2 = 0;
            int count3 = 1;
            //Win/Lose/Tie of all the round generator
            while (count2 <= count - 1)
            {
                Console.WriteLine("Round " + count3 + " Results: " + Results[count2]);
                count2++;
                count3++;
            }
            Console.ReadKey(true);
        }
    }
}
