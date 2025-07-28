// Top - Level statement to save some space 

#region Problem: Add both single-line and multi-line comments in the following code segment explaining its purpose:

//int x = 10;
//int y = 20;
//int sum = x + y;
//Console.WriteLine(sum);

/*
int x = 10;
int y = 20;
int sum = x + y;
Console.WriteLine(sum);
*/

/*
 * Single-line comments allow developers to quickly annotate or explain a specific line of code,
 * improving readability and maintainability.
 * 
 * Multi-line comments enable detailed explanations or temporary disabling of code blocks,
 * useful for documentation or debugging.
 */

#endregion

#region Question: What is the shortcut to comment and uncomment a selected block of code in Visual Studio?

/*
 * Shortcut to comment a selected block: CTRL + K , CTRL + C
 * 
 * To uncomment: CTRL + K, CTRL + U
 * 
 */

#endregion

#region Problem: Identify and fix the errors in this code snippet: 

/*
The snippet:

    int x = "10";
    console.WriteLine(x + y);
*/


//Corrected Version:

//    int x = 10;
//    int y = x;
//    Console.WriteLine(x + y);


/*
 * Errors Fixed:
 * 
 * 1. The variable x was explicitly decalred as integer but was initialed with a string value using quotes.
 *    It was fixed by just deleting the quotes.
 *    
 * 2. The static class Console was called incorrectly with a small c. It was fixed by typing capital C as the
 *    class name should be.
 *    
 * 3. There was a non - declared variable called inside the WriteLine(). So we had to declare it using the 
 *    same value as x as an approach to fix the error.
 */

#endregion

#region Question: Explain the difference between a runtime error and a logical error with examples. 


/*
 * A runtime error occurs when a program crashes or stops running due to an issue that happens
 * while the code is executing. It stops running because it was not told how to deal with such an error.
 */

//// Divide By Zero Example
//int a = 10;
//int b = 0;
//int result = a / b; // Runtime error: DivideByZeroException
//Console.WriteLine(result);

/* 
 * A logical error occurs when a program runs successfully but produces incorrect or unexpected results
 * due to a mistake in the program’s logic or algorithm.
 */

//// Order of statements logical error example
//Console.Write("Enter the length of one side: ");
//string length = Console.ReadLine();
//Console.WriteLine("Perimeter of your square is: ");
//Console.WriteLine(perimeter); // Logical error: Uses perimeter before calculating it
//int perimeter = int.Parse(length) * 4;


/*
 * Differences
 *
 * They both happen during execution but runtime errors cause the program to crash while logical errors do not.
 * Runtime errors are easier to detect as it shows a message of the error while logical erros are hard to be discvered
 * Runtime errors are evoided using exception handling while logical erros by revising and correcting the logic.
 * 
 */

#endregion

#region Problem: Declare variables using proper naming conventions to store: 

/*
 *    Your full name. 
 *    Your age. 
 *    Your monthly salary. 
 *    Whether you are a student. 
 */

using System.Runtime.Intrinsics.X86;

string FullName = "Ali Reda Mohamed";
int Age = 21;
decimal MonthlySalary = 2500.50m;
bool IsStudent = true;

#endregion

#region Question: Why is it important to follow naming conventions such as PascalCase in C#? 

/*
 * Following naming conventions in C# ensures code readability and consistency,
 * making it easier for developers to understand and maintain code across teams.
 * 
 * So sticking into these conventions aligns with C# community standards,
 * reducing confusion and errors in collaborative projects. 
 */

#endregion

#region Problem: Write a program to demonstrate that changing the value of a reference type affects all references pointing to that object.

//Car CarOne = new Car { ModelYear = 2015, Manufacturer = "BMW" };
//Car CarTwo = CarOne;
//Console.WriteLine(CarOne); // ModelYear = 2015, Manufacturer = "BMW"
//Console.WriteLine(CarTwo); // ModelYear = 2015, Manufacturer = "BMW"
//CarTwo.ModelYear = 2022;
//CarTwo.Manufacturer = "JEEP";
//Console.WriteLine(CarOne); // ModelYear = 2022, Manufacturer = "JEEP"
//Console.WriteLine(CarTwo); // ModelYear = 2022, Manufacturer = "JEEP"

#endregion

#region Question: Explain the difference between value types and reference types in terms of memory allocation.

/*
 * Differences:
 * 
 * Value type variables stored directly on the stack while reference type data on the heap
 * and has a reference on the stack.
 * 
 * When assigned to another variable it copies the entire value (new memory location) While refernce type
 * copies only the reference (same memory location).
 * 
 * For value type variables, each variable has independent data while for reference type variables,
 * multiple variables can point to the same data.
 */

#endregion

#region Problem: Create a program that calculates the following using variables x = 15 and y = 4: 

/*
 *   o Sum 
 *   o Difference 
 *   o Product 
 *   o Division result 
 *   o Remainder 
 */

//int x = 15;
//int y = 4;

//int Sum = x + y;
//int Difference = x - y;
//int Product = x * y;
//double DivisionResult = (double) x / y;
//int Remainder = x % y;

//Console.WriteLine($"Sum of {x} and {y}: {Sum}");
//Console.WriteLine($"Difference of {x} and {y}: {Difference}");
//Console.WriteLine($"Product of {x} and {y}: {Product}");
//Console.WriteLine($"Division of {x} by {y}: {DivisionResult}");
//Console.WriteLine($"Remainder of {x} divided by {y}: {Remainder}");

#endregion

#region Question: What will be the output of the following code? Explain why: 

/*
 
 int a = 2, b = 7;
 Console.WriteLine(a % b);

 */

/*
 * The output will be 2 as the modulus operator calculates the remainder after division
 * so 2 / 7 = 0 and the remainder is 2
 */

#endregion

#region Problem: Write a program that checks if a given number is both: 

/*
 * Greater than 10. 
 * Even. 
 */

//Console.Write("Enter a number: ");
//string input = Console.ReadLine()!;
//if (!String.IsNullOrEmpty(input) && int.TryParse(input, out int number))
//{
//    string result = string.Empty;

//    if (number > 10)
//    {
//        result += $"{number} is greater than 10";
//    }
//    else
//    {
//        result += $"{number} is not greater than 10";
//    }

//    if (number % 2 == 0)
//    {
//        result += $" and it is even";
//    }
//    else
//    {
//        result += $" and it is not even";
//    }

//    Console.WriteLine(result);
//}
//else
//{
//    Console.WriteLine("Invalid input. Please enter a valid integer.");
//}

#endregion

#region Question: How does the && (logical AND) operator differ from the & (bitwise AND) operator?

/*
 * Both evaluate expressions whether true or false but logical AND has short circuiting which is if 
 * the first condition is false it will not evaluate the second expression which is faster. bitwise AND
 * does not have short circuiting and it is also used in performing bit-by-bit and operation.
 */

#endregion

#region Problem: Implement a program that takes a double input from the user and casts it to an int. Use both implicit and explicit casting, then print the results. 

//Console.Write("Enter a double number: ");
//string input = Console.ReadLine();

//if (double.TryParse(input, out double DoubleNumber))
//{
//    int ExplicitCast = (int)DoubleNumber; // Explicit: Cast double to int
//    double ImplicitCast = ExplicitCast;   // Implicit: int to double, no cast operator needed
//    ImplicitCast += 0.2;                  // Adding 0.2 to test te cast

//    Console.WriteLine($"Original double: {DoubleNumber}");
//    Console.WriteLine($"Explicit cast to int: {ExplicitCast}");
//    Console.WriteLine($"Implicit cast back to double: {ImplicitCast}");
//}
//else
//{
//    Console.WriteLine("Invalid input. Please enter a valid number.");
//}

#endregion

#region Question: Why is explicit casting required when converting a double to an int? 

/*
 * Explicit casting is required when converting a double to an int in C# because 
 * the conversion can result in data loss (the decimal part of the double is truncated),
 * and C# enforces type safety to prevent unintended errors.
 * so the compiler requires an explicit cast to confirm the programmer intentionally 
 * accepts the potential loss of precision.
 */

#endregion

#region Problem: Write a program that: (G01 Bonus, G02 mandatory)

/*
 * o Prompts the user for their age as a string. 
 * o Converts the string to an integer using Parse
 * o Checks if the age is valid (e.g., greater than 0). 
 * 
 */

//try
//{
//    Console.Write("Enter your age: ");
//    string input = Console.ReadLine();

//    if (!String.IsNullOrEmpty(input) && int.TryParse(input, out int age) && age > 0)
//    {
//        Console.WriteLine($"Your Age = {age}");
//    }
//    else
//    {
//        Console.WriteLine("Invalid input. Please enter a valid number.");
//    }

//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Error: {ex.Message}");
//}

#endregion

#region Question: What exception might occur if the input is invalid and how can you handle it

/*
 * When using int.Parse to convert a string to an integer in C# 
 * invalid input can cause the following exceptions:
 *
 * FormatException: Occurs if the input string is not a valid integer (e.g., "abc", "12.34", or empty string).
 * Handled using try parse function.
 * 
 * NullReferenceExeption: occurs when using a variable that holds null
 * Handled using String.IsNullOrEmpty(input).
 * 
 * OverflowException: Occurs if the input is a number outside the range of int (greater than 2,147,483,647 or less than -2,147,483,648).
 * Handled using the catch block and could be handled specifically for ckecking if the input violates the max
 * of an integer or using a catch block for that kind of exceptions.
 */

#endregion

#region Problem: Write a program that demonstrates the difference between prefix and postfix increment operators using a variable x.

//int x = 5;

//Console.WriteLine("Initial value of x: " + x);

//// Postfix increment (x++)
//Console.WriteLine("Postfix (x++):");
//int postfixResult = x++;
//Console.WriteLine($"Value returned by x++: {postfixResult}");
//Console.WriteLine($"Value of x after x++: {x}");

//// Resetting x
//x = 5;

//// Prefix increment (++x)
//Console.WriteLine("\nPrefix (++x):");
//int prefixResult = ++x;
//Console.WriteLine($"Value returned by ++x: {prefixResult}");
//Console.WriteLine($"Value of x after ++x: {x}");

#endregion

#region Question: Given the code below, what is the value of x after execution? Explain why 
/*
int x = 5;
int y = ++x + x++;
*/

/*
 * The value of x is 7. The prefix ++x increments x to 6 and returns 6,
 * then the postfix x++ uses 6 and increments x to 7.
 * 
 * The expression y = 6 + 6 assigns 12 to y, but x ends at 7.
 */

#endregion

Console.ReadKey();

// Definitions
class Car
{
    public int ModelYear { get; set; }
    public string Manufacturer { get; set; }
}
