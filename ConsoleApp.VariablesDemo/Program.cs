// See https://aka.ms/new-console-template for more information

// Different datatypes
/*
    text - string
    integers-int
    decimal-double, float, decimal
    logical - bool
    
 */

string name = "Daniel Chambers";

Console.WriteLine(name);
Console.WriteLine("They call me " + name);
Console.WriteLine($"I was given the name {name}");
Console.WriteLine("I am {0}", name);

int age = 33;
int retirementYearsLeft = 32;
int retirementAge = age + retirementYearsLeft;

Console.WriteLine("My retirement age is " + retirementAge);
Console.WriteLine("I am " + age + " Years old");

bool isRetired = false;
Console.WriteLine("Am I retired? " + isRetired);


