Console.WriteLine("Enter first number:");
string firstNumber = Console.ReadLine();

Console.WriteLine("Enter first number:");
string secondNumber = Console.ReadLine();

try
{
    int sum = Convert.ToInt32(firstNumber) + Convert.ToInt32(secondNumber);
    Console.WriteLine(firstNumber+" + "+secondNumber+" = "+sum);
}
catch
{
    Console.WriteLine("You should write only numeric value!");
}
finally
{
    Console.WriteLine("I am from finally block!");
}