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
    o Create an interface IVehicle with methods StartEngine() and StopEngine(). 
    o Implement this interface in two classes: Car and Bike. 
    o Write a program to demonstrate this design by calling the methods on IVehicle objects. 
*/

//IVehicle car = new Car();
//IVehicle bike = new Bike();

//Console.WriteLine("\nTesting Car:");
//car.StartEngine();
//car.StopEngine();

//Console.WriteLine("\nTesting Bike:");
//bike.StartEngine();
//bike.StopEngine();

//Console.ReadKey();

//interface IVehicle
//{
//    void StartEngine();
//    void StopEngine();
//}

//class Car : IVehicle
//{
//    public void StartEngine()
//    {
//        Console.WriteLine($"Car engine started!");
//    }

//    public void StopEngine()
//    {
//        Console.WriteLine($"Car engine stopped!");
//    }
//}

//class Bike : IVehicle
//{
//    public void StartEngine()
//    {
//        Console.WriteLine($"Bike engine started!");
//    }

//    public void StopEngine()
//    {   
//        Console.WriteLine($"Bike engine stopped!");
//    }
//}

// Question: Why is it better to code against an interface rather than a concrete class? 

/*
 * Coding against an interface rather than a concrete class is better because it promotes flexibility,
 * loose coupling, and extensibility. Interfaces define a contract without implementation details,
 * allowing different classes to implement the same behavior in varied ways. This enables polymorphism,
 * where code can work with any class implementing the interface, making it easier to swap or extend
 * implementations without changing the calling code. It also enhances testability by allowing mock objects
 * and supports maintainability by isolating changes to specific implementations, reducing dependency on
 * concrete class details.
 */
#endregion

#region Problem:
/*
    o Create an abstract class Shape with an abstract method GetArea() and a non-abstract method Display(). 
    o Implement this class in Rectangle and Circle classes. 
    o Write a program to compare Shape's abstract class with an interface-based approach. 
*/

//double rectWidth = InputAndValidate<double>("Enter Rectangle Width: ", false, -1.0);
//double rectHeight = InputAndValidate<double>("Enter Rectangle Height: ", false, -1.0);
//double circleRadius = InputAndValidate<double>("Enter Circle Radius: ", false, -1.0);

//Shape rectangle = new Rectangle(rectWidth, rectHeight);
//Shape circle = new Circle(circleRadius);

//Console.WriteLine("\nUsing Abstract Class Approach:");
//rectangle.Display();
//Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");
//circle.Display();
//Console.WriteLine($"Circle Area: {circle.GetArea()}");

//IShape interfaceRectangle = new InterfaceRectangle(rectWidth, rectHeight);
//IShape interfaceCircle = new InterfaceCircle(circleRadius);

//Console.WriteLine("\nUsing Interface Approach:");
//interfaceRectangle.Display();
//Console.WriteLine($"Interface Rectangle Area: {interfaceRectangle.GetArea()}");
//interfaceCircle.Display();
//Console.WriteLine($"Interface Circle Area: {interfaceCircle.GetArea()}");

//Console.ReadKey();

//abstract class Shape
//{
//    public abstract double GetArea();
//    public void Display()
//    {
//        Console.WriteLine($"This is a {GetType().Name} with area: {GetArea()}");
//    }
//}

//class Rectangle : Shape
//{
//    private double Width { get; set; }
//    private double Height { get; set; }

//    public Rectangle(double width, double height)
//    {
//        Width = width;
//        Height = height;
//    }

//    public override double GetArea()
//    {
//        return Width * Height;
//    }
//}

//class Circle : Shape
//{
//    private double Radius { get; set; }

//    public Circle(double radius)
//    {
//        Radius = radius;
//    }

//    public override double GetArea()
//    {
//        return Math.PI * Radius * Radius;
//    }
//}

//interface IShape
//{
//    double GetArea();
//    void Display();
//}

//class InterfaceRectangle : IShape
//{
//    private double Width { get; set; }
//    private double Height { get; set; }

//    public InterfaceRectangle(double width, double height)
//    {
//        Width = width;
//        Height = height;
//    }

//    public double GetArea()
//    {
//        return Width * Height;
//    }

//    public void Display()
//    {
//        Console.WriteLine($"This is an InterfaceRectangle with area: {GetArea()}");
//    }
//}

//class InterfaceCircle : IShape
//{
//    private double Radius { get; set; }

//    public InterfaceCircle(double radius)
//    {
//        Radius = radius;
//    }

//    public double GetArea()
//    {
//        return Math.PI * Radius * Radius;
//    }

//    public void Display()
//    {
//        Console.WriteLine($"This is an InterfaceCircle with area: {GetArea()}");
//    }
//}

// Question: When should you prefer an abstract class over an interface? 

/*
 * Prefer an abstract class over an interface when you need to provide shared implementation or default
 * behavior for derived classes, as abstract classes can include non-abstract methods, fields, 
 * or properties, while interfaces only define a contract without implementation.
 * 
 * When uou want to define shared state (fields or properties) that derived classes can inherit, which 
 * interfaces cannot provide.
 *
 * You anticipate future changes to the base class that won't break derived classes, as adding members to
 * an interface requires updating all implementing classes, while abstract classes are more flexible for
 * evolution.
 * 
 * Interfaces are better for loose coupling, multiple inheritance, or when only behavior contracts are needed
 * without shared state or implementation.
 */
#endregion

#region Problem:
/*
    o Define a class Product with attributes Id, Name, and Price. 
    o Implement the IComparable interface to compare products by Price. 
    o Write a program to sort an array of Product objects. 
*/

//int n = InputAndValidate("Enter number of products: ", false, 1);
//Product[] products = new Product[n];

//for (int i = 0; i < n; i++)
//{
//    Console.WriteLine($"\nEnter details for Product {i + 1}:");
//    int id = InputAndValidate("Enter Product ID: ", false, -1);
//    string name = InputAndValidate("Enter Product Name: ", true, "Unknown");
//    double price = InputAndValidate<double>("Enter Product Price: ", false, -1.0);
//    products[i] = new Product(id, name, price);
//}

//Console.WriteLine("\nProducts before sorting:");
//foreach (var product in products)
//{
//    Console.WriteLine(product);
//}

//Array.Sort(products);

//Console.WriteLine("\nProducts after sorting by Price:");
//foreach (var product in products)
//{
//    Console.WriteLine(product);
//}

//Console.ReadKey();

//class Product : IComparable
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public double Price { get; set; }

//    public Product(int id, string name, double price)
//    {
//        Id = id;
//        Name = name;
//        Price = price;
//    }

//    public int CompareTo(object? obj)
//    {
//        if (obj == null) return 1;
//        if (!(obj is Product other))
//            throw new ArgumentException("Object is not a Product");

//        return Price.CompareTo(other.Price);
//    }

//    public override string ToString()
//    {
//        return $"Product ID: {Id}, Name: {Name}, Price: {Price:C}";
//    }
//}

// Question: How does implementing IComparable improve flexibility in sorting? 

/*
 * Implementing IComparable improves flexibility in sorting by providing a standard way to define a 
 * default comparison logic for objects, enabling seamless integration with sorting methods 
 * like Array.Sort() or List.Sort().
 * 
 * Allowing objects to be compared in a consistent manner across different contexts without requiring
 * external comparison logic.
 * 
 * Supporting custom sorting criteria encapsulated within the class, making it reusable and maintainable.
 */
#endregion

#region Problem:
/*
    o Create a class Student with attributes Id, Name, and Grade. 
    o Add a copy constructor to create a deep copy of a Student object. 
    o Write a program to demonstrate shallow vs. deep copies. 
*/

//int id = InputAndValidate("Enter Student ID: ", false, -1);
//string name = InputAndValidate("Enter Student Name: ", true, "Unknown");
//double grade = InputAndValidate<double>("Enter Student Grade: ", false, -1.0);

//Student original = new Student(id, name, grade);
//Console.WriteLine("\nOriginal Student:");
//Console.WriteLine(original);

//Student shallowCopy = original;
//Console.WriteLine("\nShallow Copy (before modification):");
//Console.WriteLine(shallowCopy);

//shallowCopy.Name = InputAndValidate("Enter new Name for Shallow Copy: ", true, "ShallowModified");
//shallowCopy.Grade = InputAndValidate<double>("Enter new Grade for Shallow Copy: ", false, -1.0);

//Console.WriteLine("\nAfter modifying Shallow Copy:");
//Console.WriteLine("Original: " + original);
//Console.WriteLine("Shallow Copy: " + shallowCopy);

//Student deepCopy = new Student(original);
//Console.WriteLine("\nDeep Copy (before modification):");
//Console.WriteLine(deepCopy);

//deepCopy.Name = InputAndValidate("Enter new Name for Deep Copy: ", true, "DeepModified");
//deepCopy.Grade = InputAndValidate<double>("Enter new Grade for Deep Copy: ", false, -1.0);

//Console.WriteLine("\nAfter modifying Deep Copy:");
//Console.WriteLine("Original: " + original);
//Console.WriteLine("Deep Copy: " + deepCopy);

//Console.ReadKey();

//class Student
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public double Grade { get; set; }

//    public Student(int id, string name, double grade)
//    {
//        Id = id;
//        Name = name;
//        Grade = grade;
//    }

//    public Student(Student other)
//    {
//        Id = other.Id;
//        Name = other.Name;
//        Grade = other.Grade;
//    }

//    public override string ToString()
//    {
//        return $"Student ID: {Id}, Name: {Name}, Grade: {Grade:F2}";
//    }
//}

// Question: What is the primary purpose of a copy constructor in C#? 

/*
 * The primary purpose of a copy constructor in C# is to create a new object as a deep copy of an existing
 * object, ensuring that the new object is independent and modifications to it do not affect the original.
 * This is particularly important for reference types or objects containing reference types
 * to avoid unintended side effects from shared references, as seen in shallow copies. It provides a
 * controlled way to duplicate an object's state while maintaining encapsulation and data integrity.
 */
#endregion

#region Problem:
/*
    o Create an interface IWalkable with a method Walk(). 
    o Implement explicit interface methods in a class Robot to handle IWalkable methods differently 
      than its own methods. 
*/

//Robot robot = new Robot();
//Console.WriteLine("\nCalling Robot's own Walk method:");
//robot.Walk();

//IWalkable walkableRobot = robot;
//Console.WriteLine("\nCalling IWalkable's Walk method:");
//walkableRobot.Walk();

//Console.ReadKey();

//interface IWalkable
//{
//    void Walk();
//}

//class Robot: IWalkable
//{
//    public void Walk()
//    {
//        Console.WriteLine($"Robot is walking...");
//    }

//    void IWalkable.Walk()
//    {
//        Console.WriteLine($"IWalkable: Robot is walking...");
//    }
//}

// Question: How does explicit interface implementation help in resolving naming conflicts? 

/*
 * Explicit interface implementation helps resolve naming conflicts by:
 * 
 * Allowing a class to implement an interface method separately from its own method with the same name,
 * avoiding ambiguity.
 * 
 * Enabling different behaviors for the same method name depending on whether the object is accessed
 * as the class type or the interface type, providing flexibility in method implementation.
 */
#endregion

#region Problem:
/*
    o Define a struct Account with private attributes AccountId, AccountHolder, and Balance. 
    o Provide public properties for accessing these attributes. 
    o Write a program to demonstrate encapsulation in structs. 
*/

//int id = InputAndValidate("Enter Account ID: ", false, -1);
//string holder = InputAndValidate("Enter Account Holder Name: ", true, "Unknown");
//double balance = InputAndValidate<double>("Enter Account Balance: ", false, -1.0);

//Account account = new Account(id, holder, balance);
//Console.WriteLine("\nInitial Account Details:");
//Console.WriteLine(account);

//account.Balance = InputAndValidate<double>("Enter new Balance: ", false, -1.0);
//Console.WriteLine("\nUpdated Account Details:");
//Console.WriteLine(account);

//double deposit = InputAndValidate<double>("Enter amount to deposit: ", false, 0.0);
//account.Balance += deposit;
//Console.WriteLine("\nAfter Deposit:");
//Console.WriteLine(account);

//Console.ReadKey();

//struct Account
//{
//    private int accountId;
//    private string accountHolder;
//    private double balance;

//    public Account(int id, string holder, double bal)
//    {
//        accountId = id;
//        accountHolder = holder;
//        Balance = bal;
//    }

//    public int AccountId
//    {
//        get { return accountId; }
//        set { accountId = value; }
//    }

//    public string AccountHolder
//    {
//        get { return accountHolder; }
//        set { accountHolder = value; }
//    }

//    public double Balance
//    {
//        get { return balance; }
//        set
//        {
//            if (value >= 0)
//                balance = value;
//            else
//                balance = 0;
//        }
//    }

//    public override string ToString()
//    {
//        return $"Account ID: {AccountId}, Holder: {AccountHolder}, Balance: {Balance:C}";
//    }
//}

// Question: What is the key difference between encapsulation in structs and classes? 

/*
 * Encapsulation in structs and classes both involve hiding internal data and exposing it through public
 * properties or methods to control access and maintain data integrity. The key difference lies in their
 * memory allocation and behavior: structs are value types, stored on the stack or inline, with copy-by-value
 * semantics, meaning modifications to a copied struct do not affect the original. Classes are reference types,
 * stored on the heap with copy-by-reference semantics, where changes to a copied reference affect the original
 * object. This impacts encapsulation, as structs require careful handling to avoid unintended copies that bypass
 * encapsulation, while classes require managing shared references to maintain encapsulation integrity.
*/

// Question: What is abstraction as a guideline, what’s its relation with encapsulation? 

/*
 * Abstraction is a design principle that simplifies complex systems by exposing only relevant details and
 * hiding implementation complexities from the user. It focuses on "what" an object does rather than 
 * "how" it does it, achieved through interfaces, abstract classes, or public APIs. 
 * Encapsulation supports abstraction by hiding internal implementation details and exposing only 
 * necessary interfaces like properties, ensuring users interact with the object at a high level 
 * without needing to understand its internals. 
 */
#endregion

#region Problem:
/*
    o Create an interface ILogger with a method Log(). 
    o Provide a default implementation for Log() in the interface. 
    o Override the default implementation in a class ConsoleLogger. 
*/

//string message = InputAndValidate("Enter a message to log: ", true, "Default Message");

//ILogger defaultLogger = new DefaultLogger();
//Console.WriteLine("\nUsing Default Logger (interface default implementation):");
//defaultLogger.Log(message);

//ILogger consoleLogger = new ConsoleLogger();
//Console.WriteLine("\nUsing ConsoleLogger (overridden implementation):");
//consoleLogger.Log(message);

//Console.ReadKey();

//interface ILogger
//{
//    void Log(string message)
//    {
//        Console.WriteLine($"Default ILogger: {message}");
//    }
//}

//class DefaultLogger : ILogger
//{
//    // Uses the default implementation from ILogger
//}

//class ConsoleLogger : ILogger
//{
//    public void Log(string message)
//    {
//        Console.WriteLine($"ConsoleLogger: [{DateTime.Now}] {message}");
//    }
//}

// Question: How do default interface implementations affect backward compatibility in C#? 

/*
 * Default interface implementations, introduced in C# 8.0, enhance backward compatibility by:
 * 
 * Allowing interfaces to add new methods with default implementations without breaking existing classes
 * that implement the interface. Classes like DefaultLogger can use the default method without needing
 * to implement it, preventing compilation errors in older code.
 * 
 * Avoiding the need to modify all implementing classes when adding a new method, unlike traditional
 * interfaces where new methods would require updates across all implementations.
 * 
 */
#endregion

#region Problem:
/*
    o Create a class Book with attributes Title and Author. 
    o Provide multiple constructors: a default constructor, one that takes only Title, and another that 
      takes both Title and Author. 
    o Write a program to demonstrate constructor overloading. 
*/

//string title2 = InputAndValidate("Enter Title for Book 1 (single parameter): ", true, "Unknown Title");
//string title3 = InputAndValidate("Enter Title for Book 2 (two parameters): ", true, "Unknown Title");
//string author3 = InputAndValidate("Enter Author for Book 2 (two parameters): ", true, "Unknown Author");

//Book book1 = new Book();
//Console.WriteLine("\nBook 1 (Default Constructor):");
//Console.WriteLine(book1);

//Book book2 = new Book(title2);
//Console.WriteLine("\nBook 2 (Single Parameter Constructor):");
//Console.WriteLine(book2);

//Book book3 = new Book(title3, author3);
//Console.WriteLine("\nBook 3 (Two Parameter Constructor):");
//Console.WriteLine(book3);

//Console.ReadKey();

//class Book
//{
//    public string Title { get; set; }
//    public string Author { get; set; }

//    public Book()
//    {
//        Title = "Unknown Title";
//        Author = "Unknown Author";
//    }

//    public Book(string title)
//    {
//        Title = title;
//        Author = "Unknown Author";
//    }

//    public Book(string title, string author)
//    {
//        Title = title;
//        Author = author;
//    }

//    public override string ToString()
//    {
//        return $"Title: {Title}, Author: {Author}";
//    }
//}

// Question: How does constructor overloading improve class usability? 

/*
 * Constructor overloading improves class usability by:
 *  
 * Providing multiple ways to initialize objects, allowing users to create instances with varying levels
 * of information based on their needs.
 *   
 * Improving code readability and intent by allowing constructors to clearly specify which parameters
 * are required, making object creation more intuitive.
 * 
 * Supporting default or partial initialization, reducing the need for repetitive code and ensuring
 * objects are created in a valid state tailored to the context.
 */
#endregion