/*
 * Name: Jocie Marino
 * Course: CSCI 1250, Section 002
 * Assignment: Lab 06, Three Short Problems
 * Date: October 23, 2026
 * Description: A menu that keeps running until the user quits, offering three
 * independent exercises or all three at once. Each exercise
 * practices decisions and one of the four loops.
 */

using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;



//menu
Console.WriteLine("=== CSCI 1250 Lab 06 ===");
    Console.WriteLine("1. The Grade Checker");
    Console.WriteLine("2. The Dice Table");
    Console.WriteLine("3. The Score Report");
    Console.WriteLine("4. All three");
    Console.WriteLine("5. Quit");
    Console.Write("Select a choice number 1-5: ");
    int choice = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(" ");

    //1. score check
    if ((choice == 1) || (choice == 4))
    {
        Console.WriteLine("=== Exercise 1: The Grade Checker ===");
        Console.WriteLine("Please enter a score: ");
        int score = Convert.ToInt32(Console.ReadLine());
         if(score < 60)
        {
        Console.WriteLine($"{score} earns an F.");
        Console.WriteLine(" ");
        }
        else if(score >= 60 && score < 70)
        {
        Console.WriteLine($"{score} earns an D.");
        Console.WriteLine(" ");
        }
        else if(score >= 70 && score < 80)
        {
        Console.WriteLine($"{score} earns a C.");
        Console.WriteLine(" ");
        }
        else if(score >= 80 && score < 90)
        {
        Console.WriteLine($"{score} earns a B.");
        Console.WriteLine(" ");
        }
        else if(score >= 90)
        {
        Console.WriteLine($"{score} earns an A.");
        Console.WriteLine(" ");
        }
    }

//2. dice game
   if (choice == 2 || choice == 4)
    {
        Console.WriteLine("=== Exercise 2: The Dice Table ===");
        int rollNumber = 1;
        int wins = 0;
        bool diceGameActive = true;
        Console.WriteLine(" ");
        Console.WriteLine("Roll dice? (y/n)");
        char roll = Console.ReadLine().ToUpper()[0];
        
          do
            {
            //roll 2 six-sided die.
            int die1 = RandomNumberGenerator.GetInt32(1, 7);
            int die2 = RandomNumberGenerator.GetInt32(1, 7);

            Console.WriteLine($"Roll {rollNumber}: {die1} and {die2}, total {die1+die2}. ");

            if(die1 == 1 && die2 == 1)
            {
            Console.WriteLine("Snake Eyes.");
            }
            else if(die1 == die2)
            {
                Console.WriteLine("Doubles!");
            }
            else if(die1+die2 == 7 || die1+die2 == 11)
            {
                Console.WriteLine("A winner.");
                ++wins;
            }
            else
            {
                Console.WriteLine(" ");
            }
            Console.WriteLine("Roll again?");
            char rollAgain = Console.ReadLine().ToUpper()[0];
            if (rollAgain == 'Y')
            {
                ++rollNumber;
            }else
        
            
            if(rollNumber == 1)
        {
            if(wins == 0)
            {
                    Console.WriteLine($"You rolled once and lost.");
            }
            else
            {
                    Console.WriteLine($"You rolled once and won.");
            }
        
        }
        else
        {
            if(wins == 0)
            {
                    Console.WriteLine($"You rolled {rollNumber} times and lost every game.");
        }
        else if(wins == 1)
        {
                    Console.WriteLine($"You rolled {rollNumber} times and won once.");
        }
        else if(wins > 1)
        {
                    Console.WriteLine($"You rolled {rollNumber} times and won {wins} times.");
        }
        Console.WriteLine(" ");
        diceGameActive = false;
        }

        }while (diceGameActive);
        
    }
