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
    o Define a class Car with properties Id, Brand, and Price. 
    o Write multiple constructors: 
        1. Default constructor. 
        2. Constructor with one parameter (Id). 
        3. Constructor with two parameters (Id, Brand). 
        4. Constructor with all three parameters. 
    o Demonstrate the constructors by creating objects. 
*/

//Car defaultCar = new Car();
//Console.WriteLine($"Default Constructor: {defaultCar}");

//int id = InputAndValidate("Enter ID for single-parameter constructor: ", false, -1);
//Car idCar = new Car(id);
//Console.WriteLine($"Single-Parameter Constructor: {idCar}");

//int id2 = InputAndValidate("Enter ID for two-parameter constructor: ", false, -1);
//string brand = InputAndValidate("Enter Brand for two-parameter constructor: ", false, "Unknown");
//Car idBrandCar = new Car(id2, brand);
//Console.WriteLine($"Two-Parameter Constructor: {idBrandCar}");

//int id3 = InputAndValidate("Enter ID for three-parameter constructor: ", false, -1);
//string brand2 = InputAndValidate("Enter Brand for three-parameter constructor: ", false, "Unknown");
//double price = InputAndValidate<double>("Enter Price for three-parameter constructor: ", false, -1.0);
//Car fullCar = new Car(id3, brand2, price);
//Console.WriteLine($"Three-Parameter Constructor: {fullCar}");

//Console.ReadKey();

//class Car
//{
//    public int Id { get; set; }
//    public string Brand { get; set; }
//    public double Price { get; set; }

//    public Car()
//    {
//        Id = 0;
//        Brand = "Unknown";
//        Price = 0.0;
//    }

//    public Car(int id)
//    {
//        Id = id;
//        Brand = "Unknown";
//        Price = 0.0;
//    }

//    public Car(int id, string brand)
//    {
//        Id = id;
//        Brand = brand;
//        Price = 0.0;
//    }

//    public Car(int id, string brand, double price)
//    {
//        Id = id;
//        Brand = brand;
//        Price = price;
//    }

//    public override string ToString()
//    {
//        return $"Car [Id = {Id}, Brand = {Brand}, Price = {Price:C}]";
//    }
//}

// Question: Why does defining a custom constructor suppress the default constructor in C#?

/*
 * Defining a custom constructor in C# suppresses the default constructor because the compiler only 
 * provides a parameterless constructor automatically if no constructors are explicitly defined.
 * 
 * When a custom constructor is added, the compiler assumes the developer intends to control object 
 * initialization explicitly, requiring manual definition of a parameterless constructor if needed.
 * 
 * This ensures intentional initialization logic and prevents unintended use of a default constructor
 * that might leave objects in an invalid state.
 */
#endregion

#region Problem: 
/*
    o Write a class Calculator with overloaded Sum() methods to: 
        1. Add two integers. 
        2. Add three integers. 
        3. Add two doubles. 
    o Write a program to test each overload. 
*/

//int a = InputAndValidate("Enter first integer: ", false, -1);
//int b = InputAndValidate("Enter second integer: ", false, -1);
//Calculator calc = new Calculator();
//Console.WriteLine($"Sum of two integers ({a}, {b}): {calc.Sum(a, b)}");

//int c = InputAndValidate("Enter third integer: ", false, -1);
//Console.WriteLine($"Sum of three integers ({a}, {b}, {c}): {calc.Sum(a, b, c)}");

//double x = InputAndValidate<double>("Enter first double: ", false, -1.0);
//double y = InputAndValidate<double>("Enter second double: ", false, -1.0);
//Console.WriteLine($"Sum of two doubles ({x}, {y}): {calc.Sum(x, y)}");

//Console.ReadKey();

//class Calculator
//{
//    public int Sum(int a, int b)
//    {
//        return a + b;
//    }

//    public int Sum(int a, int b, int c)
//    {
//        return a + b + c;
//    }

//    public double Sum(double a, double b)
//    {
//        return a + b;
//    }
//}

// Question: How does method overloading improve code readability and reusability?

/*
 * Method overloading improves code readability and reusability by allowing multiple methods with the same
 * name but different parameter lists, enabling intuitive use of a single method name for related 
 * operations.
 * 
 */
#endregion

#region Problem: 
/*
    o Create a base class Parent with properties X and Y, and a constructor to initialize them. 
    o Create a derived class Child with an additional property Z, and chain its constructor to 
      the base class. 
    o Demonstrate constructor chaining by creating an instance of Child. 
*/

//int x = InputAndValidate("Enter X (integer): ", false, -1);
//int y = InputAndValidate("Enter Y (integer): ", false, -1);
//int z = InputAndValidate("Enter Z (integer): ", false, -1);

//Child child = new Child(x, y, z);
//Console.WriteLine($"Child instance: X = {child.X}, Y = {child.Y}, Z = {child.Z}");

//Console.ReadKey();

//class Parent
//{
//    public int X { get; set; }
//    public int Y { get; set; }

//    public Parent(int x, int y)
//    {
//        X = x;
//        Y = y;
//    }
//}

//class Child : Parent
//{
//    public int Z { get; set; }

//    public Child(int x, int y, int z) : base(x, y)
//    {
//        Z = z;
//    }
//}

// Question: What is the purpose of constructor chaining in inheritance?

/*
 * Constructor chaining in inheritance ensures that the base class is properly initialized before the 
 * derived class, maintaining a consistent object state, promoting code reuse, reducing duplication, 
 * and ensuring that the base class's initialization logic is executed correctly,
 * which is critical for the integrity of the inheritance hierarchy.
 */
#endregion

#region Problem: 
/*
    o Define a method Product() in the Parent class to return X * Y. 
    o In the Child class: 
        1. Override the Product() method using the new keyword. 
        2. Override it using the override keyword. 
    o Demonstrate the difference in behavior using an instance of Child. 
*/

//int x = InputAndValidate("Enter X (integer): ", false, -1);
//int y = InputAndValidate("Enter Y (integer): ", false, -1);
//int z = InputAndValidate("Enter Z (integer): ", false, -1);

//Child child = new Child(x, y, z);
//Console.WriteLine($"Child instance: X = {child.X}, Y = {child.Y}, Z = {child.Z}");

//Console.WriteLine($"Child.ProductNew(): {child.ProductNew()}");
//Console.WriteLine($"Child.Product(): {child.Product()}");

//Parent parentRef = child;
//Console.WriteLine($"ParentRef.Product(): {parentRef.Product()}");

//Console.ReadKey();

//class Parent
//{
//    public int X { get; set; }
//    public int Y { get; set; }

//    public Parent(int x, int y)
//    {
//        X = x;
//        Y = y;
//    }

//    public virtual int Product()
//    {
//        return X * Y;
//    }
//}

//class Child : Parent
//{
//    public int Z { get; set; }

//    public Child(int x, int y, int z) : base(x, y)
//    {
//        Z = z;
//    }

//    public new int ProductNew()
//    {
//        return X * Y * Z;
//    }

//    public override int Product()
//    {
//        return X * Y * Z;
//    }
//}

// Question: How does new differ from override in method overriding?

/*
 * The new keyword hides a base class method, creating a new method in the derived class that is unrelated
 * to the base class method, so the base class method is called when using a base class reference.
 * 
 * The override keyword extends or replaces a virtual or abstract base class method, ensuring the derived
 * class method is called even through a base class reference, enabling polymorphic behavior. 
 * 
 * new breaks the inheritance chain, while override maintains it, allowing dynamic dispatch.
 */
#endregion

#region Problem: 
/*
    o Override the ToString() method in Parent to return (X, Y) and in Child to return 
      (X, Y, Z). 
    o Demonstrate polymorphism by printing instances of both Parent and Child. 
*/

//int x = InputAndValidate("Enter X (integer): ", false, -1);
//int y = InputAndValidate("Enter Y (integer): ", false, -1);
//int z = InputAndValidate("Enter Z (integer): ", false, -1);

//Parent parent = new Parent(x, y);
//Console.WriteLine($"Parent instance: {parent}");

//Child child = new Child(x, y, z);
//Console.WriteLine($"Child instance: {child}");

//Parent childAsParent = child;
//Console.WriteLine($"Child as Parent reference: {childAsParent}");

//Console.ReadKey();

//class Parent
//{
//    public int X { get; set; }
//    public int Y { get; set; }

//    public Parent(int x, int y)
//    {
//        X = x;
//        Y = y;
//    }

//    public override string ToString()
//    {
//        return $"({X}, {Y})";
//    }
//}

//class Child : Parent
//{
//    public int Z { get; set; }

//    public Child(int x, int y, int z) : base(x, y)
//    {
//        Z = z;
//    }

//    public override string ToString()
//    {
//        return $"({X}, {Y}, {Z})";
//    }
//}

// Question: Why is ToString() often overridden in custom classes?

/*
 * ToString() is often overridden in custom classes to provide a meaningful string representation of an 
 * object's state, improving readability and debugging. 
 * 
 * It allows developers to define how an object should be displayed when converted to a string, 
 * such as in console output or string interpolation, making the output more intuitive and specific to the 
 * class's purpose, rather than relying on the default type name provided by Object.ToString().
 */
#endregion

#region Problem: 
/*
    o Define an interface IShape with: 
        1. A property Area (get-only). 
        2. A method Draw(). 
    o Create a class Rectangle implementing IShape with its own version of Draw() and 
      Area. 
    o Test the implementation. 
*/

//double width = InputAndValidate<double>("Enter Rectangle Width (double): ", false, -1.0);
//double height = InputAndValidate<double>("Enter Rectangle Height (double): ", false, -1.0);

//Rectangle rect = new Rectangle(width, height);
//Console.WriteLine($"Rectangle Area: {rect.Area}");
//rect.Draw();

//Console.ReadKey();

//interface IShape
//{
//    double Area { get; }
//    void Draw();
//}

//class Rectangle : IShape
//{
//    public double Width { get; set; }
//    public double Height { get; set; }

//    public Rectangle(double width, double height)
//    {
//        this.Width = width;
//        this.Height = height;
//    }

//    public double Area
//    {
//        get { return Width * Height; }
//    }

//    public void Draw()
//    {
//        Console.WriteLine($"Drawing Rectangle with Width: {Width}, Height: {Height}\n");
//    }
//}

// Question: Why can't you create an instance of an interface directly?

/*
 * An interface cannot be instantiated directly because it is an abstract contract that defines properties
 * and methods without providing implementation. 
 * 
 * It lacks the concrete logic and storage required for an object, serving only as a blueprint for 
 * classes to implement. 
 * 
 * Instantiating an interface would be meaningless, as it contains no executable code or data, 
 * and C# enforces this to ensure type safety and proper abstraction.
 */
#endregion

#region Problem: 
/*
    o Modify the IShape interface to include a default implementation of a method 
      PrintDetails(). 
    o Create a class Circle that implements IShape. 
    o Call PrintDetails() on an instance of Circle. 
*/

//double radius = InputAndValidate<double>("Enter Circle Radius (double): ", false, -1.0);

//Circle circle = new Circle(radius);
//Console.WriteLine($"Circle Area: {circle.Area}");
//circle.Draw();
//((IShape)circle).PrintDetails();

//Console.ReadKey();

//interface IShape
//{
//    double Area { get; }
//    void Draw();

//    void PrintDetails()
//    {
//        Console.WriteLine($"Shape with Area: {Area}");
//    }
//}

//class Circle : IShape
//{
//    private double radius;

//    public Circle(double radius)
//    {
//        this.radius = radius;
//    }

//    public double Area
//    {
//        get { return Math.PI * radius * radius; }
//    }

//    public void Draw()
//    {
//        Console.WriteLine($"Drawing Circle with Radius: {radius}");
//    }
//}

// Question: What are the benefits of default implementations in interfaces introduced in C# 8.0?

/*
 * Default implementations in interfaces, introduced in C# 8.0, allow interfaces to provide method bodies.
 * 
 * They reduce code duplication by offering shared logic for implementing classes,
 * simplify design by allowing optional method overrides, and enhance flexibility in large systems.
 * 
 * This feature supports better versioning and promotes interface-based design while maintaining
 * compatibility.
 */
#endregion

#region Problem: 
/*
    o Define an interface IMovable with a method Move(). 
    o Create a class Car implementing IMovable. 
    o Use an IMovable reference to access the Car object and call Move(). 
*/

//string brand = InputAndValidate("Enter Car Brand: ", false, "Unknown");
//Car car = new Car(brand);
//Console.WriteLine($"Car created: {car.Brand}");

//IMovable movable = car;
//movable.Move();

//Console.ReadKey();

//interface IMovable
//{
//    void Move();
//}

//class Car : IMovable
//{
//    public string Brand { get; set; }

//    public Car(string brand)
//    {
//        Brand = brand;
//    }

//    public void Move()
//    {
//        Console.WriteLine($"The {Brand} car is moving.");
//    }
//}

// Question: Why is it useful to use an interface reference to access implementing class methods?

/*
 * Using an interface reference to access implementing class methods promotes polymorphism,
 * allowing different classes that implement the same interface to be treated uniformly.
 * 
 * This approach enables swapping implementations without changing the calling code, 
 * supports dependency injection, and ensures that only interface-defined methods are accessible,
 * enforcing abstraction and reducing tight coupling.
 */
#endregion

#region Problem: 
/*
    o Create two interfaces, IReadable and IWritable, each with a method (Read() and 
      Write()). 
    o Create a class File that implements both interfaces. 
    o Demonstrate using the File class. 
*/

//string fileName = InputAndValidate("Enter File Name: ", false, "Unknown");
//File file = new File(fileName);
//Console.WriteLine($"File created: {file.FileName}");

//file.Write();
//file.Read();

//Console.ReadKey();

//interface IReadable
//{
//    void Read();
//}

//interface IWritable
//{
//    void Write();
//}

//class File : IReadable, IWritable
//{
//    public string FileName { get; set; }

//    public File(string fileName)
//    {
//        FileName = fileName;
//    }

//    public void Read()
//    {
//        Console.WriteLine($"Reading from file: {FileName}");
//    }

//    public void Write()
//    {
//        Console.WriteLine($"Writing to file: {FileName}");
//    }
//}

// Question: How does C# overcome the limitation of single inheritance with interfaces?

/*
 * C# overcomes the limitation of single inheritance by allowing a class to implement multiple interfaces,
 * each defining a contract of methods, properties, or events. 
 * 
 * Unlike classes, interfaces do not contain implementation details (except for default implementations 
 * in C# 8.0+), so a class can inherit behaviors from multiple interfaces without the complexity of 
 * multiple class inheritance.
 * 
 * This enables flexible and modular design, allowing a class to take on multiple roles or behaviors 
 * while maintaining type safety and avoiding conflicts.
 */
#endregion

#region Problem: 
/*
    o Create a base class Shape with: 
        1. A virtual method Draw() that prints "Drawing Shape". 
        2. An abstract method CalculateArea() for area calculation. 
    o Create a derived class Rectangle overriding Draw() and implementing 
      CalculateArea(). 
    o Demonstrate the usage with objects of Rectangle. 
*/

//double width = InputAndValidate<double>("Enter Rectangle Width (double): ", false, -1.0);
//double height = InputAndValidate<double>("Enter Rectangle Height (double): ", false, -1.0);

//Rectangle rect = new Rectangle(width, height);
//rect.Draw();
//Console.WriteLine($"Rectangle Area: {rect.CalculateArea()}");

//Console.ReadKey();

//abstract class Shape
//{
//    public virtual void Draw()
//    {
//        Console.WriteLine("Drawing Shape");
//    }

//    public abstract double CalculateArea();
//}

//class Rectangle : Shape
//{
//    public double Width { get; set; }
//    public double Height { get; set; }

//    public Rectangle(double width, double height)
//    {
//        Width = width;
//        Height = height;
//    }

//    public override void Draw()
//    {
//        Console.WriteLine($"Drawing Rectangle with Width: {Width}, Height: {Height}");
//    }

//    public override double CalculateArea()
//    {
//        return Width * Height;
//    }
//}

// Question: What is the difference between a virtual method and an abstract method in C#?

/*
 * A virtual method in C# has a default implementation in the base class and can be overridden in 
 * derived classes using the override keyword, allowing optional customization.
 * 
 * An abstract method, declared in an abstract class, has no implementation in the base class and 
 * must be implemented by non-abstract derived classes. 
 * 
 * Virtual methods provide flexibility with a fallback implementation, while abstract methods enforce 
 * implementation in derived classes, ensuring specific behavior is defined.
 */
#endregion