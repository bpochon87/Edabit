using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class Program
{
    // November 15, 2022
    // Hard

    // Give two arrays as arguments, check for existence of each element in bigrams array in at least one element of words array.

    public bool CanFind(string[] bigrams, string[] words)
    {
        int found = 0;

        if (words.Length == 0)
        {
            return false;
        }

        foreach (string s in bigrams)
        {
            foreach (string word in words)
            {
                if (word.Contains(s))
                {
                    found++;
                    continue;
                }
            }
        }
        return found == bigrams.Length ? true : false;
    }

    public static void Main(string[] args)
    {
        Program pr = new Program();

        Console.WriteLine(
            pr.CanFind(
                new string[] { "at", "be", "th", "au" },
                new string[] { "beautiful", "the", "hat" }
            )
        );
        Console.WriteLine(
            pr.CanFind(
                new string[] { "ay", "be", "ta", "cu" },
                new string[] { "maybe", "beta", "abet", "course" }
            )
        );
        Console.WriteLine(
            pr.CanFind(
                new string[] { "oo", "mi", "ki", "la" },
                new string[] { "milk, chocolate, cooks" }
            )
        );
    }
}
