Console.WriteLine("Enter first number:");
string firstNumber = Console.ReadLine();

Console.WriteLine("Enter first number:");
string secondNumber = Console.ReadLine();

try
{
    int sum = Convert.ToInt32(firstNumber) + Convert.ToInt32(secondNumber);
    int div = Convert.ToInt32(firstNumber) / Convert.ToInt32(secondNumber);

    Console.WriteLine(firstNumber + " + " + secondNumber + " = " + sum);
    Console.WriteLine(firstNumber + " / " + secondNumber + " = " + div);

}

catch (FormatException ex)
{
    Console.WriteLine("You should write only numeric value!");
}

catch(DivideByZeroException ex)
{
    Console.WriteLine("You should not enter second number as zero!");
}

finally
{
    Console.WriteLine("I am from finally block!");
}