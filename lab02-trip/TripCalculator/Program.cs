/*
* Name: Jocie Marino
* Course: CSCI 1250, Section 002
* Assignment: Lab 02, Trip Calculator
* Date: September 28, 2026
* Description: Calculates fuel, food, and work hours for one road trip.
*/

System.Console.WriteLine("Welcome to the Trip Calculator!"); 

//miles, MPG, gas prices, total gas
System.Console.WriteLine(""); 
System.Console.Write("How many miles will the round trip be? ");
double totalMiles = Convert.ToDouble(Console.ReadLine());
System.Console.Write("How many miles per gallon does your car get? ");
double milesPerGallon = Convert.ToDouble(Console.ReadLine());
System.Console.Write("How much will gas cost per gallon? $");
decimal gasCost = Convert.ToDecimal(Console.ReadLine()); 
double totalGallons = totalMiles/milesPerGallon;
decimal totalGasCost = (decimal)totalGallons * gasCost;

//food
System.Console.WriteLine("");
const int PIZZA_SLICES = 8; 
System.Console.Write("How many people are going on this trip? ");
int totalPeople = Convert.ToInt32(Console.ReadLine()); //Int because value should never include a decimal
System.Console.Write("How many pizzas will you purchase? ");
int totalPizzas = Convert.ToInt32(Console.ReadLine());
System.Console.Write("How much is each pizza? $");
decimal pizzaCost = Convert.ToDecimal(Console.ReadLine());

//earnings
System.Console.WriteLine("");
const float TAX_RATE = .18f;
System.Console.Write("How many hours did you work this week? ");
double hoursWorked = Convert.ToDouble(Console.ReadLine());
System.Console.Write("How much money do you make an hour? $");
decimal wageHourly = Convert.ToDecimal(Console.ReadLine());
System.Console.WriteLine("");
decimal grossPay = (decimal)hoursWorked*wageHourly;
decimal takeHomePay = grossPay-grossPay*(decimal)TAX_RATE;

//trip total
decimal tripTotal = totalPizzas*pizzaCost+totalGasCost;
decimal costPerPerson = tripTotal/totalPeople;
decimal perHourTakeHomePay = takeHomePay/(decimal)hoursWorked;

//full thing
System.Console.WriteLine("=== Part 1: Road Trip ===");
System.Console.WriteLine($"Round trip miles: {totalMiles}");
System.Console.WriteLine($"Miles per gallon: {milesPerGallon}");
System.Console.WriteLine($"Price per gallon: {gasCost}");
System.Console.WriteLine("");
System.Console.WriteLine($"Gallons needed: {totalGallons:F2}");
System.Console.WriteLine($"Fuel cost: {totalGasCost:C}");

System.Console.WriteLine("");

System.Console.WriteLine("=== Part 2: Pizza Party ===");
System.Console.WriteLine($"How many people are attending: {totalPeople}");
System.Console.WriteLine($"How many pizzas: {totalPizzas}");
System.Console.WriteLine($"Price per pizza: {pizzaCost}");
System.Console.WriteLine("");
System.Console.WriteLine($"Total Slices: {totalPizzas*PIZZA_SLICES:F0}");
System.Console.WriteLine($"Slices Per Person: {(float)totalPizzas*PIZZA_SLICES/totalPeople:F2}"); // Float so that it doesn't try to round a value that MAY be a decimal (it did my first commit)
System.Console.WriteLine($"Pizza cost: {totalPizzas*pizzaCost:C}");

System.Console.WriteLine("");

System.Console.WriteLine("=== Part 3: Earnings ===");
System.Console.WriteLine($"Hours worked this week: {hoursWorked}");
System.Console.WriteLine($"Hourly rate: {wageHourly}");
System.Console.WriteLine("");
System.Console.WriteLine($"Gross pay: {grossPay:C}");
System.Console.WriteLine($"Tax witheld: {grossPay*(decimal)TAX_RATE:C}");
System.Console.WriteLine($"Take home pay: {takeHomePay:C}");

System.Console.WriteLine("");

System.Console.WriteLine("=== Part 4: Entire Trip ===");
System.Console.WriteLine($"Trip total: {tripTotal:C}");
System.Console.WriteLine($"Cost per person: {costPerPerson:C}");
System.Console.WriteLine($"Take home pay per hour: {takeHomePay/(decimal)hoursWorked:C}");
System.Console.WriteLine($"Hours you must work to cover your share: {costPerPerson/perHourTakeHomePay:F2}");