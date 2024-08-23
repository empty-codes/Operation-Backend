/*
 * Project Idea: Create a simple calculator that can perform basic arithmetic operations 
 * (addition, subtraction, multiplication, division).
 */

Console.WriteLine("Welcome to Morayo's calculator");

int op1, op2;

do
{
    Console.WriteLine("\n\nNote: The first operator must be bigger than the second number.");
    Console.Write("Enter first operator: ");
    op1 = int.Parse(Console.ReadLine());

    Console.Write("\nEnter second operator: ");
    op2 = int.Parse(Console.ReadLine());
} while (op1 < op2);



Console.WriteLine("\nSelect operation:");
Console.WriteLine("+ for Addition");
Console.WriteLine("- for Subtraction");
Console.WriteLine("* for Multiplication");
Console.WriteLine("/ for Division");
Console.WriteLine("% for modulus\n");
char choice = char.Parse(Console.ReadLine());


switch (choice)
{
    case '+':
        Console.WriteLine($"\n{op1} {choice} {op2} = {(op1 + op2)}");
        break;
    case '-':
        Console.WriteLine($"\n{op1} {choice} {op2} = {(op1 - op2)}");
        break;
    case '*':
        Console.WriteLine($"\n{op1} {choice} {op2} = {(op1 * op2)}");
        break;
    case '/':
        Console.WriteLine($"\n{op1} {choice} {op2} = {(op1 / op2)}");
        break;
    case '%':
        Console.WriteLine($"\n{op1} {choice} {op2} = {(op1 % op2)}");
        break;

}



Console.ReadKey();

