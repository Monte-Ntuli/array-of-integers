// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public static int SumOfEvenNumbers(int[] numbers)
{
    int sum = 0;
    foreach (var number in numbers)
    {
        if (number % 2 == 0)
        {
            sum += number;
        }
    }
    return sum;
}