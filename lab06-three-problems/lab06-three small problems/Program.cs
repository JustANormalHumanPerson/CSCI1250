/*
 * Name: Jocie Marino
 * Course: CSCI 1250, Section 002
 * Assignment: Lab 06, Three Short Problems
 * Date: October 23, 2026
 * Description: A menu that keeps running until the user quits, offering three
 * independent exercises or all three at once. Each exercise
 * practices decisions and one of the four loops.
 */

using System.Runtime.CompilerServices;



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




