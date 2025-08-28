// Top - Level statement to save some space 
// Tip: Uncomment region code to test and then comment it back

#region InputAndValidate Function
using System.ComponentModel;

static T InputAndValidate<T>(string prompt, bool allowEmpty = false, T? defaultValue = default)
{
    while (true)
    {
        Console.Write(prompt);
        string? input = Console.ReadLine()!;

        if (allowEmpty && String.IsNullOrWhiteSpace(input))
        {
            return defaultValue!;
        }

        if (typeof(T) == typeof(int))
        {
            if (int.TryParse(input, out int result) && !String.IsNullOrWhiteSpace(input))
            {
                return (T)(object)result;
            }
        }
        else if (typeof(T) == typeof(double))
        {
            if (double.TryParse(input, out double result) && !String.IsNullOrWhiteSpace(input))
            {
                return (T)(object)result;
            }
        }
        else if (typeof(T) == typeof(string))
        {
            if (!String.IsNullOrWhiteSpace(input))
            {
                return (T)(object)input;
            }
        }
        else
        {
            Console.Write("Invalid Data Type. Not Allowed!: ");
            return defaultValue!;
        }   
    }
}
#endregion

#region Problem:
/*
    o Implement a sorting algorithm using the SortingAlgorithm<T> class for an array of 
      Employee objects based on their salary in ascending order.
*/

//int count = InputAndValidate("Enter number of employees (integer): ", false, 1);
//Employee[] employees = new Employee[count];

//for (int i = 0; i < count; i++)
//{
//    Console.WriteLine($"\nEnter details for Employee {i + 1}:");
//    int id = InputAndValidate("Enter Employee ID (integer): ", false, -1);
//    string name = InputAndValidate("Enter Employee Name: ", false, "Unknown");
//    double salary = InputAndValidate<double>("Enter Employee Salary (double): ", false, -1);
//    employees[i] = new Employee(id, name, salary);
//}

//Console.WriteLine("\nEmployees before sorting:");
//foreach (var emp in employees)
//{
//    Console.WriteLine(emp);
//}

//SortingAlgorithm<Employee>.Sort(employees, (emp1, emp2) => emp1.Salary.CompareTo(emp2.Salary));

//Console.WriteLine("\nEmployees after sorting by salary (ascending):");
//foreach (var emp in employees)
//{
//    Console.WriteLine(emp);
//}

//Console.ReadKey();

//public class Employee
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public double Salary { get; set; }

//    public Employee(int id, string name, double salary)
//    {
//        Id = id;
//        Name = name;
//        Salary = salary;
//    }

//    public override string ToString()
//    {
//        return $"Employee ID: {Id}, Name: {Name}, Salary: {Salary}";
//    }
//}

//public class SortingAlgorithm<T>
//{
//    public static void Sort(T[] array, Func<T, T, int> comparer)
//    {
//        for (int i = 0; i < array.Length - 1; i++)
//        {
//            for (int j = 0; j < array.Length - i - 1; j++)
//            {
//                if (comparer(array[j], array[j + 1]) > 0)
//                {
//                    T temp = array[j];
//                    array[j] = array[j + 1];
//                    array[j + 1] = temp;
//                }
//            }
//        }
//    }
//}

// Question: What are the benefits of using a generic sorting algorithm over a non-generic one?

/* 
 * Type Safety: Generics ensure compile-time type checking, preventing runtime errors due to incorrect
 * types. A non-generic algorithm requires casting, which can lead to invalid cast exceptions.
 * 
 * Reusability: A generic algorithm can sort any data type as long as a comparison mechanism is provided,
 * reducing code duplication. Non-generic algorithms are typically limited to specific types or require 
 * separate implementations.
 * 
 * Performance: Generics avoid boxing and unboxing when working with value types, improving performance 
 * compared to non-generic algorithms that use object, which incurs overhead for value types.
 */
#endregion

#region Problem:
/*
    o Modify the SortingTwo<T>.Sort method to dynamically sort integers in descending order 
      using a lambda expression.
*/

//int count = InputAndValidate("Enter number of integers (integer): ", false, 1);
//int[] numbers = new int[count];

//for (int i = 0; i < count; i++)
//{
//    numbers[i] = InputAndValidate($"Enter integer {i + 1}: ", false, 0);
//}

//Console.WriteLine("\nIntegers before sorting:");
//Console.WriteLine(string.Join(", ", numbers));

//SortingTwo<int>.Sort(numbers, (x, y) => y.CompareTo(x));

//Console.WriteLine("\nIntegers after sorting in descending order:");
//Console.WriteLine(string.Join(", ", numbers));

//Console.ReadKey();

//public class SortingTwo<T> where T : IComparable<T>
//{
//    public static void Sort(T[] array, Func<T, T, int> predicate)
//    {
//        for (int i = 0; i < array.Length - 1; i++)
//        {
//            for (int j = 0; j < array.Length - i - 1; j++)
//            {
//                if (predicate(array[j], array[j + 1]) > 0)
//                {
//                    T temp = array[j];
//                    array[j] = array[j + 1];
//                    array[j + 1] = temp;
//                }
//            }
//        }
//    }
//}

// Question: How do lambda expressions improve the readability and flexibility of sorting methods?

/*
 * Conciseness: Lambda expressions provide a compact syntax for defining comparison logic inline, 
 * reducing the need for separate delegate methods or classes, which makes the code easier to read and maintain.
 * 
 * Flexibility: They allow dynamic specification of sorting criteria at the point of calling the sort method,
 * enabling easy switching between ascending (a.CompareTo(b)) and descending (b.CompareTo(a)) orders, or sorting by different properties without modifying the sorting algorithm.
 * 
 */
#endregion

#region Problem:
/*
    o Write a comparer function to sort strings based on their length in ascending order using 
      SortingTwo<T>.Sort.
*/

//int count = InputAndValidate("Enter number of strings (integer): ", false, 1);
//string[] strings = new string[count];

//for (int i = 0; i < count; i++)
//{
//    strings[i] = InputAndValidate($"Enter string {i + 1}: ", false, "");
//}

//Console.WriteLine("\nStrings before sorting:");
//Console.WriteLine(string.Join(", ", strings));

//SortingTwo<string>.Sort(strings, (x, y) => x.Length.CompareTo(y.Length));

//Console.WriteLine("\nStrings after sorting by length (ascending):");
//Console.WriteLine(string.Join(", ", strings));

//Console.ReadKey();

//public class SortingTwo<T>
//{
//    public static void Sort(T[] array, Func<T, T, int> predicate)
//    {
//        for (int i = 0; i < array.Length - 1; i++)
//        {
//            for (int j = 0; j < array.Length - i - 1; j++)
//            {

//                if (predicate(array[j], array[j + 1]) > 0)
//                {
//                    T temp = array[j];
//                    array[j] = array[j + 1];
//                    array[j + 1] = temp;
//                }
//            }
//        }
//    }
//}

// Question: Why is it important to use a dynamic comparer function when sorting objects of various data types?

/*
 * Flexibility in Sorting Criteria: A dynamic comparer allows the sorting logic to be defined at runtime,
 * enabling sorting based on different properties or orders (ascending/descending) without modifying the 
 * core sorting algorithm. This is critical for handling diverse data types like strings, integers, or 
 * custom objects.
 * 
 * Type Safety and Generics: When combined with generics, dynamic comparers ensure type-safe sorting for 
 * any data type implementing IComparable (or via a custom comparison), avoiding runtime errors and 
 * eliminating the need for casting, unlike non-generic solutions using object.
 * 
 * Reusability: A single generic sorting method with a dynamic comparer can be reused across different 
 * data types and sorting criteria, reducing code duplication compared to writing separate sorting methods 
 * for each type or property.
 * 
 */
#endregion

#region Problem:
/*
    o Add a new class Manager that inherits from Employee and implements IComparable<Manager>.
    o Update the sorting logic to include Manager objects and compare by Salary.
*/

//int count = InputAndValidate("Enter number of managers (integer): ", false, 1);
//Manager[] managers = new Manager[count];

//for (int i = 0; i < count; i++)
//{
//    Console.WriteLine($"\nEnter details for Manager {i + 1}:");
//    int id = InputAndValidate("Enter Manager ID (integer): ", false, -1);
//    string name = InputAndValidate("Enter Manager Name: ", false, "Unknown");
//    double salary = InputAndValidate<double>("Enter Manager Salary (double): ", false, -1);
//    managers[i] = new Manager(id, name, salary);
//}

//Console.WriteLine("\nManagers before sorting:");
//foreach (var manager in managers)
//{
//    Console.WriteLine(manager);
//}

//SortingTwo<Manager>.Sort(managers, (x, y) => x.Salary.CompareTo(y.Salary));

//Console.WriteLine("\nManagers after sorting by salary (ascending):");
//foreach (var manager in managers)
//{
//    Console.WriteLine(manager);
//}

//Console.ReadKey();

//public class Employee
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public double Salary { get; set; }

//    public Employee(int id, string name, double salary)
//    {
//        Id = id;
//        Name = name;
//        Salary = salary;
//    }

//    public override string ToString()
//    {
//        return $"ID: {Id}, Name: {Name}, Salary: {Salary}";
//    }
//}

//public class Manager : Employee, IComparable<Manager>
//{
//    public Manager(int id, string name, double salary) : base(id, name, salary)
//    {
//    }

//    public int CompareTo(Manager? other)
//    {
//        if (other == null) return 1;
//        return Salary.CompareTo(other.Salary);
//    }

//    public override string ToString()
//    {
//        return $"Manager - {base.ToString()}";
//    }
//}

//public class SortingTwo<T>
//{
//    public static void Sort(T[] array, Func<T, T, int> predicate)
//    {
//        for (int i = 0; i < array.Length - 1; i++)
//        {
//            for (int j = 0; j < array.Length - i - 1; j++)
//            {
//                if (predicate(array[j], array[j + 1]) > 0)
//                {
//                    T temp = array[j];
//                    array[j] = array[j + 1];
//                    array[j + 1] = temp;
//                }
//            }
//        }
//    }
//}

// Question: How does implementing IComparable<T> in derived classes enable custom sorting?

/*
 * Standardized Comparison Logic: IComparable<T> defines a standard CompareTo method that specifies how 
 * instances of a class compare to each other, allowing sorting algorithms to use this logic consistently 
 * for ordering objects.
 * 
 * Type-Safe Comparisons: By using IComparable<T>, comparisons are type-safe, as the CompareTo method 
 * accepts a parameter of type T, eliminating the need for casting and reducing runtime errors compared to 
 * non-generic IComparable.
 * 
 * Customizable Sorting Criteria: Derived classes can define their own comparison logic in CompareTo, 
 * such as sorting Manager objects by salary, enabling tailored sorting behavior specific to the class’s 
 * properties or requirements.
 * 
 */
#endregion

#region Problem:
/*
    o Create a delegate Func<T, T, bool> to compare Employee objects based on their Name 
      length and sort an array of employees.
*/

//int count = InputAndValidate("Enter number of employees (integer): ", false, 1);
//Employee[] employees = new Employee[count];

//for (int i = 0; i < count; i++)
//{
//    Console.WriteLine($"\nEnter details for Employee {i + 1}:");
//    int id = InputAndValidate("Enter Employee ID (integer): ", false, -1);
//    string name = InputAndValidate("Enter Employee Name: ", false, "Unknown");
//    double salary = InputAndValidate<double>("Enter Employee Salary (double): ", false, -1);
//    employees[i] = new Employee(id, name, salary);
//}

//Console.WriteLine("\nEmployees before sorting:");
//foreach (var emp in employees)
//{
//    Console.WriteLine(emp);
//}

//SortingTwo<Employee>.Sort(employees, (emp1, emp2) => emp1.Name.Length > emp2.Name.Length);

//Console.WriteLine("\nEmployees after sorting by name length (ascending):");
//foreach (var emp in employees)
//{
//    Console.WriteLine(emp);
//}

//Console.ReadKey();

//public class Employee
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public double Salary { get; set; }

//    public Employee(int id, string name, double salary)
//    {
//        Id = id;
//        Name = name;
//        Salary = salary;
//    }

//    public override string ToString()
//    {
//        return $"Employee ID: {Id}, Name: {Name}, Salary: {Salary}";
//    }
//}

//public class SortingTwo<T>
//{
//    public static void Sort(T[] array, Func<T, T, bool> comparer)
//    {
//        for (int i = 0; i < array.Length - 1; i++)
//        {
//            for (int j = 0; j < array.Length - i - 1; j++)
//            {
//                if (comparer(array[j], array[j + 1]))
//                {
//                    T temp = array[j];
//                    array[j] = array[j + 1];
//                    array[j + 1] = temp;
//                }
//            }
//        }
//    }
//}

// Question: What is the advantage of using built-in delegates like Func<T, T, TResult> in generic programming?

/*
 * Func<T, T, TResult> eliminates the need to define custom delegate types, reducing boilerplate code and 
 * making the codebase more concise and easier to maintain.
 * 
 * Type Safety: As a generic delegate, Func<T, T, TResult> ensures type-safe operations at compile time
 * 
 * Flexibility: It supports a wide range of input and output types, allowing developers to define custom 
 * logic (e.g., comparing `Employee` objects by name length) without modifying the core algorithm, 
 * enhancing adaptability in generic methods like SortingTwo<T>.Sort.
 * 
 */
#endregion

#region Problem:
/*
    o Use an anonymous function to sort an integer array in ascending order. 
    o Demonstrate the same logic with a lambda expression.
*/

//int count = InputAndValidate("Enter number of integers (integer): ", false, 1);
//int[] numbers = new int[count];

//for (int i = 0; i < count; i++)
//{
//    numbers[i] = InputAndValidate($"Enter integer {i + 1}: ", false, 0);
//}

//Console.WriteLine("\nIntegers before sorting (anonymous function):");
//Console.WriteLine(string.Join(", ", numbers));
//int[] numbersCopy = new int[count];
//Array.Copy(numbers, numbersCopy, count);

//Func<int, int, bool> anonymousCompare = delegate (int a, int b)
//{
//    return a > b;
//};
//SortingTwo<int>.Sort(numbers, anonymousCompare);

//Console.WriteLine("\nIntegers after sorting with anonymous function (ascending):");
//Console.WriteLine(string.Join(", ", numbers));

//Console.WriteLine("\nIntegers before sorting (lambda expression):");
//Console.WriteLine(string.Join(", ", numbersCopy));

//SortingTwo<int>.Sort(numbersCopy, (a, b) => a > b);

//Console.WriteLine("\nIntegers after sorting with lambda expression (ascending):");
//Console.WriteLine(string.Join(", ", numbersCopy));

//Console.ReadKey();

//public class SortingTwo<T>
//{
//    public static void Sort(T[] array, Func<T, T, bool> comparer)
//    {
//        for (int i = 0; i < array.Length - 1; i++)
//        {
//            for (int j = 0; j < array.Length - i - 1; j++)
//            {
//                if (comparer(array[j], array[j + 1]))
//                {
//                    T temp = array[j];
//                    array[j] = array[j + 1];
//                    array[j + 1] = temp;
//                }
//            }
//        }
//    }
//}

// Question: How does the usage of anonymous functions differ from lambda expressions in terms of readability and efficiency?

/*
 * Readability:
 *    Lambda Expressions: Lambda expressions use a concise, inline syntax that clearly conveys the intent 
 *    of the operation, making them highly readable, especially for simple logic. The => operator succinctly
 *    binds parameters to the expression body, reducing visual clutter.
 *    
 *    Anonymous Functions: Anonymous functions use a more verbose syntax with the delegate keyword and 
 *    explicit block structure, which can reduce readability for simple operations. They resemble 
 *    traditional method declarations, making them less compact but potentially clearer for complex 
 *    logic requiring multiple statements.
 * 
 * Efficiency:
 *    Lambda Expressions: Lambda expressions are typically compiled into lightweight delegate instances 
 *    by the C# compiler, with minimal overhead. For simple comparisons like sorting, they are op
 *    timized and incur no significant performance penalty compared to anonymous functions.
 *    
 *    Anonymous Functions: Anonymous functions are also compiled into delegate instances, and their runtime
 *    performance is generally equivalent to lambda expressions for the same logic. The compiler generates
 *    similar IL (Intermediate Language) code for both, so there is no notable efficiency difference in 
 *    most cases.
 *    
 */
#endregion

#region Problem:
/*
    o Enhance the SortingAlgorithm<T> class by implementing a standalone generic method 
      Swap<T> and demonstrate swapping elements of an integer array.
*/

//int count = InputAndValidate("Enter number of integers (integer): ", false, 1);
//int[] numbers = new int[count];

//for (int i = 0; i < count; i++)
//{
//    numbers[i] = InputAndValidate($"Enter integer {i + 1}: ", false, 0);
//}

//Console.WriteLine("\nIntegers before sorting:");
//Console.WriteLine(string.Join(", ", numbers));

//SortingAlgorithm<int>.Sort(numbers, (a, b) => a > b);

//Console.WriteLine("\nIntegers after sorting in ascending order:");
//Console.WriteLine(string.Join(", ", numbers));

//Console.ReadKey();

//public class SortingAlgorithm<T>
//{
//    public static void Swap<T>(ref T a, ref T b)
//    {
//        T temp = a;
//        a = b;
//        b = temp;
//    }

//    public static void Sort(T[] array, Func<T, T, bool> comparer)
//    {
//        for (int i = 0; i < array.Length - 1; i++)
//        {
//            for (int j = 0; j < array.Length - i - 1; j++)
//            {
//                if (comparer(array[j], array[j + 1]))
//                {
//                    Swap(ref array[j], ref array[j + 1]);
//                }
//            }
//        }
//    }
//}

// Question: Why is the use of generic methods beneficial when creating utility functions like Swap?

/*
 * Type Safety: Generic methods ensure compile-time type checking, preventing runtime errors due to 
 * incorrect types. For example, Swap<T> works with any type without requiring unsafe casting, 
 * unlike non-generic methods using object.
 * 
 * Reusability: A single generic method can be used across different data types, eliminating the need to 
 * write separate Swap methods for int, string, or other types, reducing code duplication and improving 
 * maintainability.
 * 
 * Performance: Generics avoid boxing and unboxing for value types, which occurs with non-generic methods 
 * using object. This improves runtime performance, especially in utility functions like Swap that are 
 * called frequently in algorithms like sorting.
 */
#endregion

#region Problem:
/*
    o Extend SortingTwo<T>.Sort to sort Employee objects first by Salary, and in case of ties, 
      by Name using a custom comparer.
*/

//int count = InputAndValidate("Enter number of employees (integer): ", false, 1);
//Employee[] employees = new Employee[count];

//for (int i = 0; i < count; i++)
//{
//    Console.WriteLine($"\nEnter details for Employee {i + 1}:");
//    int id = InputAndValidate("Enter Employee ID (integer): ", false, -1);
//    string name = InputAndValidate("Enter Employee Name: ", false, "Unknown");
//    double salary = InputAndValidate<double>("Enter Employee Salary (double): ", false, -1);
//    employees[i] = new Employee(id, name, salary);
//}

//Console.WriteLine("\nEmployees before sorting:");
//foreach (var emp in employees)
//{
//    Console.WriteLine(emp);
//}

//Func<Employee, Employee, int> compareBySalaryThenName = (emp1, emp2) =>
//{
//    int salaryComparison = emp1.Salary.CompareTo(emp2.Salary);
//    if (salaryComparison != 0)
//        return salaryComparison;
//    return emp1.Name.CompareTo(emp2.Name);
//};
//SortingTwo<Employee>.Sort(employees, compareBySalaryThenName);

//Console.WriteLine("\nEmployees after sorting by salary, then name (ascending):");
//foreach (var emp in employees)
//{
//    Console.WriteLine(emp);
//}

//Console.ReadKey();

//public class Employee
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public double Salary { get; set; }

//    public Employee(int id, string name, double salary)
//    {
//        Id = id;
//        Name = name;
//        Salary = salary;
//    }

//    public override string ToString()
//    {
//        return $"Employee ID: {Id}, Name: {Name}, Salary: {Salary}";
//    }
//}

//public class SortingTwo<T>
//{
//    public static void Swap<T>(ref T a, ref T b)
//    {
//        T temp = a;
//        a = b;
//        b = temp;
//    }

//    public static void Sort(T[] array, Func<T, T, int> comparer)
//    {
//        for (int i = 0; i < array.Length - 1; i++)
//        {
//            for (int j = 0; j < array.Length - i - 1; j++)
//            {
//                if (comparer(array[j], array[j + 1]) > 0)
//                {
//                    Swap(ref array[j], ref array[j + 1]);
//                }
//            }
//        }
//    }
//}

// Question: What are the challenges and benefits of implementing multi-criteria sorting logic in generic methods?

/*
 * Challenges:
 * Complexity of Comparison Logic: Multi-criteria sorting requires defining a comparison function that 
 * evaluates multiple fields, which increases the complexity of the comparer logic. Developers must ensure
 * correct handling of ties and maintain consistent ordering across criteria.
 * 
 * Performance Considerations: Checking multiple criteria can increase the computational cost of 
 * comparisons, especially for large datasets, as each comparison may involve multiple property accesses 
 * and evaluations.
 * 
 * Benefits:
 * Flexibility: Generic methods allow multi-criteria sorting to be applied to any type T by defining the 
 * comparison logic externally, enabling sorting by any combination of fields without modifying the core 
 * algorithm.
 * 
 * Reusability: A single generic method like Sort can handle various types and sorting criteria, reducing 
 * code duplication compared to writing specific sorting methods for each type or criterion.
 * 
 * Type Safety: Generics ensure compile-time type checking, preventing runtime errors due to incorrect 
 * types, making multi-criteria sorting robust when accessing object properties through a type-safe 
 * comparer.
 */
#endregion

#region Problem:
/*
    o Write a method GetDefault that uses default(T) to return the default value of generic 
      types and demonstrate its use with value types and reference types.
*/

//Console.WriteLine("Demonstrating GetDefault<T> with various types:");
//Console.WriteLine($"Default int: {GetDefault<int>()}");
//Console.WriteLine($"Default double: {GetDefault<double>()}");
//Console.WriteLine($"Default string: {(GetDefault<string>() == null ? "null" : GetDefault<string>())}");
//Console.WriteLine($"Default Employee: {(GetDefault<Employee>() == null ? "null" : GetDefault<Employee>().ToString())}");

//Console.ReadKey();

//static T GetDefault<T>()
//{
//    return default(T);
//}

//public class Employee
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public double Salary { get; set; }

//    public Employee(int id, string name, double salary)
//    {
//        Id = id;
//        Name = name;
//        Salary = salary;
//    }

//    public override string ToString()
//    {
//        return $"Employee ID: {Id}, Name: {Name}, Salary: {Salary}";
//    }
//}

// Question: Why is the default(T) keyword crucial in generic programming, and how does it handle value and reference types differently?

/*
 * Why default(T) is Crucial:
 * Type-Agnostic Initialization: default(T) provides a way to initialize a generic type T to its default 
 * value without knowing the specific type at compile time, ensuring safe and consistent initialization in
 * generic methods and classes.
 * 
 * Type Safety: It ensures compile-time type safety by returning the appropriate default value for T,
 * avoiding runtime errors that could occur with incorrect assumptions about the type.

 * Handling of Value and Reference Types:
 *   Value Types: For value types , default(T) returns the type’s zero-initialized state, where all bits 
 *   are set to zero. For example:
 *   int: 0
 *   double: 0.0
 *   bool: false
 *
 * Key Differences:
 *   Value types always have a defined default value , ensuring a valid state, while reference types 
 *   default to null, indicating no object is instantiated.
 *   
 *   Using default(T) in generic code avoids assumptions about whether T is a value or reference type, 
 *   preventing errors like attempting to assign `null` to a value type or 0 to a reference type.
 *   
 *   For value types, default(T) avoids boxing, improving performance, while for reference types, it aligns 
 *   with their natural null state.
 */
#endregion

#region Problem:
/*
    o Add a constraint to the SortingAlgorithm<T> class to ensure T implements ICloneable.
    o Demonstrate cloning an Employee array before sorting it.
*/

//int count = InputAndValidate("Enter number of employees (integer): ", false, 1);
//Employee[] employees = new Employee[count];

//for (int i = 0; i < count; i++)
//{
//    Console.WriteLine($"\nEnter details for Employee {i + 1}:");
//    int id = InputAndValidate("Enter Employee ID (integer): ", false, -1);
//    string name = InputAndValidate("Enter Employee Name: ", false, "Unknown");
//    double salary = InputAndValidate<double>("Enter Employee Salary (double): ", false, -1);
//    employees[i] = new Employee(id, name, salary);
//}

//Console.WriteLine("\nOriginal Employee array before cloning and sorting:");
//foreach (var emp in employees)
//{
//    Console.WriteLine(emp);
//}

//Employee[] clonedEmployees = new Employee[employees.Length];
//for (int i = 0; i < employees.Length; i++)
//{
//    clonedEmployees[i] = (Employee)employees[i].Clone();
//}

//SortingAlgorithm<Employee>.Sort(clonedEmployees, (emp1, emp2) => emp1.Salary.CompareTo(emp2.Salary));

//Console.WriteLine("\nCloned Employee array after sorting by salary (ascending):");
//foreach (var emp in clonedEmployees)
//{
//    Console.WriteLine(emp);
//}

//Console.WriteLine("\nOriginal Employee array after sorting (unchanged):");
//foreach (var emp in employees)
//{
//    Console.WriteLine(emp);
//}

//Console.ReadKey();

//public class Employee : ICloneable
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public double Salary { get; set; }

//    public Employee(int id, string name, double salary)
//    {
//        Id = id;
//        Name = name;
//        Salary = salary;
//    }

//    public object Clone()
//    {
//        return new Employee(Id, Name, Salary);
//    }

//    public override string ToString()
//    {
//        return $"Employee ID: {Id}, Name: {Name}, Salary: {Salary}";
//    }
//}

//public class SortingAlgorithm<T> where T : ICloneable
//{
//    public static void Swap<TSwap>(ref TSwap a, ref TSwap b)
//    {
//        TSwap temp = a;
//        a = b;
//        b = temp;
//    }

//    public static void Sort(T[] array, Func<T, T, int> comparer)
//    {
//        for (int i = 0; i < array.Length - 1; i++)
//        {
//            for (int j = 0; j < array.Length - i - 1; j++)
//            {
//                if (comparer(array[j], array[j + 1]) > 0)
//                {
//                    Swap(ref array[j], ref array[j + 1]);
//                }
//            }
//        }
//    }
//}

// Question: How do constraints in generic programming ensure type safety and improve the reliability of generic methods?

/*
 * Ensuring Type Safety as Constraints restrict the types that can be used with a generic method or class, 
 * ensuring that only types meeting the specified requirements are allowed. This prevents compile-time 
 * errors by rejecting invalid types before runtime.
 * 
 * Improving Reliability as Constraints ensure that generic methods operate on types with known capabilities,
 * making the code’s behavior predictable and consistent. For example, SortingAlgorithm<T> can rely on T 
 * supporting Clone, enabling safe array copying before sorting.
 */
#endregion

#region Problem:
/*
    o Create a delegate that takes a string and returns a string. Implement a function that 
      applies this delegate to each element in a list of strings and returns the transformed list.
    o Test with different transformations like converting to uppercase, reversing the string, etc.
*/

//int count = InputAndValidate("Enter number of strings (integer): ", false, 1);
//List<string> strings = new List<string>();

//for (int i = 0; i < count; i++)
//{
//    strings.Add(InputAndValidate($"Enter string {i + 1}: ", false, ""));
//}

//Console.WriteLine("\nOriginal strings:");
//Console.WriteLine(string.Join(", ", strings));

//List<string> upperStrings = TransformStrings(strings, s => s.ToUpper());
//Console.WriteLine("\nStrings after converting to uppercase:");
//Console.WriteLine(string.Join(", ", upperStrings));

//List<string> reversedStrings = TransformStrings(strings, s => new string(s.Reverse().ToArray()));
//Console.WriteLine("\nStrings after reversing:");
//Console.WriteLine(string.Join(", ", reversedStrings));

//Console.ReadKey();

//static List<string> TransformStrings(List<string> strings, Func<string, string> transformer)
//{
//    List<string> result = new List<string>();
//    foreach (var s in strings)
//    {
//        result.Add(transformer(s));
//    }
//    return result;
//}

// Question: What are the benefits of using delegates for string transformations in a functional programming style?

/*
 * Delegates like Func<string, string> enable functional programming by allowing flexible, reusable, and 
 * composable string transformations, promoting concise code, type safety, and dynamic behavior through 
 * inline lambda expressions or method references.
 */
#endregion

#region Problem:
/*
    o Create a delegate that takes two integers and returns an integer. Implement a function that 
      takes two integers and a delegate and performs the operation defined by the delegate.
    o Test with different operations like addition, subtraction, multiplication, and division.
*/

//int a = InputAndValidate("Enter first integer: ", false, 0);
//int b = InputAndValidate("Enter second integer: ", false, 0);

//Console.WriteLine($"\nInput numbers: a = {a}, b = {b}");

//Console.WriteLine($"Addition result: {PerformOperation(a, b, (x, y) => x + y)}");

//Console.WriteLine($"Subtraction result: {PerformOperation(a, b, (x, y) => x - y)}");

//Console.WriteLine($"Multiplication result: {PerformOperation(a, b, (x, y) => x * y)}");

//try
//{
//    Console.WriteLine($"Division result: {PerformOperation(a, b, (x, y) => x / y}");
//}
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine($"Error: {ex.Message}");
//}

//Console.ReadKey();

//static int PerformOperation(int a, int b, Func<int, int, int> operation)
//{
//    return operation(a, b);
//}

// Question: How does the use of delegates promote code reusability and flexibility in implementing mathematical operations?

/*
 * Delegates like `Func<int, int, int>` promote code reusability and flexibility by allowing a single 
 * function (e.g., `PerformOperation`) to execute different mathematical operations 
 * (e.g., addition, subtraction) defined dynamically via lambda expressions or methods, reducing code 
 * duplication and enabling easy extension with new operations without modifying the core function.
 */
#endregion

#region Problem:
/*
    o Define a generic delegate that takes a parameter of type T and returns a value of type R.
      Implement a function that transforms a list of type T into a list of type R using this 
      delegate. Test with different transformations like converting a list of integers to their 
      string representations.
*/

//int count = InputAndValidate("Enter number of integers (integer): ", false, 1);
//List<int> numbers = new List<int>();

//for (int i = 0; i < count; i++)
//{
//    numbers.Add(InputAndValidate($"Enter integer {i + 1}: ", false, 0));
//}

//Console.WriteLine("\nOriginal integers:");
//Console.WriteLine(string.Join(", ", numbers));

//List<string> stringNumbers = TransformList<int, string>(numbers, x => x.ToString());
//Console.WriteLine("\nIntegers converted to strings:");
//Console.WriteLine(string.Join(", ", stringNumbers));

//List<string> hexNumbers = TransformList<int, string>(numbers, x => "0x" + x.ToString("X"));
//Console.WriteLine("\nIntegers converted to hexadecimal:");
//Console.WriteLine(string.Join(", ", hexNumbers));

//List<double> doubleNumbers = TransformList<int, double>(numbers, x => x * 1.0);
//Console.WriteLine("\nIntegers converted to doubles:");
//Console.WriteLine(string.Join(", ", doubleNumbers));

//Console.ReadKey();

//static List<R> TransformList<T, R>(List<T> input, Func<T, R> transformer)
//{
//    List<R> result = new List<R>();
//    foreach (var item in input)
//    {
//        result.Add(transformer(item));
//    }
//    return result;
//}

// Question: What are the advantages of using generic delegates in transforming data structures?

/*
 * Generic delegates like Func<T, R> enable flexible, type-safe, and reusable transformations of data 
 * structures by allowing dynamic specification of input and output types, reducing code duplication, 
 * and supporting concise lambda expressions for diverse operations.
 */
#endregion

#region Problem:
/*
    o Use Func<T, TResult> to create a delegate that takes an integer and returns its square.
      Implement a function that applies this delegate to each element in a list of integers and 
      returns the list of results.
*/

//int count = InputAndValidate("Enter number of integers (integer): ", false, 1);
//List<int> numbers = new List<int>();

//for (int i = 0; i < count; i++)
//{
//    numbers.Add(InputAndValidate($"Enter integer {i + 1}: ", false, 0));
//}

//Console.WriteLine("\nOriginal integers:");
//Console.WriteLine(string.Join(", ", numbers));

//List<int> squaredNumbers = TransformList(numbers, x => x * x);
//Console.WriteLine("\nIntegers after squaring:");
//Console.WriteLine(string.Join(", ", squaredNumbers));

//Console.ReadKey();

//static List<TResult> TransformList<T, TResult>(List<T> input, Func<T, TResult> transformer)
//{
//    List<TResult> result = new List<TResult>();
//    foreach (var item in input)
//    {
//        result.Add(transformer(item));
//    }
//    return result;
//}

// Question: How does Func simplify the creation and usage of delegates in C#?

/*
 * Func<T, TResult> simplifies delegate creation and usage in C# by providing a built-in, type-safe, 
 * generic delegate that eliminates the need for custom delegate declarations, supports concise lambda
 * expressions, and enables flexible, reusable function definitions for various input and output types.
 */
#endregion

#region Problem:
/*
    o Use Action<T> to create a delegate that takes a string and prints it to the console.
      Implement a function that takes a list of strings and an Action<string> delegate and 
      applies the action to each string in the list.
*/

//int count = InputAndValidate("Enter number of strings (integer): ", false, 1);
//List<string> strings = new List<string>();

//for (int i = 0; i < count; i++)
//{
//    strings.Add(InputAndValidate($"Enter string {i + 1}: ", false, ""));
//}

//Console.WriteLine("\nPrinting strings with default action:");
//ApplyActionToStrings(strings, s => Console.WriteLine(s));

//Console.WriteLine("\nPrinting strings with uppercase action:");
//ApplyActionToStrings(strings, s => Console.WriteLine(s.ToUpper()));

//Console.ReadKey();

//static void ApplyActionToStrings(List<string> strings, Action<string> action)
//{
//    foreach (var s in strings)
//    {
//        action(s);
//    }
//}

// Question: Why is Action preferred for operations that do not return values?

/*
 * Action<T> is preferred for operations that do not return values because it provides a type-safe, 
 * built-in delegate for void methods, eliminating custom delegate declarations, supporting concise lambda
 * expressions, and enabling flexible, reusable code for side-effect operations like printing.
 */
#endregion

#region Problem:
/*
    o Use Predicate<T> to create a delegate that checks if an integer is even. Implement a 
      function that filters a list of integers based on this predicate and returns the list of 
      even numbers.
*/

//int count = InputAndValidate("Enter number of integers (integer): ", false, 1);
//List<int> numbers = new List<int>();

//for (int i = 0; i < count; i++)
//{
//    numbers.Add(InputAndValidate($"Enter integer {i + 1}: ", false, 0));
//}

//Console.WriteLine("\nOriginal integers:");
//Console.WriteLine(string.Join(", ", numbers));

//List<int> evenNumbers = FilterList(numbers, n => n % 2 == 0);
//Console.WriteLine("\nEven integers:");
//Console.WriteLine(string.Join(", ", evenNumbers));

//Console.ReadKey();

//static List<T> FilterList<T>(List<T> input, Predicate<T> predicate)
//{
//    List<T> result = new List<T>();
//    foreach (var item in input)
//    {
//        if (predicate(item))
//        {
//            result.Add(item);
//        }
//    }
//    return result;
//}

// Question: What role do predicates play in functional programming, and how do they enhance code clarity?

/*
 * Predicates, like Predicate<T>, are delegates that return a boolean to test conditions in functional 
 * programming, enabling clear, reusable, and modular filtering logic by separating the condition from 
 * the operation, thus improving code readability and maintainability.
 */
#endregion

#region Problem:
/*
    o Implement a function that filters a list of strings based on a condition provided by an 
      anonymous function. Test with different conditions like strings that start with a specific 
      letter or contain a specific substring.
*/

//int count = InputAndValidate("Enter number of strings (integer): ", false, 1);
//List<string> strings = new List<string>();

//for (int i = 0; i < count; i++)
//{
//    strings.Add(InputAndValidate($"Enter string {i + 1}: ", false, ""));
//}

//Console.WriteLine("\nOriginal strings:");
//Console.WriteLine(string.Join(", ", strings));

//Predicate<string> startsWithA = delegate (string s) { return s.StartsWith("A", StringComparison.OrdinalIgnoreCase); };
//List<string> startsWithAStrings = FilterStrings(strings, startsWithA);
//Console.WriteLine("\nStrings starting with 'A':");
//Console.WriteLine(string.Join(", ", startsWithAStrings));

//Predicate<string> containsTest = delegate (string s) { return s.Contains("test", StringComparison.OrdinalIgnoreCase); };
//List<string> containsTestStrings = FilterStrings(strings, containsTest);
//Console.WriteLine("\nStrings containing 'test':");
//Console.WriteLine(string.Join(", ", containsTestStrings));

//Console.ReadKey();

//static List<string> FilterStrings(List<string> input, Predicate<string> condition)
//{
//    List<string> result = new List<string>();
//    foreach (var s in input)
//    {
//        if (condition(s))
//        {
//            result.Add(s);
//        }
//    }
//    return result;
//}

// Question: How do anonymous functions improve code modularity and customization?

/*
 * Anonymous functions improve code modularity and customization by allowing inline, self-contained logic 
 * definitions without separate method declarations, enabling flexible, reusable functions 
 * like FilterStrings to adapt to various conditions while keeping code concise and maintainable.
 */
#endregion

#region Problem:
/*
    o Implement a function that performs a mathematical operation on two integers using an 
      anonymous function. Test with different operations like addition, subtraction, and 
      multiplication.
*/

//int a = InputAndValidate("Enter first integer: ", false, 0);
//int b = InputAndValidate("Enter second integer: ", false, 0);

//Console.WriteLine($"\nInput numbers: a = {a}, b = {b}");

//Func<int, int, int> add = delegate (int x, int y) { return x + y; };
//Console.WriteLine($"Addition result: {PerformMathOperation(a, b, add)}");

//Func<int, int, int> subtract = delegate (int x, int y) { return x - y; };
//Console.WriteLine($"Subtraction result: {PerformMathOperation(a, b, subtract)}");

//Func<int, int, int> multiply = delegate (int x, int y) { return x * y; };
//Console.WriteLine($"Multiplication result: {PerformMathOperation(a, b, multiply)}");

//Console.ReadKey();

//static int PerformMathOperation(int a, int b, Func<int, int, int> operation)
//{
//    return operation(a, b);
//}

// Question: When should you prefer anonymous functions over named methods in implementing mathematical operations?

/*
 * Anonymous functions are preferred over named methods for mathematical operations when the operation is 
 * simple, used only once, or defined inline for clarity, as they reduce boilerplate, enhance readability 
 * in short-lived contexts, and support functional programming patterns.
 */
#endregion

#region Problem:
/*
    o Implement a function that filters a list of strings based on a condition provided by a 
      lambda expression. Test with conditions like strings that have a length greater than 3 
      or contain the letter 'e'.
*/

//int count = InputAndValidate("Enter number of strings (integer): ", false, 1);
//List<string> strings = new List<string>();

//for (int i = 0; i < count; i++)
//{
//    strings.Add(InputAndValidate($"Enter string {i + 1}: ", false, ""));
//}

//Console.WriteLine("\nOriginal strings:");
//Console.WriteLine(string.Join(", ", strings));

//List<string> longStrings = FilterStrings(strings, s => s.Length > 3);
//Console.WriteLine("\nStrings with length greater than 3:");
//Console.WriteLine(string.Join(", ", longStrings));

//List<string> containsEStrings = FilterStrings(strings, s => s.Contains('e', StringComparison.OrdinalIgnoreCase));
//Console.WriteLine("\nStrings containing 'e':");
//Console.WriteLine(string.Join(", ", containsEStrings));

//Console.ReadKey();

//static List<string> FilterStrings(List<string> input, Predicate<string> condition)
//{
//    List<string> result = new List<string>();
//    foreach (var s in input)
//    {
//        if (condition(s))
//        {
//            result.Add(s);
//        }
//    }
//    return result;
//}

// Question: What makes lambda expressions an essential feature in modern C# programming?

/*
 * Lambda expressions are essential in modern C# programming because they provide concise, inline function 
 * definitions that enhance readability, enable functional programming patterns like filtering and mapping, 
 * and simplify delegate usage in APIs like LINQ, reducing boilerplate and improving code flexibility.
 */
#endregion

#region Problem:
/*
    o Implement a function that performs a mathematical operation on two doubles using a 
      lambda expression. Test with operations like division and exponentiation.
*/

double a = InputAndValidate("Enter first double: ", false, 0.0);
double b = InputAndValidate("Enter second double: ", false, 0.0);

Console.WriteLine($"\nInput numbers: a = {a}, b = {b}");

try
{
    Console.WriteLine($"Division result: {PerformMathOperation(a, b, (x, y) => x / y)}");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

Console.WriteLine($"Exponentiation result: {PerformMathOperation(a, b, (x, y) => Math.Pow(x, y))}");

Console.ReadKey();

static double PerformMathOperation(double a, double b, Func<double, double, double> operation)
{
    return operation(a, b);
}

// Question: How do lambda expressions enhance the expressiveness of mathematical computations in C#?

/*
 * Lambda expressions enhance the expressiveness of mathematical computations in C# by providing concise, 
 * inline function definitions that clearly convey intent, enable flexible and reusable code through 
 * delegates, and integrate seamlessly with functional programming constructs like LINQ.
 */
#endregion