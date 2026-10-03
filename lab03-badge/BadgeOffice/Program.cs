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
Console.WriteLine($"Name on badge: {fullName.ToUpper()}");
Console.WriteLine($"Username: {username}");
Console.WriteLine($"Initials: {firstName.Substring(0,1).ToUpper()}.{lastName.Substring(0,1).ToUpper()}.");
Console.WriteLine($"Letters in last name: {lastName.Length}");


// part 2
Random rng = new Random();
int studentID = rng.Next(100000,1000000);
int studentLocker = rng.Next(1,501);
Console.WriteLine(" ");
Console.WriteLine($"Student ID: {studentID}");
Console.WriteLine($"Student Locker: {studentLocker}");

// part 3
Console.WriteLine("Please respond to the following prompts:");
Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine("What are your Dorm Coordinates?");
Console.Write("Dorm X: ");
string? dormInputX = Console.ReadLine(); int dormX = Convert.ToInt32(dormInputX);
Console.Write("Dorm Y: ");
string? dormInputY = Console.ReadLine(); int dormY = Convert.ToInt32(dormInputY);
Console.WriteLine(" ");
Console.WriteLine("What are your Class Coordinates?");
Console.Write("Class X: ");
string? classInputX = Console.ReadLine(); int classX = Convert.ToInt32(classInputX);
Console.Write("Class Y: ");
string? classInputY = Console.ReadLine(); int classY = Convert.ToInt32(classInputY);
Console.WriteLine(" ");
Console.WriteLine("How fast do you walk?");
Console.Write("Walking speed (ft/s): ");
string? walkInput = Console.ReadLine();
double walkSpeed = Convert.ToDouble(walkInput);
double distance = Math.Sqrt(Math.Pow(classX - dormX, 2)+ Math.Pow(classY - dormY, 2));
Console.WriteLine(" ");
Console.WriteLine($"Distance: {Math.Round(distance, 2)} feet");
int walkTimeMin = (int)distance/(int)walkSpeed/60;
double walkTimeSec = Math.Round(distance/walkSpeed%60, 0);
Console.WriteLine($"Walk time: {walkTimeMin} minutes {walkTimeSec} seconds");
Console.WriteLine(" ");

// part 4
Console.WriteLine("==================================");
Console.WriteLine("        ETSU STUDENT BADGE        ");
Console.WriteLine("==================================");
Console.WriteLine(" ");
Console.WriteLine("NAME".PadRight(10) + fullName.ToUpper());
Console.WriteLine("USERNAME".PadRight(10) + username);
string idAndCheck = studentID + "-" + studentID%9;
Console.WriteLine("ID".PadRight(10) + idAndCheck);
Console.WriteLine($"LOCKER".PadRight(10) + studentLocker);
Console.WriteLine("WALK".PadRight(10) + walkTimeMin + " min " + walkTimeSec + " sec ");