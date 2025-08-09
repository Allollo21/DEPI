// Top - Level statement to save some space 

#region Problem: Write a program that:
/*
    o Reads two integers from the user and divides them.
    o Catches DivideByZeroException and displays an appropriate message.
    o Uses a finally block to print "Operation complete" regardless of success or failure.
*/

//try
//{
//    Console.Write("Enter the first integer: ");
//    string input1 = Console.ReadLine()!;
//    int num1;

//    while (!int.TryParse(input1, out num1) || String.IsNullOrWhiteSpace(input1))
//    {
//        Console.Write("Inalid Input. Please Enter a number!: ");
//        input1 = Console.ReadLine()!;
//    }

//    Console.Write("Enter the second integer: ");
//    string input2 = Console.ReadLine()!;
//    int num2;

//    while (!int.TryParse(input2, out num2) || String.IsNullOrWhiteSpace(input2) || num2 == 0)
//    {
//        Console.Write("Inalid Input. Please Enter a number!: ");
//        input2 = Console.ReadLine()!;
//    }

//    double result = num1 / num2;
//    Console.WriteLine($"Result of {num1} / {num2} = {result}");
//}
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine($"Error: {ex.Message}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Error: {ex.Message}");
//}
//finally
//{
//    Console.WriteLine("Operation complete");
//}

// Question: What is the purpose of the finally block?
/*
 * The finally block ensures that its code executes regardless of whether an exception occurs 
 * or the try block completes successfully.
 * 
 * It is typically used for cleanup tasks, such as closing files, releasing resources, 
 * or logging, to guarantee they happen even if an error is thrown or the program exits the try block early.
 */
#endregion

#region Problem: Modify the TestDefensiveCode method in demo to: 
/*
    o Accept only positive integers for both X and Y. 
    o Ensure Y is greater than 1.
*/

//TestDefensiveCode();
//static void TestDefensiveCode()
//{
//    int x, y;

//    Console.Write("Enter a positive integer for X: ");
//    string inputX = Console.ReadLine()!;
//    while (!int.TryParse(inputX, out x) || String.IsNullOrWhiteSpace(inputX) || x <= 0)
//    {
//        Console.Write("Invalid Input. Please Enter a positive integer for X: ");
//        inputX = Console.ReadLine()!;
//    }

//    Console.Write("Enter a positive integer for Y (greater than 1): ");
//    string inputY = Console.ReadLine()!;
//    while (!int.TryParse(inputY, out y) || String.IsNullOrWhiteSpace(inputY) || y <= 0 || y <= 1)
//    {
//        Console.Write("Invalid Input. Please Enter a positive integer for Y greater than 1: ");
//        inputY = Console.ReadLine()!;
//    }

//    Console.WriteLine($"Valid inputs received: X = {x}, Y = {y}");
//}

// Question: How does int.TryParse() improve program robustness compared to int.Parse()?

/*
 * int.TryParse() improves program robustness by safely attempting to convert a string to an integer
 * without throwing an exception if the conversion fails.
 * 
 * It returns a boolean indicating success or failure and outputs the result via an out parameter,
 * allowing the program to handle invalid input gracefully with custom error messages or repeated prompts
 * 
 */
#endregion

#region  Problem: Write a program that:
/*
    o Declares a nullable integer. 
    o Uses the null-coalescing operator (??) to assign a default value if the variable is null. 
    o Demonstrates the difference between using HasValue and Value properties.
*/

//int? nullableInt = null;
//Console.Write("Enter an integer (or press Enter for null): ");
//string input = Console.ReadLine()!;
//while (!String.IsNullOrWhiteSpace(input) && !int.TryParse(input, out int temp))
//{
//    Console.Write("Invalid Input. Please Enter a number or press Enter for null: ");
//    input = Console.ReadLine()!;
//}
//if (!String.IsNullOrWhiteSpace(input))
//{
//    nullableInt = int.Parse(input);
//}

//Console.WriteLine($"\nNullable integer HasValue: {nullableInt.HasValue}");
//if (nullableInt.HasValue)
//{
//    Console.WriteLine($"Nullable integer Value: {nullableInt.Value}");
//}
//else
//{
//    Console.WriteLine("Nullable integer is null, cannot access Value.");
//}

//int result = nullableInt ?? 27;
//Console.WriteLine($"Value after null-coalescing (default 27): {result}");

// Question: What exception occurs when trying to access Value on a null Nullable<T>? 

/*
 * Attempting to access the Value property of a null Nullable<T> 
 * throws an InvalidOperationException.
 * 
 * This exception occurs because the Value property can only be accessed when
 * the nullable object has a value, as indicated by the HasValue property being true
 */
#endregion

#region Problem: Create a program to: 
/*
    o Declare a 1D array of size 5. 
    o Try accessing an index out of bounds and handle the IndexOutOfRangeException. 
*/

//try
//{
//    int[] array = new int[5] { 0, 1, 2, 3, 4 };

//    Console.Write("Enter an index to access the array (0-4): ");
//    string input = Console.ReadLine()!;
//    int index;
//    while (!int.TryParse(input, out index) || String.IsNullOrWhiteSpace(input))
//    {
//        Console.Write("Invalid Input. Please Enter a number!: ");
//        input = Console.ReadLine()!;
//    }

//    int value = array[index];
//    Console.WriteLine($"Value at index {index}: {value}");
//}
//catch (IndexOutOfRangeException ex)
//{
//    Console.WriteLine($"Error: {ex.Message}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Error: {ex.Message}");
//}

// Question: Why is it necessary to check array bounds before accessing elements? 

/*
 * Checking array bounds before accessing elements is necessary to prevent
 * IndexOutOfRangeException, which occurs when an attempt is made to access an
 * index outside the array's valid range
 */

#endregion

#region Problem: Write a program that: 
/*
    o Creates a 3x3 array with user-provided values. 
    o Calculates and prints the sum of elements in each row and column. 
*/

//int[,] array = new int[3, 3];

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        Console.Write($"Enter value for cell[{i}, {j}]: ");
//        string input = Console.ReadLine()!;
//        int value;
//        while (!int.TryParse(input, out value) || String.IsNullOrWhiteSpace(input))
//        {
//            Console.Write($"Invalid Input. Please Enter a number for cell[{i},{j}]: ");
//            input = Console.ReadLine()!;
//        }

//        array[i, j] = value;
//    }
//}

//Console.WriteLine("\nArray:");
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        Console.Write($"{array[i, j],4}");
//    }
//    Console.WriteLine();
//}

//Console.WriteLine("\nSum of each row:");
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    int RowSum = 0;
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        RowSum += array[i, j];
//    }
//    Console.WriteLine($"Row {i + 1}: {RowSum}");
//}

//Console.WriteLine("\nSum of each column:");
//for (int j = 0; j < array.GetLength(1); j++)
//{
//    int ColSum = 0;
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//        ColSum += array[i, j];
//    }
//    Console.WriteLine($"Column {j + 1}: {ColSum}");
//}

// Question: How is the GetLength(dimension)method used in multi-dimensional arrays? 

/*
 * The GetLength(dimension) method in multi-dimensional arrays returns the size of
 * the specified dimension.
 * 
 * For a 2D array, GetLength(0) returns the number of rows,
 * and GetLength(1) returns the number of columns.
 */
#endregion

#region Problem: Write a program that: 
/*
    o Creates a jagged array with three rows of varying sizes. 
    o Populates each row with user input. 
    o Prints all values row by row.
*/

//int[][] jaggedArray = new int[3][];

//int[] rowSizes = new int[3];
//for (int i = 0; i < 3; i++)
//{
//    Console.Write($"Enter the size for row {i + 1} (positive integer): ");
//    string input = Console.ReadLine()!;
//    while (!int.TryParse(input, out rowSizes[i]) || String.IsNullOrWhiteSpace(input) || rowSizes[i] <= 0)
//    {
//        Console.Write($"Invalid Input. Please Enter a positive number for row {i + 1} size: ");
//        input = Console.ReadLine()!;
//    }
//}

//for (int i = 0; i < 3; i++)
//{
//    jaggedArray[i] = new int[rowSizes[i]];
//    for (int j = 0; j < rowSizes[i]; j++)
//    {
//        Console.Write($"Enter value for jaggedArray[{i}][{j}]: ");
//        string input = Console.ReadLine()!;
//        int value;
//        while (!int.TryParse(input, out value) || String.IsNullOrWhiteSpace(input))
//        {
//            Console.Write($"Invalid Input. Please Enter a number for jaggedArray[{i}][{j}]: ");
//            input = Console.ReadLine()!;
//        }
//        jaggedArray[i][j] = value;
//    }
//}

//Console.WriteLine("\nJagged Array Contents:");
//for (int i = 0; i < jaggedArray.Length; i++)
//{
//    for (int j = 0; j < jaggedArray[i].Length; j++)
//    {
//        Console.Write($"{jaggedArray[i][j],4}");
//    }
//    Console.WriteLine();
//}

/* Question: How does the memory allocation differ between jagged arrays and 
 * rectangular arrays?
 */

/*
 * Jagged arrays allow variable row lengths with separate allocations for each row,
 * leading to flexibility but potential memory fragmentation.
 * 
 * Rectangular arrays use a single contiguous block, which is more memory-efficient
 * for fixed-size data but less flexible.
 */
#endregion

#region Problem: Demonstrate the use of nullable reference types by:
/*
    o Declaring a nullable string. 
    o Assigning it a value conditionally based on user input. 
    o Using the null-forgiveness operator (!) to suppress warnings. 
*/

//try
//{
//    string? nullableString = null;
//    int choice;

//    Console.Write("Enter 1 to assign a string, or any other number to keep it null: ");
//    string input = Console.ReadLine()!;
//    while (!int.TryParse(input, out choice) || String.IsNullOrWhiteSpace(input))
//    {
//        Console.Write("Invalid Input. Please Enter a number!: ");
//        input = Console.ReadLine()!;
//    }

//    if (choice == 1)
//    {
//        Console.Write("Enter a string value: ");
//        ;

//        while (String.IsNullOrWhiteSpace(nullableString = Console.ReadLine()!))
//        {
//            Console.Write("Invalid Input. Please Enter a non-empty string: ");
//        }
//    }


//    int length = nullableString != null ? nullableString.Length : 0;

//    int lengthWithForgiveness = nullableString!.Length;

//    Console.WriteLine($"\nNullable string value: {(nullableString ?? "null")}");
//    Console.WriteLine($"Length using null check: {length}");
//    Console.WriteLine($"Length using null-forgiveness operator: {lengthWithForgiveness}");
//}
//catch (NullReferenceException ex)
//{
//    Console.WriteLine($"Error: {ex.Message}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Error: {ex.Message}");
//}

// Question: What is the purpose of nullable reference types in C#? 

/*
 * Nullable reference types help developers avoid null reference exceptions by making the nullability 
 * of reference types explicit.
 * 
 * This encourages explicit null handling, improving code safety and reducing runtime 
 * NullReferenceException errors.
 * 
 */
#endregion

#region Problem: Write a program that: 
/*
    o Demonstrates boxing by assigning a value type to an object. 
    o Demonstrates unboxing and checks for invalid cast exceptions. 
*/


//int value = 7;

//object boxed = value;
//Console.WriteLine($"Boxed value: {boxed} (Type: {boxed.GetType()})");

//int unboxed = (int)boxed;
//Console.WriteLine($"Unboxed value: {unboxed} (Type: {unboxed.GetType()})");

//try
//{
//    string invalidUnbox = (string)boxed;
//    Console.WriteLine($"Unboxed value: {invalidUnbox}");
//}
//catch (InvalidCastException ex)
//{
//    Console.WriteLine($"Invalid unboxing error: {ex.Message}");
//}

// Question: What is the performance impact of boxing and unboxing in C#?

/*
 * Frequent boxing and unboxing, especially in tight loops or large collections, 
 * can degrade performance due to increased memory usage and CPU cycles.
 * 
 * Using generics (e.g., List<int> instead of ArrayList) or value types directly avoids this overhead,
 * improving efficiency.
 */
#endregion

#region Problem: Write a method SumAndMultiply that: 
/*
    o Accepts two integers and calculates their sum and product using out parameters.
    o Calls the method and prints the results. 
*/

//int num1, num2;

//Console.Write("Enter the first integer: ");
//string input1 = Console.ReadLine()!;
//while (!int.TryParse(input1, out num1) || String.IsNullOrWhiteSpace(input1))
//{
//    Console.Write("Invalid Input. Please Enter a number!: ");
//    input1 = Console.ReadLine()!;
//}

//Console.Write("Enter the second integer: ");
//string input2 = Console.ReadLine()!;
//while (!int.TryParse(input2, out num2) || String.IsNullOrWhiteSpace(input2))
//{
//    Console.Write("Invalid Input. Please Enter a number!: ");
//    input2 = Console.ReadLine()!;
//}

//SumAndMultiply(num1, num2, out int sum, out int product);

//Console.WriteLine($"\nSum of {num1} and {num2} = {sum}");
//Console.WriteLine($"Product of {num1} and {num2} = {product}");

//static void SumAndMultiply(int a, int b, out int sum, out int product)
//{
//    sum = a + b;
//    product = a * b;
//}

// Question: Why must out parameters be initialized inside the method? 

/*
 * out parameters must be initialized inside the method because C# requires that an out parameter
 * be assigned a value before the method returns, ensuring the caller receives a valid result.
 * Unlike ref parameters, which must be initialized before being passed
 * 
 */
#endregion

#region Problem: Create a method that: 
/*
    o Accepts a string and an optional integer (default value: 5). 
    o Prints the string the specified number of times. 
    o Demonstrates the use of named parameters. 
*/


//Console.Write("Enter a string to print: ");
//string inputString;
//while (String.IsNullOrWhiteSpace(inputString = Console.ReadLine()!))
//{
//    Console.Write("Invalid Input. Please Enter a non-empty string: ");
//}

//Console.Write("Enter the number of times to print (or press Enter for default 5): ");
//string inputCount = Console.ReadLine()!;
//int count;
//while (!String.IsNullOrWhiteSpace(inputCount) && !int.TryParse(inputCount, out count))
//{
//    Console.Write("Invalid Input. Please Enter a number or press Enter for default 5: ");
//    inputCount = Console.ReadLine()!;
//}

//count = String.IsNullOrWhiteSpace(inputCount) ? 5 : int.Parse(inputCount);

//Console.WriteLine("\nUsing default parameter order:");
//PrintString(inputString, count);

//Console.WriteLine("\nUsing named parameters:");
//PrintString(times: count, text: inputString);

//static void PrintString(string text, int times = 5)
//{
//    for (int i = 0; i < times; i++)
//    {
//        Console.WriteLine(text);
//    }
//}

// Question: Why must optional parameters always appear at the end of a method's parameter list? 

/*
 * Optional parameters must appear at the end of a method's parameter list in C# to avoid ambiguity
 * during method calls.
 * 
 * When a method is called, C# matches arguments to parameters based on their position or names.
 * If optional parameters were allowed before required parameters, the compiler could struggle to
 * determine which arguments correspond to which parameters when some are omitted.
 * 
 */
#endregion

#region Problem: Write a program that: 
/*
    o Declares a nullable integer array. 
    o Uses the null propagation operator (?.) to safely access its properties. 
*/

//int[]? array = null;

//Console.Write("Enter 1 to create an array, or any other number to keep it null: ");
//string inputChoice = Console.ReadLine()!;
//int choice;
//while (!int.TryParse(inputChoice, out choice) || String.IsNullOrWhiteSpace(inputChoice))
//{
//    Console.Write("Invalid Input. Please Enter a number!: ");
//    inputChoice = Console.ReadLine()!;
//}

//if (choice == 1)
//{
//    Console.Write("Enter the size of the array (positive integer): ");
//    string inputSize = Console.ReadLine()!;
//    int size;
//    while (!int.TryParse(inputSize, out size) || String.IsNullOrWhiteSpace(inputSize) || size <= 0)
//    {
//        Console.Write("Invalid Input. Please Enter a positive number for array size: ");
//        inputSize = Console.ReadLine()!;
//    }

//    array = new int[size];
//    for (int i = 0; i < size; i++)
//    {
//        Console.Write($"Enter integer for index {i} (or press Enter for 0): ");
//        string inputElement = Console.ReadLine()!;
//        while (!String.IsNullOrWhiteSpace(inputElement) && !int.TryParse(inputElement, out int value))
//        {
//            Console.Write($"Invalid Input. Please Enter a number for index {i} or press Enter for 0: ");
//            inputElement = Console.ReadLine()!;
//        }
//        array[i] = String.IsNullOrWhiteSpace(inputElement) ? 0 : int.Parse(inputElement);
//    }
//}

//int? length = array?.Length;
//Console.WriteLine($"\nArray length (using null propagation): {(length.HasValue ? length.Value.ToString() : "null")}");

//Console.WriteLine("Array contents:");
//if (array?.Length > 0)
//{
//    for (int i = 0; i < array.Length; i++)
//    {
//        Console.Write($"{array[i]} ");
//    }
//    Console.WriteLine();
//}
//else
//{
//    Console.WriteLine("Array is null or empty.");
//}

// Question: How does the null propagation operator prevent NullReferenceException? 

/*
 * The null propagation operator (?.) in C# prevents NullReferenceException by checking if an object is null
 * before accessing its properties or methods.
 * If the object is null, the expression evaluates to null instead of attempting the access,
 * avoiding the exception.
 */
#endregion

#region Problem: Write a program that: 
/*
    o Asks the user to enter a day of the week. 
    o Uses a switch expression to map the day to its corresponding number (e.g., "Monday" -> 1).
*/

//Console.Write("Enter a day of the week (or press Enter for null): ");
//string? inputDay = Console.ReadLine()!;
//if (String.IsNullOrWhiteSpace(inputDay))
//{
//    inputDay = null;
//}

//int dayNumber = inputDay?.ToLower() switch
//{
//    "monday" => 1,
//    "tuesday" => 2,
//    "wednesday" => 3,
//    "thursday" => 4,
//    "friday" => 5,
//    "saturday" => 6,
//    "sunday" => 7,
//    _ => 0
//};

//Console.WriteLine($"\nDay number: {(dayNumber == 0 ? "Wrong input" : dayNumber)}");

// Question: When is a switch expression preferred over a traditional if statement?

/*
 * A switch expression is preferred over a traditional if statement when:
 * 
 * You need to map a single input to one of several possible outcomes,
 * as switch expressions provide a concise, functional syntax for such mappings.
 * 
 * You want a single, expressive return value, as switch expressions evaluate to a value that can be
 * directly assigned or used, unlike if statements which require explicit variable assignments.
 * 
 * Can be optimized to achieve higher performance in som cases.
 */
#endregion

#region Problem: Write a method SumArray that:
/*
    o Accepts a variable number of integers using the params keyword.
    o Returns the sum of the provided integers. 
    o Demonstrates calling the method with both an array and individual values. 
*/

//Console.Write("Enter the number of integers to sum (positive integer): ");
//string inputSize = Console.ReadLine()!;
//int size;
//while (!int.TryParse(inputSize, out size) || String.IsNullOrWhiteSpace(inputSize) || size <= 0)
//{
//    Console.Write("Invalid Input. Please Enter a positive number!: ");
//    inputSize = Console.ReadLine()!;
//}

//int[] numbers = new int[size];
//for (int i = 0; i < size; i++)
//{
//    Console.Write($"Enter integer {i + 1}: ");
//    string input = Console.ReadLine()!;
//    int value;
//    while (!int.TryParse(input, out value) || String.IsNullOrWhiteSpace(input))
//    {
//        Console.Write($"Invalid Input. Please Enter a number for integer {i + 1}: ");
//        input = Console.ReadLine()!;
//    }
//    numbers[i] = value;
//}

//int sumFromArray = SumArray(numbers);
//Console.WriteLine($"\nSum of array = {sumFromArray}");

//int sumFromIndividual = SumArray(10, 20, 30, 40);
//Console.WriteLine($"\nSum of individual values [10, 20, 30 , 40] = {sumFromIndividual}");

//static int SumArray(params int[] numbers)
//{
//    int sum = 0;
//    foreach (int num in numbers)
//    {
//        sum += num;
//    }
//    return sum;
//}

// Question: What are the limitations of the params keyword in method definitions? 

/*
 * Only one params parameter is allowed per method, as it collects all remaining arguments into an array,
 * and multiple params would create ambiguity in argument assignment.    
 * 
 * The params parameter must be a single-dimensional array (int[], not int[,] or List<int>),
 * limiting its use to array-compatible types.
 */
#endregion

Console.ReadKey();