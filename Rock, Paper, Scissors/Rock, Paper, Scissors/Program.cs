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
            string[] ThreeOptions = {"Rock","Paper","Scissors"};
            Console.WriteLine("Rock,Paper,Scissors!");
            Console.WriteLine("Your turn first!");
            while(win1 != 2 && win2 != 2)
            {
                String Readline = Console.ReadLine();
                if (Readline == "Rock")
                {
                    Random random = new Random();
                    int RandomNumber = random.Next(0, 3);
                    Console.WriteLine("The Console says " + ThreeOptions[RandomNumber] + "!");
                    if(ThreeOptions[RandomNumber] == "Rock")
                    {
                        Console.WriteLine("Its a Tie!");
                    }
                    if(ThreeOptions[RandomNumber] == "Paper")
                    {
                        Console.WriteLine("Console Won the turn!");
                        Tally2++;
                    }
                    if(ThreeOptions[RandomNumber] == "Scissors")
                    {
                        Console.WriteLine("You won the turn!");
                        Tally1++;
                    }
                    
                }
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
                if(Tally2 == 3)
                {
                    Tally2 = 0;
                    Tally1 = 0;
                    win2++;
                    Console.WriteLine("Console won the round!");
                        }
                if(Tally1 == 3)
                {
                    Tally1 = 0;
                    Tally2 = 0;
                    win1++;
                    Console.WriteLine("You won the round!");
                }
                if(win1 == 2)
                {
                    Console.WriteLine("YOU WON THE GAME!!!!");
                }
                if(win2 == 2)
                {
                    Console.WriteLine("YOU LOST THE GAME!!!!");
                }
                Console.ReadKey(true); 
            }
        }
    }
}
