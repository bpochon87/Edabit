// June 14, 2022
// Easy

public class Program
{
    // Find factorial of given number.
    public void Factorial()
    {
        Console.WriteLine("Please enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int fact = 1;
        for (int i = 1; i <= num; i++)
        {
            fact *= i;
        }
        Console.WriteLine($"The factorial of {num} is {fact}.");
    }

    // Fizzbuzz
    // If number is multiple of 3, return Fizz.
    // If number is multiple of 5, return Buzz.
    // If number is multiple of 3 and 5, return FizzBuzz.
    // If number isn't multiple of either, return number.
    public void FizzBuzz()
    {
        Console.WriteLine("Please enter another number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num <= 0)
        {
            FizzBuzz();
        }
        else if (num % 3 == 0 && num % 5 == 0)
        {
            Console.WriteLine("FizzBuzz");
        }
        else if (num % 3 == 0)
        {
            Console.WriteLine("Fizz");
        }
        else if (num % 5 == 0)
        {
            Console.WriteLine("Buzz");
        }
        else
        {
            Console.WriteLine($"Take {num} elsewhere.");
        }
    }

    public static void Main(string[] args)
    {
        Program pr = new Program();
        pr.Factorial();
        pr.FizzBuzz();
    }









}