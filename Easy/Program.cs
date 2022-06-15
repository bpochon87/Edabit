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

    // June 15, 2022
    // Easy

    // Create a function that takes an array of number and returns a new array sorted in ascending order.
    public void SortNumAscending()
    {
        int[] arr = { 15, 3, 42, 7, 59, 0, 21 };
        Array.Sort(arr);
        // string.Join(Char, Object[]) concatenates the string representations of an array of objects
        // using the specified separator between each member.
        Console.WriteLine($"{string.Join(", ", arr )}");;
    }

    // Given two integers, return [true] if [a] can be divided evenly by [b]. Return [false] otherwise.
    public void DividesEvenly()
    {
        Console.WriteLine("Please enter a number: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter another number: ");
        int y = Convert.ToInt32(Console.ReadLine());

        if (x % y == 0)
        {
            Console.WriteLine($"{x} can be evenly divided by {y}. This is true");
        }
        else
        {
            Console.WriteLine($"{x} cannot be evenly divided by {y}. This is false.");
        }
    }

    // Return negative number. If negative, keep negative.
    public void ReturnNegative()
    {
        System.Console.WriteLine("Please enter a number: ");
        int userNum = Convert.ToInt32(Console.ReadLine());
        int negativeNum = userNum < 0 ? userNum : -userNum;
        System.Console.WriteLine($"Your number negative is { negativeNum }.");
    }


















    public static void Main(string[] args)
    {
        Program pr = new Program();
        pr.Factorial();
        pr.FizzBuzz();
        pr.SortNumAscending();
        pr.DividesEvenly();
        pr.ReturnNegative();
    }









}