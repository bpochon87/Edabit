using System.Linq;

// June 16, 2022
// Medium

public class Program
{
    // Create a function that takes two integers [num, length] as args and returns an array of multiples
    // of [num] until the array length reaches the [length]
    public void ArrayOfMultiples()
    {
        int num = 5;
        int length = 10;
        List<int> multiplesList = new List<int>();
        int multiplier = 1;
        for (int i = 1; i <= length; i++)
        {
            int product = num * multiplier;
            multiplesList.Add(product);
            multiplier++;
        }
        int[] multiplesArray = multiplesList.ToArray();
        Console.WriteLine($"{string.Join(", ", multiplesArray)}");
    }



    public static void Main()
    {
        Program pr = new Program();
        pr.ArrayOfMultiples();
    }
























}
