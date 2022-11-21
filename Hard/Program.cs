using System;
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

    // // We're given a string with vowels censored with *. We're given a second string with the vowels that were censored in sequential order. Reinsert the second string vowels into the first censored string.

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

    // November 18, 2022
    // Hard

    // Create a function that takes an array of integers and removes the smallest value.

    public int[] RemoveSmallest(int[] values)
    {
        // [] => list
        // remove smallest int
        // list => []

        List<int> numList = values.ToList();
        var smallestInt = numList.Min();
        numList.Remove(smallestInt);
        int[] newArr = numList.ToArray();
        return newArr;
    }

    static void Main(string[] args)
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
        Console.WriteLine(pr.RemoveSmallest(new int[] { 1, 2, 3, 4, 5 }));
    }
}
