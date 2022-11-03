using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

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

    // // October 26, 2022
    // // Medium

    // // Without using conditionals, ternary operators, etc., flip one to zero and zero to one.

    // public int Flip(int y)
    // {
    //     return Convert.ToInt32(!(Convert.ToBoolean(y)));
    // }

    // // October 27, 2022
    // // Medium

    // // Create a function that takes a number as an argument. Add up all the numbers from 1 to the 
    // // number you passed to the function. For example, if the input is 4 then your function should 
    // // return 10 because 1 + 2 + 3 + 4 = 10.

    // public int AddUp(int num) 
    // {
    //     int sum = 0;
    //     int i = 1;
        
    //     while (i <= num)
    //     {
    //         sum += num - i;
    //         i++;
    //     }
    //     return sum;
    // }

    // // November 1, 2022
    // // Medium

    // // Remove special characters. Only spaces, upper and lowercase chars, and dash and underscore are allowed.

    // public void RemoveSpecialCharacters()
    // {
    //     string str = "%fd76$fd(-)6GvKlO.";
    //     string pattern = "[^A-Za-z\\s_-]";
    //     string replacement = "";

    //     Regex rx = new Regex(pattern);
    //     string result = rx.Replace(str, replacement);
        
    //     System.Console.WriteLine(result);
    // }
    
    // // November 2, 2022
    // // Medium

    // // Find all substrings of "potato" and return as an int.

    // public void Potato()
    // {
    //     string test = "onepotatotwopotatothreepotato";

    //     string pattern = "(?:potato)";
    //     int count = 0;

    //     foreach (Match match in Regex.Matches(test, pattern))
    //     {
    //         count += 1;
    //     }
    //     System.Console.WriteLine(count);
    // }

    // // November 2, 2022
    // // Medium

    // // Given an integer, take each individual digit times the next: (133) = 1 * 3 * 3 = 9.

    // public void ReverseString()
    // {
    //     int test = 555;

    //     int product = 1;

    //     while (test % 10 > 0)
    //     {
    //         product *= test % 10;
    //         test /= 10;
    //     }
    //     System.Console.WriteLine(product);
    // }

    // November 3, 2022
    // Medium

    // 1) Reverse the string.
    // 2) Replace vowels as follows: a=0; e=1; i=2; o=2; u=3;
    // 3) Add "aca" to end of new string.

    public void Codify()
    {
        string word = "karaca";

        var reverseWord = new string(word.ToCharArray().Reverse().ToArray());
		StringBuilder sb = new StringBuilder(reverseWord);
		for (int i = 0; i < sb.Length; i++)
		{
            switch (sb[i])
            {
                case 'a':
                    sb[i] = '0';
                    break;
                case 'e':
                    sb[i] = '1';
                    break;
                case 'i':
                    sb[i] = '2';
                    break;
                case 'o':
                    sb[i] = '2';
                    break;
                case 'u':
                    sb[i] = '3';
                    break;
            }
        }
        System.Console.WriteLine(sb + "aca");
    }

    public static void Main()
    {
        Program pr = new Program();
        // pr.ArrayOfMultiples();
        // pr.IndexOfCapitals();
        // pr.FindNemo();
        // pr.FactorsAddUp();
        // pr.LargestGap();
        // Console.WriteLine(pr.Flip(0));
        // Console.ReadLine();
        // pr.AddUp(4);
        // pr.RemoveSpecialCharacters();
        // pr.Potato();
        // pr.ReverseString();
        pr.Codify();
    }
























}
