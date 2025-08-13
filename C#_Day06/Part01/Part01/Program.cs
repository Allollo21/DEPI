// Top - Level statement to save some space 
// Tip: Uncomment region code to test and then comment it back

#region InputAndValidate Function
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

#region  Problem:
/*
    o Create a struct Point with X and Y attributes. 
    o Add constructors: default and parameterized. 
    o Override the ToString() method to print the point as (X, Y). 
*/


//int x = InputAndValidate("Enter X coordinate (integer): ", false, -1);
//int y = InputAndValidate("Enter Y coordinate (integer): ", false, -1);

//Point DefaultPoint = new Point();
//Console.WriteLine($"Default Point: {DefaultPoint}");

//Point ParameterizedPoint = new Point(x, y);
//Console.WriteLine($"Parameterized Point: {ParameterizedPoint}");

//Console.ReadKey();

//struct Point
//{
//    public int X { get; set; }
//    public int Y { get; set; }

//    public Point()
//    {
//        X = 0;
//        Y = 0;
//    }

//    public Point(int x, int y)
//    {
//        X = x;
//        Y = y;
//    }

//    public override string ToString()
//    {
//        return $"({X}, {Y})";
//    }
//}

// Question: Why can't a struct inherit from another struct or class in C#? 
/*
 * Because Structs are value types, stored on the stack , with fixed memory. 
 * Inheritance would introduce complexity, such as variable memory sizes, 
 * which conflicts with the lightweight, predictable nature of structs.
 * 
 * And to avoid boxing issues due to the increase of boxing of converting struct into an object 
 * when inheritance is implemented, which causes performance costs. Instead it can inherit from an interface
 * as a way to share behavior.
 * 
 */
#endregion

#region Problem: 
/*
    o Create a class TypeA with attributes F (private), G(internal), and H(public). 
    o Write a program to access these attributes from different parts of the project. 
*/

//int f = InputAndValidate("Enter an integer for F (private): ", false, -1);
//int g = InputAndValidate("Enter an integer for G (internal): ", false, -1);
//int h = InputAndValidate("Enter an integer for H (public): ", false, -1);

//TypeA typeA = new TypeA(f, g, h);

//Console.WriteLine("\nAccessing from within TypeA:");
//typeA.AccessWithinTypeA();

//Console.WriteLine("\nAccessing from TypeB (same assembly):");
//TypeB typeB = new TypeB();
//typeB.AccessFromTypeB(typeA);

///* 
// * If we created another project and tried to access the properties the same way as we have done here
// * with TypeB, We could no access F or G but we would still be able to access H as it is public.
// * 
// * (Did not make because this causes dependencies issues)
// */
//Console.WriteLine($"\nAccessing from different assembly: H={typeA.H}");

//Console.ReadKey();

//public class TypeA
//{
//    private int F;     // Accessible only within TypeA
//    internal int G;    // Accessible within the same assembly
//    public int H;      // Accessible from anywhere

//    public TypeA(int f, int g, int h)
//    {
//        F = f;
//        G = g;
//        H = h;
//    }

//    public void AccessWithinTypeA()
//    {
//        Console.WriteLine($"Accessing within TypeA: F={F}, G={G}, H={H}");
//    }
//}

//class TypeB
//{
//    public void AccessFromTypeB(TypeA typeA)
//    {
//        // F is private, so inaccessible here
//        // Console.WriteLine($"TypeB accessing F: {typeA.F}"); // Error: F is inaccessible
//        Console.WriteLine($"Accessing from TypeB: G={typeA.G}, H={typeA.H}");
//    }
//}

// Question: How do access modifiers impact the scope and visibility of a class member?

/*
 * Access modifiers in C# control the scope and visibility of class members, 
 * determining where they can be accessed:
 * 
 * public: The member is accessible from everywhere, including outside the class and assembly.
 * internal: The member is accessible only within the same assembly.
 * private: The member is accessible only within the declaring class.
 * protected: The member is accessible within the declaring class and derived classes.
 * protected internal: The member is accessible within the same assembly or in derived classes in any assembly.
 * private protected: The member is accessible only within the declaring class and derived classes in the same assembly.
 * 
 */
#endregion

#region Problem: 
/*
    o Define a struct Employee with private attributes (EmpId, Name, Salary). 
    o Use methods (GetName, SetName) and properties to access these attributes. 
    o Write a test program to demonstrate encapsulation in action. 
*/

//int id = InputAndValidate("Enter Employee ID (integer): ", false, -1);
//string? inputName = InputAndValidate("Enter Employee Name: ", true, "Unknown");
//double sal = InputAndValidate<double>("Enter Employee Salary (double): ", false, -1);

//Employee emp = new Employee(id, inputName, sal);
//Console.WriteLine($"\nInitial Employee: {emp}");

//string newName = InputAndValidate("Enter new name for Employee: ", false, "Modified");
//emp.SetName(newName);
//Console.WriteLine($"Updated Employee: {emp}");

//double newSal = InputAndValidate<double>("Enter new Salary: ", false, -1);
//emp.Salary = newSal;
//Console.WriteLine($"Employee after updating Salary: {emp}");
//Console.ReadKey();

//struct Employee
//{
//    private int empId;
//    private string name;
//    private double salary;

//    public Employee(int id, string empName, double sal)
//    {
//        empId = id;
//        name = empName;
//        salary = sal;
//    }

//    public string GetName()
//    {
//        return name;
//    }

//    public void SetName(string newName)
//    {
//        name = newName;
//    }

//    public int EmpId
//    {
//        get { return empId; }
//        set { empId = value; }
//    }

//    public double Salary
//    {
//        get { return salary; }
//        set { salary = value; }
//    }

//    public override string ToString()
//    {
//        return $"Employee ID: {EmpId}, Name: {GetName()}, Salary: {Salary}";
//    }
//}

// Question: Why is encapsulation critical in software design? 

/*
 * Encapsulation is critical in software design because:
 * It hides internal data and implementation details, preventing direct access or modification,
 * which reduces errors and maintains data integrity. By using only necessary interfaces 
 * (methods and properties), it allows changes to internal implementation without affecting external code,
 * improving maintainability and reducing coupling. It enables validation and logic enforcement during 
 * access, ensuring consistent behavior and security. Encapsulation also promotes abstraction by focusing on 
 * what an object does rather than how it does it, leading to cleaner, more intuitive code and 
 * better scalability in large systems.
 */
#endregion

#region Problem: 
/*
    o Define a struct Point with:
         A parameterized constructor initializing X to specific value and Y to 0. 
         A parameterized constructor to set X and Y to specific values. 
    o Write a test program to demonstrate constructor overloading. 
*/

//int x1 = InputAndValidate("Enter X coordinate: ", false, -1);
//int y2 = InputAndValidate("Enter Y coordinate: ", false, -1);

//Point point1 = new Point(x1);
//Console.WriteLine($"Point using single-parameter constructor: {point1}");

//Point point2 = new Point(x1, y2);
//Console.WriteLine($"Point using two-parameter constructor: {point2}");

//Console.ReadKey();

//struct Point
//{
//    public int X { get; set; }
//    public int Y { get; set; }

//    public Point(int x)
//    {
//        X = x;
//        Y = 0;
//    }

//    public Point(int x, int y)
//    {
//        X = x;
//        Y = y;
//    }

//    public override string ToString()
//    {
//        return $"({X}, {Y})";
//    }
//}

// Question: what is constructors in structs ?

/*
 * Constructors in structs are special methods that initialize a struct's fields or properties 
 * when an instance is created, ensuring a valid state. 
 * 
 * They can be parameterized to set specific values, but structs cannot have explicit 
 * parameterless constructors since C# provides a default one that sets fields to their default values
 * (0 for numerical value types, null for reference types).
 * 
 * Constructors must assign all fields before returning, support overloading for flexible initialization,
 * and are invoked with the new keyword, enhancing encapsulation and usability while 
 * preventing uninitialized data.
 */
#endregion

#region Problem:
/*
    o Modify the ToString() method of the Point struct to include custom formatting. 
    o Write a program to test this by creating and printing multiple points. 
*/

//int x1 = InputAndValidate("Enter X for Point 1: ", false, -1);
//int y1 = InputAndValidate("Enter Y for Point 1: ", false, -1);

//Point point1 = new Point(x1, y1);
//Console.WriteLine($"Point 1: {point1}");

//int x2 = InputAndValidate("Enter X for Point 2: ", false, -1);
//int y2 = InputAndValidate("Enter Y for Point 2: ", false, -1);

//Point point2 = new Point(x2, y2);
//Console.WriteLine($"Point 2: {point2}");

//int x3 = InputAndValidate("Enter X for Point 3: ", false, -1);
//int y3 = InputAndValidate("Enter Y for Point 3: ", false, -1);

//Point point3 = new Point(x3, y3);
//Console.WriteLine($"Point 3: {point3}");

//struct Point
//{
//    public int X { get; set; }
//    public int Y { get; set; }

//    public Point(int x, int y)
//    {
//        X = x;
//        Y = y;
//    }

//    public override string ToString()
//    {
//        return $"({X}, {Y})";
//    }
//}

// Question: How does overriding methods like ToString() improve code readability? 

/*
 * Overriding methods like ToString() improves code readability by providing a clear,
 * customized string representation of an object's state, making it easier to understand its contents
 * without needing to inspect individual fields.
 */
#endregion

#region Problem: 
/*
    o Create a struct Point and a class Employee. 
    o Write a program to demonstrate value type (struct) and reference type (class) behavior 
      when passing them to methods. 
*/

//Point point = new Point(10, 20);
//Console.WriteLine($"Original Point: {point}");

//Point pointCopy = point;
//pointCopy.X = 100;
//pointCopy.Y = 100;
//Console.WriteLine($"Modified Point Copy: {pointCopy}");
//Console.WriteLine($"After Modification, Original Point: {point}");

//Employee employee = new Employee(1, "John");
//Console.WriteLine($"\nOriginal Employee: {employee}");

//employee.Id = 999;
//employee.Name = "Modified";
//Console.WriteLine($"After Modification, Employee: {employee}");
//Console.ReadKey();

//struct Point
//{
//    public int X { get; set; }
//    public int Y { get; set; }

//    public Point(int x, int y)
//    {
//        X = x;
//        Y = y;
//    }

//    public override string ToString()
//    {
//        return $"({X}, {Y})";
//    }
//}

//class Employee
//{
//    public int Id { get; set; }
//    public string Name { get; set; }

//    public Employee(int id, string name)
//    {
//        Id = id;
//        Name = name;
//    }

//    public override string ToString()
//    {
//        return $"Employee ID: {Id}, Name: {Name}";
//    }
//}

// Question: How does memory allocation differ for structs and classes in C#?

/*
 * Structs (value types) are typically allocated on the stack or inline within objects on the heap,
 * with copy-by-value behavior where modifications to a copy don’t affect the original.
 * 
 * Classes (reference types) are allocated on the heap with stack-based references,
 * using copy-by-reference behavior where changes to the object’s fields, affect all references.
 * 
 * Structs are fast and suited for small, immutable data but incur copying costs, 
 * while classes support complex objects with inheritance but involve garbage collection overhead.
 */

#endregion
