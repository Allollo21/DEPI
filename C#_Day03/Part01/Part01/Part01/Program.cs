// Top - Level statement to save some space 

#region Problem: Write a program to: 
/*
    o Accept a string input from the user. 
    o Convert it to an integer using both int.Parse and Convert.ToInt32. 
    o Handle potential exceptions using a try-catch block. 

 */

//Console.Write("Enter Number: ");

//try
//{
//    var input = Console.ReadLine();
//    int number1 = int.Parse(input);
//    int number2 = Convert.ToInt32(input);
//    Console.WriteLine($"Number After Parsing {number1}");
//    Console.WriteLine($"Number After Convert {number2}");
//}
//catch(Exception ex)
//{
//    Console.WriteLine($"Error: {ex.Message}");
//}

// Question: What is the difference between int.Parse and Convert.ToInt32 when handling null inputs?
/*
 * int.Parse throws an ArgumentNullException when given a null input,
 * while Convert.ToInt32 returns 0 for a null input.
 * 
 * The choice between them depends on whether you want to handle null inputs gracefully (Convert.ToInt32)
 * or enforce stricter input validation like try catch (int.Parse).
 */

#endregion

#region Problem: Write a program that:

/*
    o Prompts the user to input a number. 
    o Uses int.TryParse to check if the input is a valid integer. 
    o If valid, print the number; otherwise, print an error message. 
 */

//Console.Write("Enter Number: ");
//var input = Console.ReadLine();
//if (int.TryParse(input, out int Output) && !String.IsNullOrEmpty(input))
//{
//    Console.WriteLine($"Output Number {Output}");
//}
//else
//{
//    Console.WriteLine("Invalid input. Please enter a valid number.");
//}

// Question: Why is TryParse recommended over Parse in user-facing applications? 

/*
 * TryParse is recommended over Parse in user-facing applications because it handles invalid inputs
 * gracefully without throwing exceptions, returning a boolean to indicate success or failure,
 * which simplifies error handling and improves user experience.
 */

#endregion

#region Problem: Implement a program to: 
/*
    o Declare an object variable. 
    o Assign it different data types (e.g., int, string, double). 
    o Print the GetHashCode() of each assignment. 
*/

//Object obj = new object();

//obj = 42;
//Console.WriteLine($"Integer (42) HashCode: {obj.GetHashCode()}");

//obj = "Hello, World!";
//Console.WriteLine($"String (Hello, World!) HashCode: {obj.GetHashCode()}");

//obj = 7.3254;
//Console.WriteLine($"Double (7.3254) HashCode: {obj.GetHashCode()}");

//obj = true;
//Console.WriteLine($"Boolean (true) HashCode: {obj.GetHashCode()}");

//obj = null;
//Console.WriteLine($"Null HashCode: {(obj == null ? "null" : obj.GetHashCode())}");

// Question: Explain the real purpose of the GetHashCode() method. 

/*
 * The GetHashCode() method generates a numeric hash code for an object,
 * primarily used as a key in hash-based collections like Dictionary or HashSet to efficiently organize
 * and retrieve data. Its real purpose is to provide a quick way to distribute objects into buckets
 * for fast lookups, comparisons, and storage in these collections,
 * where equal objects (as defined by Equals()) must produce the same hash code 
 * to ensure correct functionality.
 */

#endregion

#region Problem: Demonstrate how changing one reference affects another when both point to the same object. Use the following steps: 
/*
    o Create an object and assign it a value. 
    o Create a second reference to the same object. 
    o Modify the value of the object using one reference and print the value using theother.
*/

//using System.Text;

//object obj1 = new StringBuilder("Hello");
//Console.WriteLine($"Initial obj1 Value: {obj1}");

//object obj2 = obj1;
//Console.WriteLine($"obj2 Value after assignment: {obj2}\n");

//((StringBuilder)obj2).Append(", World!");
//Console.WriteLine($"obj1 Value after modifying obj2: {obj1}");

// Question: What is the significance of reference equality in .NET? 

/*
 * Reference equality in .NET checks if two variables point to the exact same object in memory,
 * using == or Object.ReferenceEquals(). It’s critical for ensuring object identity in scenarios
 * like caching, singletons, or collections (Dictionary or HashSet),
 * where you need to confirm you’re working with the same instance.
 * Unlike value equality (Equals()), which compares content
 */

#endregion

#region  Problem: Write a program to:
/*
    o Declare a string and modify it by concatenating additional text “Hi Willy”. 
    o Print the GetHashCode() before and after modification. 
*/

//string TextOne = "Say ";
//Console.WriteLine($"Initial Text: {TextOne}");
//Console.WriteLine($"HashCode Before Modification: {TextOne.GetHashCode()}\n");

//TextOne += "Hi Willy";
//Console.WriteLine($"Text After Modification: {TextOne}");
//Console.WriteLine($"HashCode Before Modification: {TextOne.GetHashCode()}");

// Question: Why string is immutable in C# ? 

/*
 * The String class encapsulates a char[] but exposes it as read-only,
 * ensuring no direct access or changes to the array’s contents after creation.
 * Any operation that seems to modify a string like concatenation or Replace() 
 * creates a new string object with a new char[], leaving the original unchanged.
 * 
 * This immutability provides thread safety, security, consistent hashing for collections,
 * and memory efficiency via string interning.
 */

#endregion

#region Problem: Create a program to: 
/*
    o Use StringBuilder to append text to a string “Hi Willy”. 
    o Print the GetHashCode() of the StringBuilder instance before and after the modification.
*/

//using System.Text;

//StringBuilder TextOne = new StringBuilder("Say ");
//Console.WriteLine($"Initial Text: {TextOne}");
//Console.WriteLine($"HashCode Before Modification: {TextOne.GetHashCode()}\n");

//TextOne.Append("Hi Willy");
//Console.WriteLine($"Text After Modification: {TextOne}");
//Console.WriteLine($"HashCode Before Modification: {TextOne.GetHashCode()}");

// Question: How does StringBuilder address the inefficiencies of string concatenation? 

/*
 * Instead of creating new string objects for every modification (like concatenation),
 * StringBuilder directly manipulates this internal buffer.
 * 
 * When appending more characters than the current buffer can hold, it expands the buffer's capacity,
 * typically by doubling it, and copies the existing characters to the larger buffer.
 * 
 * For very large strings or frequent expansions, StringBuilder can internally manage its data 
 * as a linked list of char[] buffers, referred to as "chunks." Each chunk is effectively 
 * a StringBuilder instance itself, containing a buffer and a reference to the previous chunk.
 * 
 * This linked-list structure allows for efficient growth without always requiring a full copy 
 * of the entire string.
 */

#endregion

#region Question: Why is StringBuilder faster for large-scale string modifications?

/*
 * StringBuilder is faster for large-scale string modifications because string objects are immutable.
 * Each modification to a string creates a new string object, leading to frequent memory allocations,
 * data copying, and garbage collection overhead.
 * 
 * While StringBuilder , uses a mutable internal character array, and Linked-List for large strings
 * allowing modifications to happen in place. This avoids repeated object creation,
 * significantly boosting performance for numerous string operations.
 */

#endregion

#region Problem: Create a program to: 
/*
    o Accept two integer inputs from the user. 
    o Display the sum using all three methods “Sum is input1+input2”: 
         Concatenation(+ operator)
         Composite formatting(string.Format)
         String interpolation($)
*/

//int FirstNumber, SecondNumber;

//while (true)
//{
//    Console.Write("Enter the first integer: ");
//    string? InputOne = Console.ReadLine();
//    if (int.TryParse(InputOne, out FirstNumber) && !string.IsNullOrEmpty(InputOne))
//        break;

//    Console.Clear();
//    Console.Write("Invalid input. Please enter a valid integer for the first number: ");
//}

//while (true)
//{
//    Console.Write("Enter the second integer: ");
//    string? InputTwo = Console.ReadLine();
//    if (int.TryParse(InputTwo, out SecondNumber) && !string.IsNullOrEmpty(InputTwo))
//        break;

//    Console.Clear();
//    Console.Write("Invalid input. Please enter a valid integer for the second number.");
//}

//int sum = FirstNumber + SecondNumber;

//Console.WriteLine("Concatenation: Sum is " + FirstNumber + " + " + SecondNumber + " = " + sum);
//Console.WriteLine(string.Format("Composite Formatting: Sum is {0} + {1} = {2}", FirstNumber, SecondNumber, sum));
//Console.WriteLine($"String Interpolation: Sum is {FirstNumber} + {SecondNumber} = {sum}");

// Question: Which string formatting method is most used and why?

/*
 * String Interpolation is the most widely used and recommended string formatting method.
 * Expressions are directly embedded in the string so, better readibilty.
 * Supports variables, expressions, and all format specifiers directly.
 * And better performance as it minimizes intermediate string allocations and object boxing.
 */

#endregion

#region Problem: Create a program using StringBuilder to: 
/*
    o Append text. 
    o Replace a substring. 
    o Insert a string at a specific position. 
    o Remove a portion of text. 
*/


//using System.Text;

//StringBuilder sb = new StringBuilder();

//// Append text
//sb.Append("Hello, this is a random text.");
//Console.WriteLine($"After Appending ---> {sb}");

//// Replace a substring
//sb.Replace("random", "modified");
//Console.WriteLine($"After Replace 'random' with 'modified' ---> {sb}");

//// Insert a string at a specific position
//sb.Insert(7, "World! ");
//Console.WriteLine($"After Insert 'World! ' at index 7 ---> {sb}");

//// Remove a portion of text. (could have use Remove())
//sb.Replace("this is a modified text", "\b");
//Console.WriteLine($"After Removing 'this is a modified text' ---> {sb}");

// Question: Explain how StringBuilder is designed to handle frequent modifications compared to strings. 

/* 
 * StringBuilder is designed for mutability.
 * It uses a resizable internal character buffer that allows in-place modifications 
 * like appending, inserting, or replacing characters without creating new StringBuilder objects.
 * When the buffer needs more space, it expands, copying the existing content only when necessary.
 * This approach reduces memory allocations and copying operations, making StringBuilder 
 * a better choice for scenarios involving extensive string manipulation.
 */

#endregion

