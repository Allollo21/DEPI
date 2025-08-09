// Top - Level statement to save some space 

#region Program to Print Numbers in a Range
/*
    Write a program that allows the user to insert a positive integer, then print all numbers from 1 to 
    that number. 
    Example:
    Input: 6
    Output: 1, 2, 3, 4, 5, 6
*/

//Console.Write("Enter a positive integer: ");
//string input = Console.ReadLine()!;
//int number;
//while (!int.TryParse(input, out number) || String.IsNullOrWhiteSpace(input) || number <= 0)
//{
//    Console.Write("Invalid Input. Please Enter a positive number!: ");
//    input = Console.ReadLine()!;
//}

//Console.WriteLine($"\nNumbers from 1 to {number}:");
//for (int i = 1; i <= number; i++)
//{
//    Console.Write($"{i}");
//    if (i < number)
//        Console.Write(", ");
//}

#endregion

#region Program to Display Multiplication Table
/*
    Write a program that allows the user to insert an integer, then print the multiplication table for 
    that number up to 12 times. 
    Example:
    Input: 7
    Output: 7, 14, 21, 28, 35, 42, 49, 56, 63, 70, 77, 84
*/

//Console.Write("Enter an integer: ");
//string input = Console.ReadLine()!;
//int number;
//while (!int.TryParse(input, out number) || String.IsNullOrWhiteSpace(input))
//{
//    Console.Write("Invalid Input. Please Enter a number!: ");
//    input = Console.ReadLine()!;
//}

//Console.WriteLine($"\nMultiplication table for {number}:");
//for (int i = 1; i <= 12; i++)
//{
//    Console.Write($"{number * i}");
//    if (i < 12)
//        Console.Write(", ");
//}

#endregion

#region Program to List Even Numbers
/*
    Write a program that allows the user to insert a number, then print all even numbers between 1 
    and that number. 
    Example:
    Input: 16
    Output: 2, 4, 6, 8, 10, 12, 14, 16
*/

//Console.Write("Enter a positive integer: ");
//string input = Console.ReadLine()!;
//int number;
//while (!int.TryParse(input, out number) || String.IsNullOrWhiteSpace(input) || number <= 0)
//{
//    Console.Write("Invalid Input. Please Enter a positive number!: ");
//    input = Console.ReadLine()!;
//}

//Console.WriteLine($"\nEven numbers from 1 to {number}:");
//bool hasEven = false;
//for (int i = 2; i <= number; i += 2)
//{
//    Console.Write($"{i}");
//    if (i + 2 <= number)
//        Console.Write(", ");
//    hasEven = true;
//}
//if (!hasEven)
//    Console.Write("No even numbers found.");

#endregion

#region Program to Compute Exponentiation
/*
    Write a program that takes two integers, then prints the result of raising the first number to the 
    power of the second number. 
    Example:
    Input: 3, 4
    Output: 81
    Hint:
    Calculate 34 = 3×3×3×3 = 813 ^ 4 = 3 \times 3 \times 3 \times 3 = 8134=3×3×3×3=81
*/

//Console.Write("Enter the base integer: ");
//string inputBase = Console.ReadLine()!;
//int baseNum;
//while (!int.TryParse(inputBase, out baseNum) || String.IsNullOrWhiteSpace(inputBase))
//{
//    Console.Write("Invalid Input. Please Enter a number!: ");
//    inputBase = Console.ReadLine()!;
//}

//Console.Write("Enter the exponent (non-negative integer): ");
//string inputExponent = Console.ReadLine()!;
//int exponent;
//while (!int.TryParse(inputExponent, out exponent) || String.IsNullOrWhiteSpace(inputExponent) || exponent < 0)
//{
//    Console.Write("Invalid Input. Please Enter a non-negative number!: ");
//    inputExponent = Console.ReadLine()!;
//}

//long result = (long)Math.Pow(baseNum, exponent);
//Console.WriteLine($"\n{baseNum} raised to the power of {exponent} = {result}");

#endregion

#region Program to Reverse a Text String
/*
    Write a program that allows the user to enter a string and then prints the string in reverse order. 
    Example:
    Input: "Hello"
    Output: "olleH"
*/

//Console.Write("Enter a string (or press Enter for null): ");
//string input;
//while (String.IsNullOrWhiteSpace(input = Console.ReadLine()!))
//{
//    Console.Write("Invalid Input. Please Enter a valid string!: ");
//}

//Console.WriteLine($"\nReversed string: {new string(input.Reverse().ToArray())}");

#endregion

#region Program to Reverse an Integer Value
/*
    Write a program that allows the user to enter an integer and then prints the integer with its digits 
    in reverse order. 
    Example:
    Input: 12345
    Output: 54321
*/

//Console.Write("Enter an integer: ");
//string input = Console.ReadLine()!;
//int number;
//while (!int.TryParse(input, out number) || String.IsNullOrWhiteSpace(input))
//{
//    Console.Write("Invalid Input. Please Enter a number!: ");
//    input = Console.ReadLine()!;
//}

//string numberString = Math.Abs(number).ToString();

//var reversedNumberString = numberString.Reverse().ToArray();
//int reversedNumber = int.Parse(reversedNumberString) * (number < 0 ? -1 : 1); // Restore sign
//Console.WriteLine($"\nReversed integer: {reversedNumber}");

#endregion

#region Program to Find Longest Distance Between Matching Elements
/*
    Consider an array of integers with size NNN. For example: 
    7,0,0,0,0,5,6,7,5,0,7,5,37, 0, 0, 0, 0, 5, 6, 7, 5, 0, 7, 5, 37,0,0,0,0,5,6,7,5,0,7,5,3

    Write a program to find the longest distance between two identical elements in the array. 
    The distance is the count of cells between the two elements. 

    Example:
    In the example above, the longest distance is between the first 7 and the 11th 7, with a distance 
    of 9 cells. 

    Note:
    Array values will be taken from the user. 

*/

//Console.Write("Enter the size of the array (positive integer): ");
//string inputSize = Console.ReadLine()!;
//int size;
//while (!int.TryParse(inputSize, out size) || String.IsNullOrWhiteSpace(inputSize) || size <= 0)
//{
//    Console.Write("Invalid Input. Please Enter a positive number!: ");
//    inputSize = Console.ReadLine()!;
//}

//int[] array = new int[size];
//for (int i = 0; i < size; i++)
//{
//    Console.Write($"Enter integer for index {i}: ");
//    string input = Console.ReadLine()!;
//    int value;
//    while (!int.TryParse(input, out value) || String.IsNullOrWhiteSpace(input))
//    {
//        Console.Write($"Invalid Input. Please Enter a number for index {i}: ");
//        input = Console.ReadLine()!;
//    }
//    array[i] = value;
//}

//int maxDistance = -1;
//Dictionary<int, int> firstIndex = new Dictionary<int, int>();

//for (int i = 0; i < array.Length; i++)
//{
//    int num = array[i];
//    if (firstIndex.ContainsKey(num))
//    {
//        int distance = i - firstIndex[num] - 1;
//        if (distance > maxDistance)
//        {
//            maxDistance = distance;
//        }
//    }
//    else
//    {
//        firstIndex[num] = i;
//    }
//}

//Console.WriteLine($"\nArray: [{string.Join(", ", array)}]");
//Console.WriteLine(maxDistance >= 0
//    ? $"Longest distance between matching elements: {maxDistance}"
//    : "No matching elements found.");

#endregion

#region Program to Reverse Words in a Sentence
/*
    Given a sentence with space-separated words, write a program to reverse the order of the words. 

    Example:
    Input: English is great
    Output: great is English
    
    Note:
    Use the Split function. 
    The output should be a single Console.WriteLine statement. 
*/

//Console.Write("Enter a sentence to reverse: ");
//string input;
//while (String.IsNullOrWhiteSpace(input = Console.ReadLine()!))
//{
//    Console.Write("Invalid Input. Please Enter a valid string!: ");
//}

//string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
//Array.Reverse(words);
//Console.WriteLine(string.Join(" ", words));

#endregion

Console.ReadKey();
