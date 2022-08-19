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

    // June 19, 2022
    // Easy

    // An overlapped clap is a clap which starts but doesn't finish, as in "ClaClap" (the first clap is
    // cut short and there are overall 2 claps). Given a string of what the overlapping claps sounded
    // like, return how many claps were made in total.

    public void CountClaps()
    {
        string txt = "ClaClaClaClaClap";
        int counter = 0;
        char[] charArr = txt.ToCharArray();
        for (int i = 0; i < charArr.Length; i++)
        {
            if (Char.IsUpper(charArr[i]) == true)
            {
                counter++;
            }
        }
        Console.WriteLine($"The number of claps is {counter}.");

    }

    // Create a function that counts how many D's are in a sentence.
    public void CountDs()
    {
        string str = "Today was a day unlike any other day.";
        int counter = 0;
        char[] charArr = str.ToCharArray();
        for (int i = 0; i < charArr.Length; i++)
        {
            if (charArr[i] == 'D' || charArr[i] == 'd')
            {
                counter ++;
            }
        }
        Console.WriteLine($"The number of dees is {counter}.");
    }

    // Create a function that takes an array of strings and returns the words that are exactly four letters.
    public void IsFourLetter()
    {
        // Array to check four letter names for.
        string[] arr = new string[] {"Ryan", "Kieran", "Jason", "Matt"};
        
        List<string> fourLetterList = new List<string> {};
        List<string> nameList = arr.ToList();
        IEnumerable<string> query = nameList.Where(x => x.Length == 4);

        foreach (string name in query)
        {
            Console.WriteLine(name);
        }
    }

    // July 17, 2022

    // Create a function that takes an array of numbers and returns the largest.
    // The easy way would be to return arr.Max(), using System.Linq;
    // However, I challenged myself to do it manually.
    public void FindLargestNum()
    {
        int[] arr = new int[] {23, 53, 21, 0, 31, 85, 200};
        int biggestNum = 0;
        foreach (int num in arr)
        {
            if (num > biggestNum)
            {
                biggestNum = num;
            }
        }
        Console.WriteLine($"The biggest number is {biggestNum}.");
    }

    // Write a function that takes two numbers and a mathematical operator and returns the result.

    public void Calculate()
    {
        int num1 = 10;
        int num2 = 5;
        string operation = "*";

        // I liked using nested ternary operators here.
        int result = operation == "+" ? num1 + num2 :
        operation == "-" ? num1 - num2 :
        operation == "*" ? num1 * num2 :
        operation == "/" ? num1 / num2 :
        operation == "%" ? num1 % num2 : 0;

        System.Console.WriteLine($"The result of {num1} {operation} {num2} is {result}.");
    }

    // July 28, 2022

    // Create a function that takes a string and calculates number of letters and digits within it.
    public void CountDigitsLetters()
    {
        string str = "Ajp072 jnv732 fn7c3";
        str.ToLower();

        int digitCount = 0;
        int letterCount = 0;

        char[] charDigArr = str.ToCharArray();

        for(int i = 0; i < charDigArr.Length; i++)
        {
            if(Char.IsDigit(charDigArr[i]) == true)
            {
                digitCount++;
            }
            else if(charDigArr[i] == ' ')
            {
                continue;
            }
            else
            {
                letterCount++;
            }
        }
        Console.WriteLine($"Letter count is {letterCount} \nNumber count is {digitCount}");
    }

    // Confirm that the input is a zip code consisting of five consecutive digits.
    public void ZipCode()
    {
        string zip = "69153";

        if(zip.Length == 5)
        {
            for(int i = 0; i < zip.Length; i++)
            {
                if(Char.IsDigit(zip[i]) == true && zip[i] != ' ')
                {
                    continue;
                }
                else
                {
                    System.Console.WriteLine($"{zip} isn't a zip code.");;
                }
            }
            System.Console.WriteLine($"{zip} is a zip code.");;
        }
        else
        {
            System.Console.WriteLine($"{zip} isn't a zip code.");;
        }
    }

    // July 29, 2022

    // Given a fraction as a string, return whether or not it is greater than 1 when evaluated.

    void GreaterThanOne()
    {
        string str = "9/10";

        string[] arr = str.Split("/");
        int[] numbers = Array.ConvertAll(arr, s => int.Parse(s));

        bool greaterThan = numbers[0] > numbers[1] ? true : false;

        System.Console.WriteLine($"Is the string-fraction {str} greater than one? This is {greaterThan}.");
    }

    // August 2, 2022

    // Write a function that removes any non-letters from a string, returning a well-known film title. 

    void FindMovieTitle()
    {
        string str = "^,]%4B|@56a![0{2m>b1&4i4";
        string movieTitle = "";

        char[] letters = str.ToCharArray();
        foreach(char c in letters)
        {
            if(Char.IsLetter(c) == true)
            {
                movieTitle += c;
            }
        }
        System.Console.WriteLine($"The title of the movie is {movieTitle}");
    }

    // Count the amount of ones in the binary representation of an integer. 
    // For example, since 12 is 1100 in binary, the return value should be 2.
    void CountOnes()
    {
        int i = 456789;
        int onesCount = 0;
        string binary = Convert.ToString(i, 2);
        
        for(int j = 0; j < binary.Length; j++)
        {
            if(binary[j] == '1')
            {
                onesCount += 1;
            }
        }
        Console.WriteLine($"The number of 1s in the binary form of {i} is {onesCount}.");
    }

    // Create a function that takes an array of numbers and returns an array
    // where each number is the sum of itself + all previous numbers in the array.

    // In-place mutation because it's being changed as we go. Very efficient with memory.
    void CumulativeSum()
    {
        double[] arr = new double[] { 2, 5, 3, 1, 6, 4, 3, 6 };
        for(int i = 1; i < arr.Length; i++)
        {
            arr[i] = arr[i] + arr[i - 1];
        }

        System.Console.WriteLine($"The cumulatively-added array is: {String.Join(", ", arr)}");
    }




    
    
    public static void Main(string[] args)
    {
        Program pr = new Program();
        // pr.Factorial();
        // pr.FizzBuzz();
        // pr.SortNumAscending();
        // pr.DividesEvenly();
        // pr.ReturnNegative();
        // pr.CountClaps();
        // pr.IsFourLetter();
        // pr.FindLargestNum();
        // pr.Calculate();
        // pr.CountDigitsLetters();
        // pr.ZipCode();
        // pr.GreaterThanOne();
        // pr.FindMovieTitle();
        // pr.CountOnes();
        pr.CumulativeSum();
    }









}