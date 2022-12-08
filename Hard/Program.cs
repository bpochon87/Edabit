using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class Program
{
    //     // November 15, 2022
    //     // Hard

    //     // Give two arrays as arguments, check for existence of each element in bigrams array in at least one element of words array.

    //     public bool CanFind(string[] bigrams, string[] words)
    //     {
    //         int found = 0;

    //         if (words.Length == 0)
    //         {
    //             return false;
    //         }

    //         foreach (string s in bigrams)
    //         {
    //             foreach (string word in words)
    //             {
    //                 if (word.Contains(s))
    //                 {
    //                     found++;
    //                     continue;
    //                 }
    //             }
    //         }
    //         return found == bigrams.Length ? true : false;
    //     }

    // // November 17, 2022
    // // Hard

    // // We're given a string with vowels censored with *. We're given a second string with the vowels that were censored in sequential order.     Reinsert the second string vowels into the first censored string.

    // public string Censored(string censor, string vowels)
    // {
    //     char[] arrCen = censor.ToCharArray();
    //     char[] arrVow = vowels.ToCharArray();

    //     for (int i = 0, j = 0; i < arrCen.Length; i++)
    //     {
    //         if (arrCen[i] == '*')
    //         {
    //             arrCen[i] = arrVow[j];
    //             j++;
    //         }
    //     }
    //     return string.Join("", arrCen);
    // }

    // // November 18, 2022
    // // Hard

    // // Create a function that takes an array of integers and removes the smallest value.

    // public int[] RemoveSmallest(int[] values)
    // {
    //     // [] => list
    //     // remove smallest int
    //     // list => []

    //     List<int> numList = values.ToList();
    //     var smallestInt = numList.Min();
    //     numList.Remove(smallestInt);
    //     int[] newArr = numList.ToArray();
    //     return newArr;
    // }

    // // November 21, 2022
    // // Hard

    // // Complete all questions.
    // // Max time to complete: 120 min
    // // Max time very easy 5 min.
    // // Max time easy 10 min.
    // // Max time medium 15 min.
    // // Max time hard 20 min.
    // // test == Interview(net int[] {very easy, very easy, easy easy, medium, medium, hard, hard})

    // public string Interview(int[] arr, int totalMin)
    // {
    //     if (
    //         totalMin <= 120
    //         && arr.Length == 8
    //         && arr[0] <= 5
    //         && arr[1] <= 5
    //         && arr[2] <= 10
    //         && arr[3] <= 10
    //         && arr[4] <= 15
    //         && arr[5] <= 15
    //         && arr[6] <= 20
    //         && arr[7] <= 20
    //     )
    //     {
    //         return "qualified";
    //     }
    //     else
    //     {
    //         return "disqualified";
    //     }
    // }

    // // November 22, 2022
    // // Hard

    // // Take in string. Reverse words that are >= five chars long. Return new string.

    // public string ReversedString(string str)
    // {
    //     // Split string into separate words
    //     string[] words = str.Split(' ');
    //     // Traverse through each word in array.
    //     for (int i = 0; i < words.Length; i++)
    //     {
    //         // If word is >= 5 chars, reverse.
    //         if (words[i].Length > 4)
    //         {
    //             words[i] = new string(words[i].ToCharArray().Reverse().ToArray());
    //         }
    //         else
    //         {
    //             continue;
    //         }
    //     }
    //     return string.Join(" ", words);
    // }

    // // November 23, 2022
    // // Hard

    // // Confirm that a given string is a hex code that is six characters long, starts with #, and has A-Fa-f or digits.

    // public bool IsValidHexCode(string hex)
    // {
    //     string pattern = (@"^[#][A-F|a-f|\d]{6}$");
    //     return Regex.IsMatch(hex, pattern);
    // }

    // // November 28, 2022
    // // Hard

    // // Create a function that takes in n, a, b, and returns the number of positive values raised to the nth power that lie
    // // in the range [a, b] inclusively.

    // public int PowerRanger(int power, int min, int max)
    // {
    //     int counter = 0;

    //     for (int i = 1; Math.Pow(i, power) <= max; i++)
    //     {
    //         if (Math.Pow(i, power) >= min && Math.Pow(i, power) <= max)
    //         {
    //             counter++;
    //         }
    //         else
    //         {
    //             continue;
    //         }
    //     }
    //     return counter;
    // }

    // // November 28, 2022
    // // Very hard

    // // Create a function that takes an int and outputs an n x n square solely consisting of the int n.
    // // I found a solution that works on Edabit (below), however I would like to figure out how to print the 2d array to the console.

    // public int[,] SquarePatch(int n)
    // {
    //     int[,] grid = new int[n, n];

    //     if (n == 0) 
    //     {
    //         // Empty multidimensional array.
    //         return (new int[,] {}); 
    //     }
    //     else
    //     {
    //         for (int i = 1; i < n; i++)
    //         {
    //             for (int j = 1; j < n; j++)
    //             {
    //                 grid[i, j] = n;
    //             }
    //         }
    //     }
    //     return grid;
    // }

    // // Very Hard
    // // December 2, 2022

    // // Create a function that returns the simplified version of a fraction (given as a string).

    // public string SimplifiedFraction(string fraction)
    // {
    //     // Parse string and breakup into individual pieces.
    //     // Convert those pieces to an int.
    //     // Run a loop on both to see if divisible by two.
    //     // Convert back to string and return.
    //     string[] arr = fraction.Split('/');
    //     int numerator = Convert.ToInt32(arr[0]);
    //     int denominator = Convert.ToInt32(arr[1]);

    //     // Need to start dividing
    //     if (numerator % 2 == 0 || numerator % 5 == 0)
    //     {
    //         while (numerator % 2 == 0 && denominator % 2 == 0)
    //         {
    //             numerator /= 2;
    //             denominator /= 2;

    //             if (denominator == 1)
    //             {
    //                 return $"{Convert.ToString(numerator)}";
    //             }
    //         }
    //         while (numerator % 5 == 0 && denominator % 5 == 0)
    //         {
    //             numerator /= 5;
    //             denominator /=5;
                
    //             if (denominator == 1)
    //             {
    //                 return $"{Convert.ToString(numerator)}";
    //             }
    //         }

    //     }
    //     return $"{Convert.ToString(numerator)}/{Convert.ToString(denominator)}";
    // }

    // // Hard
    // // December 6, 2022

    // // Decompose a given integer into its separate digits. Then add together said digits. They'll be "Evenish" for evens and "Oddish" for odds.

    // public string OddishEvenish(int num)
    // {
    //     int total = 0;
    //     while (num > 0)
    //     {
    //         total += num % 10;
    //         num /= 10;
    //     }
    //     return total % 2 == 0 ? "Evenish" : "Oddish";
    // }

    // Very Hard
    // December 8, 2022

    // Write a binary search algorithm that returns whether or not the given int is found within the given array of primes.

    public bool BinarySearch(int num)
    {
        int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };

        int low = 0;
        int high = primes.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (primes[mid] == num)
            {
                return true;
            }
            else if (primes[mid] < num)
            {
                low = mid + 1;
            }
            else if (primes[mid] > num)
            {
                high = mid - 1;
            }
        }
        return false;
    }

    // Very Hard
    // December 8, 2022

    // Create a function that takes a number n as an arg and returns the first n elements of the Fibonacci Word sequence.

    // public string FiboWord(int n)
    // {

    // }

    public static void Main(string[] args)
    {
        Program pr = new Program();

        // Console.WriteLine(
        //     pr.CanFind(
        //         new string[] { "at", "be", "th", "au" },
        //         new string[] { "beautiful", "the", "hat" }
        //     )
        // );
        // Console.WriteLine(
        //     pr.CanFind(
        //         new string[] { "ay", "be", "ta", "cu" },
        //         new string[] { "maybe", "beta", "abet", "course" }
        //     )
        // );
        // Console.WriteLine(
        //     pr.CanFind(
        //         new string[] { "oo", "mi", "ki", "la" },
        //         new string[] { "milk, chocolate, cooks" }
        //     )
        // );

        // Console.WriteLine(pr.Censored("Wh*r* d*d my v*w*ls g*?", "eeioeo"));
        // Console.WriteLine(pr.Censored("Ch**s*, Gr*mm*t -- ch**s*", "eeeoieee"));
        // Console.WriteLine(pr.RemoveSmallest(new int[] { 1, 2, 3, 4, 5 }));
        // Console.WriteLine(pr.Interview(new int[] { 5, 5, 10, 15, 15, 20, 20 }, 120));
        // Console.WriteLine(pr.ReversedString("This is a typical sentence."));
        // Console.WriteLine(pr.IsValidHexCode("#CD5C&C"));
        // Console.WriteLine(pr.PowerRanger(2, 1, 100));
        // System.Console.WriteLine(pr.SquarePatch(5));
        // System.Console.WriteLine(pr.SimplifiedFraction("50/25"));
        // Console.WriteLine(pr.OddishEvenish(555555555));
        Console.WriteLine(pr.BinarySearch(2));
    }
}
