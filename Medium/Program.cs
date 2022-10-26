using System;
using System.Linq;

// June 16, 2022
// Medium

public class Program
{
    // // Create a function that takes two integers [num, length] as args and returns an array of multiples
    // // of [num] until the array length reaches the [length]
    // public void ArrayOfMultiples()
    // {
    //     int num = 5;
    //     int length = 10;
    //     List<int> multiplesList = new List<int>();
    //     int multiplier = 1;
    //     for (int i = 1; i <= length; i++)
    //     {
    //         int product = num * multiplier;
    //         multiplesList.Add(product);
    //         multiplier++;
    //     }
    //     int[] multiplesArray = multiplesList.ToArray();
    //     Console.WriteLine($"{string.Join(", ", multiplesArray)}");
    // }

    // // June 22, 2022
    // // Medium

    // // Create a function that takes a single string as argument and returns an ordered array 
    // // containing the indices of all capital letters in the string.

    // public void IndexOfCapitals()
    // {
    //     string str = "HeLLo THEre.";

    //     List<int> capitalIndicesList = new List<int>();

    //     for (int i = 0; i < str.Length; i++)
    //     {
    //         if (Char.IsUpper(str[i]))
    //         {
    //             int capitalIndex = str.IndexOf(str[i]);
    //             capitalIndicesList.Add(capitalIndex);
    //         }
    //     }
    //     int[] capitalIndicesArray = capitalIndicesList.ToArray();
    //     System.Console.WriteLine($"The indices for capital letter in the string are { String.Join(", ", capitalIndicesArray)} ");
    // }

    // // October 20, 2022
    // // Medium

    // // You're given a string of words. You need to find the word "Nemo", and return a string like this: 
    // // "I found Nemo at [the order of the word you find Nemo]!". If you can't find Nemo, return "I can't find Nemo :(".

    // public void FindNemo()
    // {
    //     string str = "I am Ne mo Nemo !";
    //     string[] arr = str.Split(' ');
    //     int currPos = 1;

    //     foreach (string s in arr)
    //     {
    //         if (s == "Nemo")
    //         {
    //             System.Console.WriteLine($"I found Nemo at {currPos}!");
    //         }
    //         else
    //         {
    //             currPos++;
    //         }
    //     }
    //     System.Console.WriteLine("I can't find Nemo :(");
    //     Console.ReadLine();
    // }

    // // October 24, 2022
    // // Medium

    // // Create a function that tests whether or not an integer is a perfect number. 
    // // A perfect number is a number that can be written as the sum of its factors,
    // // (equal to sum of its proper divisors) excluding the number itself.

    // public void FactorsAddUp()
    // {
    //     int num = 6;
    //     int[] factors = {1, 2, 3};
    //     int sum = 0;

    //     for (int i = 1; i < num; i++)
    //     {
    //         if (num % i == 0)
    //         {
    //             sum += i;
    //         }
    //         else
    //         {
    //             continue;
    //         }
    //     }
    //     System.Console.WriteLine(sum == num);
    // }

    // October 26, 2022
    // Medium

    // Given an array of integers, return the largest gap between elements of the sorted version of that array.

    // public void LargestGap()
    // {
    //     int[] arr = {9, 4, 26, 26, 0, 0, 5, 20, 6, 25, 5};

    //     Array.Sort(arr);
    //     int difference = 0;
        
    //     for (int i = 0, j = 1; i < arr.Length - 1; i++, j++)
    //     {
    //         int currGap = Math.Abs(arr[i] - arr[j]);
    //         if (currGap > difference)
    //         {
    //             difference = currGap;
    //         }
    //         else
    //         {
    //             continue;
    //         }
    //     }
    //     System.Console.WriteLine(difference);
    // }

    // October 26, 2022
    // Medium

    // Without using conditionals, ternary operators, etc., flip one to zero and zero to one.

    public int Flip(int y)
    {
        return Convert.ToInt32(!(Convert.ToBoolean(y)));
    }

    
    public static void Main()
    {
        Program pr = new Program();
        // pr.ArrayOfMultiples();
        // pr.IndexOfCapitals();
        // pr.FindNemo();
        // pr.FactorsAddUp();
        // pr.LargestGap();
        Console.WriteLine(pr.Flip(0));
        Console.ReadLine();
    }
























}
