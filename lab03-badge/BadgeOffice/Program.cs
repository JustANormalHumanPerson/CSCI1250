/*
* Name: Jocie Marino
* Course: CSCI 1250, Section 001
* Assignment: Lab 03, The Badge Office
* Date: October 1, 2026
* Description: Builds a student badge from a name, two random assignments,
* and the walking distance to a first class.
*/


//part 1

Console.WriteLine("Welcome to the Badge Creator, please respond to the prompts.");
Console.WriteLine(" ");
Console.Write("Full name: ");
string fullName = Console.ReadLine().Trim();
string lastName = fullName.Substring(fullName.IndexOf(" ")+1);
string firstName = fullName.Substring(0, fullName.IndexOf(" ")-1);
string username = (firstName.Substring(0,1) + lastName).ToLower();
System.Console.WriteLine($"Name on badge: {fullName.ToUpper()}");
System.Console.WriteLine($"Username: {username}");
System.Console.WriteLine($"Initials: {firstName.Substring(0,1).ToUpper()}.{lastName.Substring(0,1).ToUpper()}.");
System.Console.WriteLine($"Letters in last name: {lastName.Length}");


// part 2
Random rng = new Random();
int studentID = rng.Next(100000,1000000);
int studentLocker = rng.Next(1,501);
Console.WriteLine(" ");
System.Console.WriteLine($"Student ID: {studentID}");
System.Console.WriteLine($"Student Locker: {studentLocker}");