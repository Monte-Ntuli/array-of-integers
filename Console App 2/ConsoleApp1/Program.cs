// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public static int SumOfEvenNumbers(int[] numbers)
{
    return numbers.Where(n => n % 2 == 0).Sum();
}