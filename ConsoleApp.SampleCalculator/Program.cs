// See https://aka.ms/new-console-template for more information
Console.WriteLine("***** - Welcome to the Sample Calculator - *****");

// Show calculator options / Show menu

Console.WriteLine("Please select an operation");
Console.WriteLine("1. Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Multiplication");
Console.WriteLine("4. Division");
int choice = Convert.ToInt32(Console.ReadLine());
// Prompt User for Input
Console.Write("Please enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());





// Decide which operation is needed based on selected option
int answer = 0;
switch (choice)
{

    case 1:
        answer = num1 + num2;
        break;
    case 2: 
        answer = num1 - num2;
        break;
    case 3:
        answer = num1 * num2;
        break;
    case 4:
        answer = num1 / num2;
        break;
    default:
        Console.WriteLine("Invalid Choice");
        break;
}
// print output

Console.WriteLine($"Your answer is: {answer}");