﻿// Declare variables
using System.Xml.Linq;

string? firstName = string.Empty;
string lastName = string.Empty;
int age;
int retirementAge = 65;
decimal salary;
char gender;
bool working = true; // Will automatically take value of false


// Prompt the user for input

Console.Write("Please enter your first name: ");
firstName = Console.ReadLine();
Console.Write("Please enter your last name: ");
lastName = Console.ReadLine();

Console.Write("Please enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter your salary: "); // int 2 | decimal 2.5
salary = Convert.ToDecimal(Console.ReadLine());


Console.Write("Please enter your gender (M or F): ");
gender = Convert.ToChar(Console.ReadLine());


Console.Write("Are you working? (true or false): ");
working = Convert.ToBoolean(Console.ReadLine());

// Process the data

int workingYearsRemaining = retirementAge - age;

// Output to the user
Console.WriteLine($"Full name: {firstName} {lastName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Your salary is: {salary}");
Console.WriteLine($"Your gender is: {gender}");
Console.WriteLine($"You are employed: {working}");
Console.WriteLine($"Working Years Remaining: {workingYearsRemaining}");






