﻿using System;
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

    // October 20, 2022
    // Medium

    // You're given a string of words. You need to find the word "Nemo", and return a string like this: 
    // "I found Nemo at [the order of the word you find Nemo]!". If you can't find Nemo, return "I can't find Nemo :(".

    public void FindNemo()
    {
        string str = "I am Ne mo Nemo !";
        string[] arr = str.Split(' ');
        int currPos = 1;

        foreach (string s in arr)
        {
            if (s == "Nemo")
            {
                System.Console.WriteLine($"I found Nemo at {currPos}!");
            }
            else
            {
                currPos++;
            }
        }
        System.Console.WriteLine("I can't find Nemo :(");
        Console.ReadLine();
    }

    
    public static void Main()
    {
        Program pr = new Program();
        // pr.ArrayOfMultiples();
        // pr.IndexOfCapitals();
        pr.FindNemo();
    }
























}
