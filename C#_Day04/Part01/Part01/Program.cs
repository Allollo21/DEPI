// Top - Level statement to save some space 

#region Problem: Write a program that: 
/*
    o Initializes a one-dimensional array in three different ways (new int[size],
      initializer list, and Array syntax sugar). 
    o Assigns values to each element in the array and prints them. 
    o Demonstrates an IndexOutOfRangeException. 
*/

//int[] NumsOne = new int[3];
//NumsOne[0] = 1; NumsOne[1] = 2; NumsOne[2] = 3;

//int[] NumsTwo = new int[] {4, 5, 6};

//int[] NumsThree = {7, 8, 9};

//PrintArray(NumsOne);
//PrintArray(NumsTwo);
//PrintArray(NumsThree);

//static void PrintArray(int[] Array)
//{
//    foreach (int value in Array)
//    {
//        Console.Write($"{value} ");
//    }

//    Console.WriteLine();
//}

//try
//{
//    int value = NumsTwo[5];
//    Console.WriteLine(value);
//}
//catch (IndexOutOfRangeException e)
//{
//    Console.WriteLine($"Error: {e.Message}");
//}

// Question: What is the default value assigned to array elements in C#? 

/*
 * Default value assigned to array elements depends on the data type. 
 * For numeric values (int, double, float, etc.) the default value is 0.
 * For reference types (string or custom objects), the default value is null.
 * For bool arrays, the default is false
 * .
 */
#endregion

#region Problem: Write a program to:
/*
    o Create two arrays (arr1 and arr2). 
    o Perform a shallow copy and demonstrate how modifying one affects the other. 
    o Perform a deep copy using the Clone method and show that modifications do not 
      affect the copied array. 
 */

//int[] ArrayOne = { 1, 2, 3 };
//int[] ArrayTwo = { 4, 5, 6 };

//Console.WriteLine("Original arrays:");
//Console.WriteLine($"ArrayOne: {string.Join(", ", ArrayOne)}");
//Console.WriteLine($"ArrayTwo: {string.Join(", ", ArrayTwo)}\n");


//ArrayTwo = ArrayOne;
//ArrayOne[0] = 99;
//Console.WriteLine("After modifying ArrayOne[0] (Shallow Copy):");
//Console.WriteLine($"ArrayOne: {string.Join(", ", ArrayOne)}");
//Console.WriteLine($"ArrayTwo: {string.Join(", ", ArrayTwo)}\n");


//ArrayOne = new int[] { 1, 2, 3 };
//ArrayTwo = new int[] { 4, 5, 6 };


//ArrayTwo = (int[])ArrayOne.Clone();
//ArrayOne[0] = 100;

//Console.WriteLine("After modifying ArrayOne[0] (Deep Copy):");
//Console.WriteLine($"ArrayOne: {string.Join(", ", ArrayOne)}");
//Console.WriteLine($"ArrayTwo: {string.Join(", ", ArrayTwo)}\n");

// Question: What is the difference between Array.Clone() and Array.Copy() ?

/*
 * Array.Colne(): Creates a new array object and copies the entire array to the new one,
 *                Returns object type so it must be casted to array type.
 *                
 * Array.Copy(): Copies a range of elements from an array to another and this range could be the whole array.
 *               Needs to specify the source and destination arrays and the length of the elements to be
 *               copied. It does not return an object but modifies the destination directly.
 */

#endregion

#region Problem: Write a program to: 
/*
    o Create a 2D array with student grades (3 students, 3 subjects each). 
    o Take input from the user to fill the array. 
    o Print the grades for each student using nested loops. 
 */

//int[,] Grades = new int[3,3];

//for (int i = 0; i < Grades.GetLength(0); i++)
//{
//    for (int j = 0; j < Grades.GetLength(1); j++)
//    {
//        Console.Write($"Enter Student No. {i + 1}'s Subject No.{j + 1}'s Grade: ");
//        string input = Console.ReadLine()!;
//        int value;
//        while (!int.TryParse(input, out value) || String.IsNullOrWhiteSpace(input) || value < 0)
//        {
//            Console.Write("Inalid Input. Please Enter a valid grade!: ");
//            input = Console.ReadLine()!;
//        }

//        Grades[i, j] = value;
//    }
//}

//for (int i = 0; i < Grades.GetLength(0); i++)
//{
//    for (int j = 0; j < Grades.GetLength(1); j++)
//    {
//        Console.WriteLine($"Student No. {i + 1}'s Subject No.{j + 1}'s Grade -> {Grades[i, j]}");
//    }
//}

// Question: What is the difference between GetLength() and Length for multi-dimensional arrays

/*
 * Length function returns the total number of elements of a multi-dimensional array so in the previous
 * code the Length would return 3 x 3 = 9.
 * 
 * While GetLength() returns the size of a specific dimension so takes 0 to return the number of rows
 * and takes 1 to return the number of columns.
 * 
 */

#endregion

#region Problem: Write a program that: 
/*
    o Demonstrates at least 5 array methods (Sort, Reverse, IndexOf, Copy, Clear). 
    o Explains the changes before and after applying each method. 
 */

//int[] original = { 3, 1, 4, 1, 5 };
//Console.WriteLine($"Original array: {string.Join(", ", original)}\n");

//int[] TemporaryArray = (int[])original.Clone();
//Array.Sort(TemporaryArray);
//Console.WriteLine($"After Sort: {string.Join(", ", TemporaryArray)}\n");

//TemporaryArray = (int[])original.Clone();
//Array.Reverse(TemporaryArray);
//Console.WriteLine($"After Reverse: {string.Join(", ", TemporaryArray)}\n");

//int index = Array.IndexOf(original, 1);
//Console.WriteLine($"Index (1) of the original array: {index}\n");

//TemporaryArray = new int[5];
//Array.Copy(original, 1, TemporaryArray, 0, 3);
//Console.WriteLine($"After Copying elements 1-3 from original to array of zeros: {string.Join(", ", TemporaryArray)}\n");

//TemporaryArray = (int[])original.Clone();
//Array.Clear(TemporaryArray);
//Console.WriteLine($"After Clear: {string.Join(", ", TemporaryArray)}");

// Question: What is the difference between Array.Copy() and Array.ConstrainedCopy() ?

/*
 * ConstrainedCopy is safer for overlapping arrays and stricter about type compatibility,
 * While Copy is faster but less strict and may produce unexpected results with overlaps.
 */
#endregion

#region Problem: Create a program that: 
/*
    o Uses a for loop to print all elements of a 1D array. 
    o Uses a foreach loop to print all elements of the same array. 
    o Uses a while loop to print all elements in reverse order. 
 */

//int[] arr = { 1, 2, 3, 4, 5 };

//Console.Write("Using for loop: ");
//for (int i = 0; i < arr.Length; i++)
//{
//    Console.Write($"{arr[i]} ");
//}

//Console.Write("\nUsing foreach loop: ");
//foreach (int element in arr)
//{
//    Console.Write($"{element} ");
//}

//Console.Write("\nUsing while loop (reverse order): ");
//int index = arr.Length - 1;
//while (index >= 0)
//{
//    Console.Write($"{arr[index]} ");
//    index--;
//}

// Question: Why is foreach preferred for read - only operations on arrays ?

/*
 * As it is simpler and more readable than any other loop. It eliminates the need of manual index management.
 * So it might prevent errors like IndexOutOfRange exceptions. Besides, it directly accesses elements without
 * index calcualtion (uses iterators) which might be a bit efficient for reading tasks.
 * 
 */
#endregion

#region Problem: Write a program that: 
/*
    o Repeatedly asks the user for a positive odd number. 
    o Uses defensive coding to validate input using int.TryParse and a do-while loop.
*/

//int Num;
//bool flag;
//do
//{
//    Console.Write("Enter odd number: ");
//    flag = int.TryParse(Console.ReadLine(), out Num);
//}
//while (Num % 2 == 0 || !flag || Num < 0);

// Question: Why is input validation important when working with user inputs?

/*
 * Ensures data integrity through filtering out invalid data to maintain accurate and reliable results.
 * Avoids runtime crashes or unexpected behavior from improper input.
 * Improves user experience with clear error messages to provide correct input.
 * Protects against malicious input that could exploit system vulnerabilities such as SQL Injection.
 */
#endregion

#region Problem: Write a program to: 
/*
    o Create a 2D array with fixed values. 
    o Print the array elements in a matrix format (rows and columns). 
 */

//int[,] matrix = { { 10, 20, 30 }, { 40, 50, 60 }, { 70, 80, 90 }};

//Console.WriteLine("Matrix:");
//for (int i = 0; i < matrix.GetLength(0); i++)
//{
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//        Console.Write($"{matrix[i, j], 4}");
//    }
//    Console.WriteLine();
//}

// Question: How can you format the output of a 2D array for better readability? 

/*
 * Use {value,4} in Console.Write to align numbers in columns (4 spaces per number).
 * Add Console.WriteLine() after each row to create a clear matrix layout.
 */
#endregion

#region Problem: Write a program that: 
/*
    o Asks the user to enter a month number. 
    o Uses an if-else statement to determine the month name. 
    o Uses a switch statement to perform the same task. 
 */

//Console.Write("Enter a month number (1-12): ");
//string input = Console.ReadLine()!;
//int month;
//while (!int.TryParse(input, out month) || month < 1 || month > 12)
//{
//    Console.WriteLine("Invalid input. Please enter a number between 1 and 12:");
//    input = Console.ReadLine()!;
//}

//Console.WriteLine("\nUsing if else:");
//string MonthNameIfElse;
//if (month == 1) MonthNameIfElse = "January";
//else if (month == 2) MonthNameIfElse = "February";
//else if (month == 3) MonthNameIfElse = "March";
//else if (month == 4) MonthNameIfElse = "April";
//else if (month == 5) MonthNameIfElse = "May";
//else if (month == 6) MonthNameIfElse = "June";
//else if (month == 7) MonthNameIfElse = "July";
//else if (month == 8) MonthNameIfElse = "August";
//else if (month == 9) MonthNameIfElse = "September";
//else if (month == 10) MonthNameIfElse = "October";
//else if (month == 11) MonthNameIfElse = "November";
//else MonthNameIfElse = "December";
//Console.WriteLine($"Month: {MonthNameIfElse}");

//Console.WriteLine("\nUsing switch statement:");
//string MonthNameSwitch = month switch
//{
//    1 => "January",
//    2 => "February",
//    3 => "March",
//    4 => "April",
//    5 => "May",
//    6 => "June",
//    7 => "July",
//    8 => "August",
//    9 => "September",
//    10 => "October",
//    11 => "November",
//    12 => "December",
//    _ => "Invalid"
//};
//Console.WriteLine($"Month: {MonthNameSwitch}");

// Question: When should you prefer a switch statement over if-else? 

/*
 * Switch is ideal for checking one variable against discrete values as it’s more concise and readable
 * than multiple if-else conditions.
 * 
 * For many cases, switch can be optimized by compilers (using jump tables), offering better performance
 * than sequential if-else checks, though this is less significant in modern systems.
 * 
 * Adding or modifying cases in a switch is straightforward, but if-else chains can become
 * difficult with many conditions.
 */
#endregion

#region Problem: Write a program to: 
/*
    o Sort an array of integers using Array.Sort().
    o Search for a specific value using Array.IndexOf() and Array.LastIndexOf().
 */

//int[] numbers = { 5, 2, 8, 1, 9, 2, 3, 5 };

//Console.WriteLine($"Original array: {string.Join(", ", numbers)}\n");

//Array.Sort(numbers);
//Console.WriteLine($"Sorted array: {string.Join(", ", numbers)}\n");

//Console.Write("Enter a number to search for: ");
//string input = Console.ReadLine()!;
//int SearchValue;
//while (!int.TryParse(input, out SearchValue))
//{
//    Console.Write("Invalid input. Please enter a valid integer: ");
//    input = Console.ReadLine()!;
//}

//int FirstIndex = Array.IndexOf(numbers, SearchValue);
//Console.WriteLine(FirstIndex >= 0
//    ? $"First occurrence of {SearchValue} is at index {FirstIndex}"
//    : $"{SearchValue} not found in the array");

//int LastIndex = Array.LastIndexOf(numbers, SearchValue);
//Console.WriteLine(LastIndex >= 0
//    ? $"Last occurrence of {SearchValue} is at index {LastIndex}"
//    : $"{SearchValue} not found in the array");

// Question: What is the time complexity of Array.Sort()? 

/*  
 * The time complexity of Array.Sort() is O(n log n) at the average case which can degrade to O(n²)
 * that is because it internally implements QuickSort().
 * 
 */
#endregion

#region Problem: Write a program that: 
/*
    o Creates an array of integers. 
    o Uses a for loop to calculate and print the sum of all elements. 
    o Uses a foreach loop to calculate the same sum. 
 */

//int[] numbers = { 5, 10, 15, 20, 25 };

//int ForSum = 0;
//for (int i = 0; i < numbers.Length; i++)
//{
//    ForSum += numbers[i];
//}
//Console.WriteLine($"Sum using for loop: {ForSum}");

//int ForeachSum = 0;
//foreach (int num in numbers)
//{
//    ForeachSum += num;
//}
//Console.WriteLine($"Sum using foreach loop: {ForeachSum}");

// Question: Which loop(for or foreach) is more efficient for calculating the sum of an array, and why ?

/*
 * They are similar as they both loop O(n), But with for accessing elements using indexing while foreach
 * using iteration mechanism which might in rare cases cause foreach to be a bit slower because of the 
 * iteration setup.
 * 
 */
#endregion

Console.ReadKey();