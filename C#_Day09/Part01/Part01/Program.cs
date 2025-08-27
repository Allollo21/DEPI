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
    o Create an enum called Weekdays with values Monday = 1, Tuesday, Wednesday, 
      Thursday, Friday. 
    o Write a program to print the name and value of each day. 
*/

//Console.WriteLine("Weekdays and their values:");
//foreach (Weekdays day in Enum.GetValues(typeof(Weekdays)))
//{
//    Console.WriteLine($"{day}, {(int)day}");
//}

//Console.ReadKey();

//enum Weekdays
//{
//    Monday = 1,
//    Tuesday,
//    Wednesday,
//    Thursday,
//    Friday
//}

// Question: Why is it recommended to explicitly assign values to enum members in some cases? 

/*
 * To control over values as it ensures specific, predictable integer values for enum members, which is
 * critical when interfacing with external systems, databases, or APIs that expect specific numeric
 * values (e.g., Monday = 1 to match a database convention).
 * 
 * To prevent non-zero start or gaps as it allows custom numbering schemes, such as starting at 1 
 * (as in Weekdays) or using non-sequential values to represent specific states, 
 * which the default zero-based auto-incrementing may not support.
 */
#endregion

#region Problem:
/*
    o Modify the Grades enum from the demo to use short as its underlying type and set F to -1. 
    o Write code to print all grade values and their names. 
*/

//Console.WriteLine("Grades and their values:");
//foreach (Grades grade in Enum.GetValues(typeof(Grades)))
//{
//    Console.WriteLine($"{grade}, {(short)grade}");
//}

//Console.ReadKey();

//enum Grades : short
//{
//    A = 4,
//    B = 3,
//    C = 2,
//    D = 1,
//    F = -1
//}

// Question: What happens if you assign a value to an enum member that exceeds the underlying type's range? 

/*
 * If you assign a value to an enum member that exceeds the underlying type's range, 
 * the C# compiler will throw a compilation error. This strict type checking enforces type safety, 
 * preventing runtime errors from invalid enum values.
 */
#endregion

#region Problem:
/*
    o Add a Department property to the Person class. 
    o Instantiate two Person objects and assign different departments. 
    o Print their details. 
*/

//string name1 = InputAndValidate("Enter Name for Person 1: ", true, "Unknown");
//int age1 = InputAndValidate("Enter Age for Person 1: ", false, -1);
//string dept1 = InputAndValidate("Enter Department for Person 1: ", true, "Unknown");

//string name2 = InputAndValidate("Enter Name for Person 2: ", true, "Unknown");
//int age2 = InputAndValidate("Enter Age for Person 2: ", false, -1);
//string dept2 = InputAndValidate("Enter Department for Person 2: ", true, "Unknown");

//Person person1 = new Person(name1, age1, dept1);
//Person person2 = new Person(name2, age2, dept2);

//Console.WriteLine("\nPerson 1 Details:");
//Console.WriteLine(person1);

//Console.WriteLine("\nPerson 2 Details:");
//Console.WriteLine(person2);

//Console.ReadKey();

//class Person
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//    public virtual string Department { get; set; }

//    public Person(string name, int age, string department)
//    {
//        Name = name;
//        Age = age;
//        Department = department;
//    }

//    public override string ToString()
//    {
//        return $"Name: {Name}, Age: {Age}, Department: {Department}";
//    }
//}

// Question: What is the purpose of the virtual keyword when used with properties?

/*
 * The virtual keyword, when used with properties in C#, serves Polymorphism.
 * 
 * It allows a property in a base class to be overridden in a derived class, enabling derived classes to
 * provide their own implementation of the property’s  get or set behavior.
 */
#endregion

#region Problem:
/*
    o Extend the Child class to include a method DisplaySalary that uses the sealed Salary 
      property. 
    o Instantiate the class and demonstrate the use of this method. 
*/

//string name = InputAndValidate("Enter Child's Name: ", true, "Unknown");
//double salary = InputAndValidate<double>("Enter Child's Salary: ", false, -1.0);

//Child child = new Child(name, salary);
//Console.WriteLine("\nChild Details:");
//child.DisplaySalary();

//Console.ReadKey();

//abstract class Person
//{
//    public string Name { get; set; }
//    public virtual double Salary { get; set; }

//    public Person(string name)
//    {
//        Name = name;
//    }
//}

//class Child : Person
//{
//    private double salary;

//    public Child(string name, double salary) : base(name)
//    {
//        this.salary = salary;
//    }

//    public sealed override double Salary
//    {
//        get { return salary; }
//        set
//        {
//            if (value >= 0)
//                salary = value;
//            else
//                throw new ArgumentException("Salary cannot be negative.");
//        }
//    }

//    public void DisplaySalary()
//    {
//        Console.WriteLine($"Name: {Name}, Salary: {Salary:C}");
//    }
//}

// Question: Why can’t you override a sealed property or method?

/*
 * A sealed property or method cannot be overridden because:
 * The `sealed` keyword, when used in an overridden property or method in a
 * derived class, explicitly prevents further overriding in any classes that inherit from it.
 * This ensures the implementation is final and cannot be modified by subclasses.
 * 
 * It allows the developer to enforce a specific behavior or implementation,
 * preventing unintended changes in derived classes that could break the intended functionality or
 * contract.
 */
#endregion

#region Problem:
/*
    o Write a static method in the Utility class to calculate the perimeter of a rectangle. 
    o Call it without creating an instance of the class.
*/

//double width = InputAndValidate<double>("Enter Rectangle Width: ", false, -1.0);
//double height = InputAndValidate<double>("Enter Rectangle Height: ", false, -1.0);

//double perimeter = Utility.CalculateRectanglePerimeter(width, height);
//Console.WriteLine($"\nRectangle Perimeter: {perimeter:F2}");

//Console.ReadKey();

//class Utility
//{
//    public static double CalculateRectanglePerimeter(double width, double height)
//    {
//        return 2 * (width + height);
//    }
//}

// Question: What is the key difference between static and object members?

/*
 * The key difference between static and object members in C# is:
 * 
 * Static Members: Belong to the class itself, not to any specific instance. They are shared across
 * all instances and can be accessed without creating an object. Suitable for utility functions or shared 
 * data that do not depend on instance-specific state.
 * 
 * Object Members: Belong to an instance of the class and require an object to be instantiated to
 * access them. They are tied to the specific state of an object and are used for instance-specific data
 * or behavior.
 * 
 * Static members cannot access non-static (instance) members directly, as they do not have a `this`
 * reference to an instance. Object members can access both static and instance members, as they are tied
 * to a specific object.
 */
#endregion

#region Problem:
/*
    o Modify the ComplexNumber class to add operator overloading for the multiplication (*) 
      operator. 
    o Demonstrate it with two complex numbers. 
*/

//double real1 = InputAndValidate<double>("Enter real part for Complex Number 1: ", false, 0.0);
//double imag1 = InputAndValidate<double>("Enter imaginary part for Complex Number 1: ", false, 0.0);
//double real2 = InputAndValidate<double>("Enter real part for Complex Number 2: ", false, 0.0);
//double imag2 = InputAndValidate<double>("Enter imaginary part for Complex Number 2: ", false, 0.0);

//ComplexNumber num1 = new ComplexNumber(real1, imag1);
//ComplexNumber num2 = new ComplexNumber(real2, imag2);
//ComplexNumber result = num1 * num2;

//Console.WriteLine("\nComplex Number 1: " + num1);
//Console.WriteLine("Complex Number 2: " + num2);
//Console.WriteLine("Product (num1 * num2): " + result);

//Console.ReadKey();

//class ComplexNumber
//{
//    public double Real { get; set; }
//    public double Imaginary { get; set; }

//    public ComplexNumber(double real, double imaginary)
//    {
//        Real = real;
//        Imaginary = imaginary;
//    }

//    public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
//    {
//        // (a + bi) * (c + di) = (ac - bd) + (ad + bc)i
//        double realPart = (a.Real * b.Real) - (a.Imaginary * b.Imaginary);
//        double imaginaryPart = (a.Real * b.Imaginary) + (a.Imaginary * b.Real);
//        return new ComplexNumber(realPart, imaginaryPart);
//    }

//    public override string ToString()
//    {
//        return $"{Real:F2} {(Imaginary >= 0 ? "+" : "-")} {Math.Abs(Imaginary):F2}i";
//    }
//}

// Question: Can you overload all operators in C#? Explain why or why not.

/*
 * Not all operators in C# can be overloaded. The reasons are:
 * Restricted Operators: C# allows overloading of specific operators, such as arithmetic (+, -, *, /, %),
 * comparison (==, !=, <, >, <=, >=), logical (&, |, ^, !), and others like ++, --, and implicit/explicit
 * conversions. However, certain operators cannot be overloaded, including:
 * Assignment operators (e.g., =, +=, -=).
 * Member access (.), indexing ([]), cast ((T)), sizeof, typeof, is, as, nameof, and others.
 * Conditional operators (&&, ||), which can be indirectly influenced by overloading & and |.
 * 
 */
#endregion

#region Problem:
/*
    o Modify the Gender enum to use byte as its underlying type. 
    o Write a program to demonstrate its memory usage compared to the default int. 
*/

//Console.WriteLine("Gender Enum (byte-based) Values and Memory Usage:");
//foreach (GenderByte gender in Enum.GetValues(typeof(GenderByte)))
//{
//    Console.WriteLine($"Gender: {gender}, Value: {(byte)gender}");
//}
//Console.WriteLine($"Memory usage of GenderByte (byte): {sizeof(GenderByte)} byte(s)");

//Console.WriteLine("\nGender Enum (int-based) Values and Memory Usage:");
//foreach (GenderInt gender in Enum.GetValues(typeof(GenderInt)))
//{
//    Console.WriteLine($"Gender: {gender}, Value: {(int)gender}");
//}
//Console.WriteLine($"Memory usage of GenderInt (int): {sizeof(GenderInt)} byte(s)");

//Console.ReadKey();

//enum GenderByte : byte
//{
//    Male = 1,
//    Female = 2,
//    Other = 3
//}

//enum GenderInt
//{
//    Male = 1,
//    Female = 2,
//    Other = 3
//}

// Question: When should you consider changing the underlying type of an enum?

/*
 * You should consider changing the underlying type of an enum in:
 * 
 * Memory Optimization: When memory usage is critical, such as in large data structures or embedded
 * systems, a smaller type like byte (1 byte) can reduce memory footprint compared to the default int
 * (4 bytes), as shown in the program where GenderByte uses 1 byte versus 4 bytes for GenderInt.  
 */
#endregion

#region Problem:
/*
    o Create a static method in the Utility class to convert temperatures between Celsius and 
      Fahrenheit. 
    o Write code to demonstrate its usage. 
*/

//double celsius = InputAndValidate<double>("Enter temperature in Celsius: ", false, 0.0);
//double fahrenheit = Utility.ConvertCelsiusToFahrenheit(celsius);
//Console.WriteLine($"\n{celsius:F2}°C is {fahrenheit:F2}°F");

//double fahrenheitInput = InputAndValidate<double>("Enter temperature in Fahrenheit: ", false, 0.0);
//double celsiusOutput = Utility.ConvertFahrenheitToCelsius(fahrenheitInput);
//Console.WriteLine($"{fahrenheitInput:F2}°F is {celsiusOutput:F2}°C");

//Console.ReadKey();

//static class Utility
//{
//    public static double ConvertCelsiusToFahrenheit(double celsius)
//    {
//        return (celsius * 9 / 5) + 32;
//    }

//    public static double ConvertFahrenheitToCelsius(double fahrenheit)
//    {
//        return (fahrenheit - 32) * 5 / 9;
//    }
//}

// Question: Why can't a static class have instance constructors?

/*
 * A static class is designed to contain only static members (methods, properties, fields) and cannot be 
 * instantiated. Instance constructors are used to create and initialize instances of a class, which is 
 * incompatible with a static class’s purpose of providing shared, class-level functionality 
 * without instances.
 * 
 */
#endregion

#region Problem:
/*
    o Write a program that tries to parse a string to a Grades enum value. 
    o Use Enum.TryParse to handle invalid inputs gracefully. 
*/

//string input = InputAndValidate("Enter a grade (A, B, C, D, F): ", false, "");
//bool success = Enum.TryParse<Grades>(input, true, out Grades grade);

//if (success)
//{
//    Console.WriteLine($"\nSuccessfully parsed '{input}' to Grade: {grade}, Value: {(short)grade}");
//}
//else
//{
//    Console.WriteLine($"\nFailed to parse '{input}' as a valid Grades enum value.");
//}

//Console.WriteLine("\nValid Grades and their values for reference:");
//foreach (Grades g in Enum.GetValues(typeof(Grades)))
//{
//    Console.WriteLine($"Grade: {g}, Value: {(short)g}");
//}

//Console.ReadKey();

//enum Grades : short
//{
//    A = 4,
//    B = 3,
//    C = 2,
//    D = 1,
//    F = -1
//}

// Question: What are the advantages of using Enum.TryParse over direct parsing with int.Parse?

/*
 * Type Safety as Enum.TryParse directly parses a string to the target enum type ,
 * ensuring the result is a valid enum member or indicating failure. int.Parse only parses to an
 * integer, which may not correspond to a valid enum value, risking invalid states.
 *   
 * Enum.TryParse can parse both string names (e.g., "A" to Grades.A) and numeric strings 
 * (e.g., "4" to Grades.A), with an option to ignore case. int.Parse only handles numeric strings,
 * limiting its flexibility for enum names.
 */
#endregion

#region Problem:
/*
    o Enhance the Employee class to include Equals method. 
    o Demonstrate the correct usage of Equals when searching for an employee object in an array using Helper2<Employee>.SearchArray. 
*/

//Employee[] employees = new Employee[3];
//employees[0] = new Employee(1, "Ali Reda");
//employees[1] = new Employee(2, "Mohamed Ahmed");
//employees[2] = new Employee(3, "Ismail Hany");

//int searchId = InputAndValidate("Enter Employee ID to search: ", false, -1);
//string searchName = InputAndValidate("Enter Employee Name to search: ", true, "Unknown");
//Employee searchEmployee = new Employee(searchId, searchName);

//int index = Helper2<Employee>.SearchArray(employees, searchEmployee);

//Console.WriteLine("\nSearch Result:");
//if (index >= 0)
//{
//    Console.WriteLine($"Employee found at index {index}: {employees[index]}");
//}
//else
//{
//    Console.WriteLine($"Employee with ID {searchId} and Name {searchName} not found.");
//}

//Console.ReadKey();

//class Employee
//{
//    public int Id { get; set; }
//    public string Name { get; set; }

//    public Employee(int id, string name)
//    {
//        Id = id;
//        Name = name;
//    }

//    public override bool Equals(object obj)
//    {
//        if (obj == null || GetType() != obj.GetType())
//            return false;

//        Employee other = (Employee)obj;
//        return Id == other.Id && Name == other.Name;
//    }

//    public override int GetHashCode()
//    {
//        return HashCode.Combine(Id, Name);
//    }

//    public override string ToString()
//    {
//        return $"Employee [ID: {Id}, Name: {Name}]";
//    }
//}

//static class Helper2<T>
//{
//    public static int SearchArray(T[] array, T item)
//    {
//        if (array == null || item == null)
//            return -1;

//        for (int i = 0; i < array.Length; i++)
//        {
//            if (array[i] != null && array[i].Equals(item))
//                return i;
//        }
//        return -1;
//    }
//}

// Question: What is the difference between overriding Equals and == for object comparison in C# struct and class?

/*
 * - Equals Method:
 *      For classes, the default Equals checks reference equality (same object instance). Overriding
 *      Equals allows custom value-based comparison .
 *      For structs, the default Equals performs a value-based comparison of all fields (bit-by-bit).
 *      Overriding Equals allows optimization or custom logic.
 *      
 * - Overriding Equals requires overriding GetHashCode for consistency in hash-based collections.
 * 
 * - == Operator:
 *     Overloading == allows custom comparison logic for both classes and structs but is separate from
 *     Equals. It’s typically used for natural, concise syntax.
 *     
 * - Unlike `Equals`, overloading `==` requires overloading `!=` for consistency.
 */

// Question: Why is overriding ToString beneficial when working with custom classes?

/*
 * Provides a meaningful string representation of the object instead of the default type name, 
 * improving debugging and logging.
 * 
 */
#endregion

#region Problem:
/*
    o Write a generic method Max in the Helper class that takes two arguments and returns the 
      greater value. 
    o Demonstrate the usage of this method with integers, doubles, and strings. 
*/

//int int1 = InputAndValidate("Enter first integer: ", false, 0);
//int int2 = InputAndValidate("Enter second integer: ", false, 0);
//double double1 = InputAndValidate<double>("Enter first double: ", false, 0.0);
//double double2 = InputAndValidate<double>("Enter second double: ", false, 0.0);
//string str1 = InputAndValidate("Enter first string: ", false, "");
//string str2 = InputAndValidate("Enter second string: ", false, "");

//Console.WriteLine($"\nMax of {int1} and {int2} is: {Helper.Max(int1, int2)}");
//Console.WriteLine($"Max of {double1:F2} and {double2:F2} is: {Helper.Max(double1, double2):F2}");
//Console.WriteLine($"Max of '{str1}' and '{str2}' is: {Helper.Max(str1, str2)}");

//Console.ReadKey();

//static class Helper
//{
//    public static T Max<T>(T a, T b) where T : IComparable<T>
//    {
//        if (a == null || b == null)
//            throw new ArgumentNullException("Arguments cannot be null.");
//        return a.CompareTo(b) >= 0 ? a : b;
//    }
//}

// Question: Can generics be constrained to specific types in C#? Provide an example.

/*
 * Yes, generics in C# can be constrained to specific types using the where clause to restrict the type
 * parameters to certain types, interfaces, or behaviors. Constraints ensure that the generic type meets
 * specific requirements, enabling safe and type-specific operations within the generic method or class.
 * 
 * Common Constraints:
 * - where T : class: Restricts T to reference types.
 * - where T : struct: Restricts T to value types.
 * - where T : SomeClass: Restricts T to a specific class or its derived types.
 * - where T : ISomeInterface: Restricts T to types implementing the specified interface.
 * - where T : new(): Requires T to have a parameterless constructor.
 * 
 * Example:
 * In the `Helper.Max<T>` method, the constraint where T : IComparable<T> ensures that the type T
 * implements the IComparable<T> interface, allowing the CompareTo method to be called for
 * comparison. This enables the method to work with types like int, double, and string, which
 * implement IComparable<T>, while preventing use with types that cannot be compared.
 * 
 */
#endregion

#region Problem:
/*
    o Add a new method ReplaceArray in the Helper2<T> class that replaces all occurrences of a 
      specified value in an array with another value. 
    o Demonstrate with both integer and string arrays. 
*/

//int[] intArray = { 1, 2, 3, 2, 4, 2, 5 };
//string[] stringArray = { "apple", "banana", "apple", "cherry", "apple" };

//Console.WriteLine("Original Integer Array: " + string.Join(", ", intArray));
//int oldInt = InputAndValidate("Enter integer to replace: ", false, 0);
//int newInt = InputAndValidate("Enter new integer: ", false, 0);
//Helper2<int>.ReplaceArray(intArray, oldInt, newInt);
//Console.WriteLine("Modified Integer Array: " + string.Join(", ", intArray));

//Console.WriteLine("\nOriginal String Array: " + string.Join(", ", stringArray));
//string oldString = InputAndValidate("Enter string to replace: ", false, "");
//string newString = InputAndValidate("Enter new string: ", false, "");
//Helper2<string>.ReplaceArray(stringArray, oldString, newString);
//Console.WriteLine("Modified String Array: " + string.Join(", ", stringArray));

//Console.ReadKey();

//static class Helper2<T>
//{
//    public static int SearchArray(T[] array, T item)
//    {
//        if (array == null || item == null)
//            return -1;

//        for (int i = 0; i < array.Length; i++)
//        {
//            if (array[i] != null && array[i].Equals(item))
//                return i;
//        }
//        return -1;
//    }

//    public static void ReplaceArray(T[] array, T oldValue, T newValue)
//    {
//        if (array == null)
//            throw new ArgumentNullException(nameof(array));

//        for (int i = 0; i < array.Length; i++)
//        {
//            if (array[i] != null && array[i].Equals(oldValue))
//            {
//                array[i] = newValue;
//            }
//        }
//    }
//}

// Question: What are the key differences between generic methods and generic classes?

/*
 * Scope of Generics:
 * 
 *     Generic Methods: A single method within a class (static or instance) is defined with a type
 *     parameter. The generic type applies only to that method, allowing flexibility within a 
 *     non-generic or generic class.
 *     
 *     Generic Classes: The entire class is defined with a type parameter, and all members can use the 
 *     type parameter. The type is specified when instantiating the class.
 *     
 */
#endregion

#region Problem:
/*
    o Write a non-generic Swap method for a custom struct Rectangle with properties Length and 
      Width. 
    o Create instances of Rectangle and demonstrate swapping their values. 
*/

//double length1 = InputAndValidate<double>("Enter Length for Rectangle 1: ", false, -1.0);
//double width1 = InputAndValidate<double>("Enter Width for Rectangle 1: ", false, -1.0);
//double length2 = InputAndValidate<double>("Enter Length for Rectangle 2: ", false, -1.0);
//double width2 = InputAndValidate<double>("Enter Width for Rectangle 2: ", false, -1.0);

//Rectangle rect1 = new Rectangle(length1, width1);
//Rectangle rect2 = new Rectangle(length2, width2);

//Console.WriteLine("\nBefore Swapping:");
//Console.WriteLine($"Rectangle 1: {rect1}");
//Console.WriteLine($"Rectangle 2: {rect2}");

//Rectangle.Swap(ref rect1, ref rect2);

//Console.WriteLine("\nAfter Swapping:");
//Console.WriteLine($"Rectangle 1: {rect1}");
//Console.WriteLine($"Rectangle 2: {rect2}");

//Console.ReadKey();

//struct Rectangle
//{
//    public double Length { get; set; }
//    public double Width { get; set; }

//    public Rectangle(double length, double width)
//    {
//        Length = length;
//        Width = width;
//    }

//    public static void Swap(ref Rectangle rect1, ref Rectangle rect2)
//    {
//        Rectangle temp = rect1;
//        rect1 = rect2;
//        rect2 = temp;
//    }

//    public override string ToString()
//    {
//        return $"Length: {Length:F2}, Width: {Width:F2}";
//    }
//}

// Question: Why might using a generic swap method be preferable to implementing custom methods for each type?

/*
 * A generic swap method works with any type, eliminating the need to write separate swap methods for 
 * each struct or class, reducing code duplication.
 * 
 * Changes or bug fixes need to be applied only once in the generic method, rather
 * than in multiple type-specific methods, simplifying maintenance and reducing errors.
 */
#endregion

#region Problem:
/*
    o Create a Department class and use it to add a Department property to the Employee class. 
    o Demonstrate searching an array of employees by department using the SearchArray method.
*/

//Department hr = new Department(1, "Human Resources");
//Department it = new Department(2, "Information Technology");

//Employee[] employees = new Employee[4];
//employees[0] = new Employee(1, "Ali Reda", hr);
//employees[1] = new Employee(2, "Mohamed Ahmed", it);
//employees[2] = new Employee(3, "Ismail Hany", hr);
//employees[3] = new Employee(4, "Abdelrahman Sherif", it);

//int searchDeptId = InputAndValidate("Enter Department ID to search: ", false, -1);
//string searchDeptName = InputAndValidate("Enter Department Name to search: ", true, "Unknown");
//Department searchDept = new Department(searchDeptId, searchDeptName);

//Employee searchEmployee = new Employee(0, "", searchDept);
//List<int> indices = Helper2<Employee>.SearchArray(employees, searchEmployee);

//Console.WriteLine("\nSearch Result:");
//if (indices.Count > 0)
//{
//    foreach (int index in indices)
//    {
//        Console.WriteLine($"Employee at index {index}: {employees[index]}");
//    }
//}
//else
//{
//    Console.WriteLine($"No employees found in Department [ID: {searchDeptId}, Name: {searchDeptName}].");
//}

//Console.WriteLine("\nAll Employees for Reference:");
//foreach (var emp in employees)
//{
//    Console.WriteLine(emp);
//}

//Console.ReadKey();

//class Department
//{
//    public int Id { get; set; }
//    public string Name { get; set; }

//    public Department(int id, string name)
//    {
//        Id = id;
//        Name = name;
//    }

//    public override bool Equals(object obj)
//    {
//        if (obj == null || GetType() != obj.GetType())
//            return false;

//        Department other = (Department)obj;
//        return Id == other.Id && Name == other.Name;
//    }

//    public override int GetHashCode()
//    {
//        return HashCode.Combine(Id, Name);
//    }

//    public override string ToString()
//    {
//        return $"Department [ID: {Id}, Name: {Name}]";
//    }
//}

//class Employee
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public Department Department { get; set; }

//    public Employee(int id, string name, Department department)
//    {
//        Id = id;
//        Name = name;
//        Department = department;
//    }

//    public override bool Equals(object obj)
//    {
//        if (obj == null || GetType() != obj.GetType())
//            return false;

//        Employee other = (Employee)obj;
//        return Department.Equals(other.Department);
//    }

//    public override int GetHashCode()
//    {
//        return Department.GetHashCode();
//    }

//    public override string ToString()
//    {
//        return $"Employee [ID: {Id}, Name: {Name}, {Department}]";
//    }
//}

//static class Helper2<T>
//{
//    public static List<int> SearchArray(T[] array, T item)
//    {
//        List<int> indices = new List<int>();
//        if (array == null || item == null)
//            return indices;

//        for (int i = 0; i < array.Length; i++)
//        {
//            if (array[i] != null && array[i].Equals(item))
//                indices.Add(i);
//        }
//        return indices;
//    }
//}

// Question: How can overriding Equals for the Department class improve the accuracy of searches?

/*
 * The overridden Equals method compares Department`objects based on their Id and Name properties, 
 * ensuring that two departments are considered equal only if both attributes match, rather than relying 
 * on default reference equality (same object instance).
 * 
 * In the Employee class, Equals uses Department.Equals to compare employees based on their Department. 
 * This ensures Helper2<Employee>.SearchArray finds employees in the same department  
 * even if they are different Department object instances, improving search accuracy.
 */
#endregion

#region Problem:
/*
    o Create a custom struct Circle with properties Radius and Color. 
    o Compare its instances using both == and Equals. 
    o Demonstrate the difference in behavior when the same operations are performed 
      on instances of a Circle class.
*/

//double radius1 = InputAndValidate<double>("Enter Radius for Circle 1: ", false, -1.0);
//string color1 = InputAndValidate("Enter Color for Circle 1: ", true, "Unknown");
//double radius2 = InputAndValidate<double>("Enter Radius for Circle 2: ", false, -1.0);
//string color2 = InputAndValidate("Enter Color for Circle 2: ", true, "Unknown");

//CircleStruct circleStruct1 = new CircleStruct(radius1, color1);
//CircleStruct circleStruct2 = new CircleStruct(radius2, color2);
//CircleClass circleClass1 = new CircleClass(radius1, color1);
//CircleClass circleClass2 = new CircleClass(radius2, color2);

//Console.WriteLine("\nCircle Struct Comparison:");
//Console.WriteLine($"CircleStruct1: {circleStruct1}");
//Console.WriteLine($"CircleStruct2: {circleStruct2}");
//Console.WriteLine($"Using ==: {circleStruct1 == circleStruct2}");
//Console.WriteLine($"Using Equals: {circleStruct1.Equals(circleStruct2)}");

//Console.WriteLine("\nCircle Class Comparison:");
//Console.WriteLine($"CircleClass1: {circleClass1}");
//Console.WriteLine($"CircleClass2: {circleClass2}");
//Console.WriteLine($"Using ==: {circleClass1 == circleClass2}");
//Console.WriteLine($"Using Equals: {circleClass1.Equals(circleClass2)}");

//Console.WriteLine("\nReference Equality for Class (same instance):");
//CircleClass circleClass3 = circleClass1;
//Console.WriteLine($"CircleClass1 and CircleClass3 (same instance): {circleClass1 == circleClass3} (==), {circleClass1.Equals(circleClass3)} (Equals)");

//Console.ReadKey();

//struct CircleStruct
//{
//    public double Radius { get; set; }
//    public string Color { get; set; }

//    public CircleStruct(double radius, string color)
//    {
//        Radius = radius > 0 ? radius : 0;
//        Color = color;
//    }

//    public static bool operator ==(CircleStruct left, CircleStruct right)
//    {
//        return left.Equals(right);
//    }

//    public static bool operator !=(CircleStruct left, CircleStruct right)
//    {
//        return !left.Equals(right);
//    }

//    public override bool Equals(object obj)
//    {
//        if (obj is CircleStruct other)
//        {
//            return Radius == other.Radius && Color == other.Color;
//        }
//        return false;
//    }

//    public override int GetHashCode()
//    {
//        return HashCode.Combine(Radius, Color);
//    }

//    public override string ToString()
//    {
//        return $"CircleStruct [Radius: {Radius:F2}, Color: {Color}]";
//    }
//}

//class CircleClass
//{
//    public double Radius { get; set; }
//    public string Color { get; set; }

//    public CircleClass(double radius, string color)
//    {
//        Radius = radius > 0 ? radius: 0;
//        Color = color;
//    }

//    public static bool operator ==(CircleClass left, CircleClass right)
//    {
//        if (ReferenceEquals(left, null) && ReferenceEquals(right, null))
//            return true;
//        if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
//            return false;
//        return left.Equals(right);
//    }

//    public static bool operator !=(CircleClass left, CircleClass right)
//    {
//        return !(left == right);
//    }

//    public override bool Equals(object obj)
//    {
//        if (obj == null || GetType() != obj.GetType())
//            return false;
//        CircleClass other = (CircleClass)obj;
//        return Radius == other.Radius && Color == other.Color;
//    }

//    public override int GetHashCode()
//    {
//        return HashCode.Combine(Radius, Color);
//    }

//    public override string ToString()
//    {
//        return $"CircleClass [Radius: {Radius:F2}, Color: {Color}]";
//    }
//}

// Question: Why is == not implemented by default for structs?

/*
 * The == operator is not implemented by default for C# structs primarily to avoid implicitly hiding a slow,
 * potentially ambiguous operation behind a common operator. Unlike classes, which perform a fast 
 * reference check, a default comparison for structs would likely need to use reflection to compare 
 * every field, a much slower process. Additionally, for structs containing complex types like classes, 
 * it would be ambiguous whether to compare references or values. Therefore, C# requires developers to 
 * explicitly define the == operator for structs, encouraging a faster, clearer, and type-specific 
 * implementation. For structs where automatic, value-based equality is desired, C# 10 introduced record 
 * struct, which handles this boilerplate code.
 */
#endregion
