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
    o Define an interface IShapeSeries with the following: 
         A property int CurrentShapeArea { get; set; }. 
         A method void GetNextArea() to calculate the next shape's area. 
         A method void ResetSeries() to reset the series. 
    o Implement IShapeSeries for the following: 
        1. SquareSeries: Calculates areas of squares with side lengths incrementing 
            by 1 (e.g., 1x1, 2x2, 3x3). 
        2. CircleSeries: Calculates areas of circles with radii incrementing by 1 (use 
            Math.PI * radius * radius). 
    o Write a method PrintTenShapes(IShapeSeries series) to display the first 10 areas of any series. 
*/

//IShapeSeries squareSeries = new SquareSeries();
//Console.WriteLine("Square Series (Areas for side lengths 1 to 10):");
//PrintTenShapes(squareSeries);

//IShapeSeries circleSeries = new CircleSeries();
//Console.WriteLine("\nCircle Series (Areas for radius 1 to 10):");
//PrintTenShapes(circleSeries);

//Console.ReadKey();

//static void PrintTenShapes(IShapeSeries series)
//{
//    series.ResetSeries();
//    for (int i = 0; i < 10; i++)
//    {
//        series.GetNextArea();
//        Console.WriteLine($"Shape {i + 1} Area: {series.CurrentShapeArea}");
//    }
//}

//interface IShapeSeries
//{
//    int CurrentShapeArea { get; set; }
//    void GetNextArea();
//    void ResetSeries();
//}

//class SquareSeries : IShapeSeries
//{
//    private int sideLength;
//    public int CurrentShapeArea { get; set; }

//    public SquareSeries()
//    {
//        sideLength = 0;
//        CurrentShapeArea = 0;
//    }

//    public void GetNextArea()
//    {
//        sideLength++;
//        CurrentShapeArea = sideLength * sideLength;
//    }

//    public void ResetSeries()
//    {
//        sideLength = 0;
//        CurrentShapeArea = 0;
//    }
//}

//class CircleSeries : IShapeSeries
//{
//    private int radius;
//    public int CurrentShapeArea { get; set; }

//    public CircleSeries()
//    {
//        radius = 0;
//        CurrentShapeArea = 0;
//    }

//    public void GetNextArea()
//    {
//        radius++;
//        CurrentShapeArea = (int)(Math.PI * radius * radius);
//    }

//    public void ResetSeries()
//    {
//        radius = 0;
//        CurrentShapeArea = 0;
//    }
//}

#endregion

#region Problem:
/*
    o Create a class Shape with properties: 
         string Name (e.g., "Square", "Circle"). 
         double Area. 
    o Implement IComparable for sorting shapes by area. 
    o Create a list of shapes with various types (Square, Circle, Rectangle) and areas. 
    o Sort and display the shapes by area in ascending order using Array.Sort(). 
*/

//Shape[] shapes = new Shape[6];
//shapes[0] = new Shape("Square", InputAndValidate<double>("Enter area for Square 1: ", false, -1.0));
//shapes[1] = new Shape("Square", InputAndValidate<double>("Enter area for Square 2: ", false, -1.0));
//shapes[2] = new Shape("Circle", InputAndValidate<double>("Enter area for Circle 1: ", false, -1.0));
//shapes[3] = new Shape("Circle", InputAndValidate<double>("Enter area for Circle 2: ", false, -1.0));
//shapes[4] = new Shape("Rectangle", InputAndValidate<double>("Enter area for Rectangle 1: ", false, -1.0));
//shapes[5] = new Shape("Rectangle", InputAndValidate<double>("Enter area for Rectangle 2: ", false, -1.0));

//Console.WriteLine("\nShapes before sorting:");
//foreach (var shape in shapes)
//{
//    Console.WriteLine(shape);
//}

//Array.Sort(shapes);

//Console.WriteLine("\nShapes after sorting by Area (ascending):");
//foreach (var shape in shapes)
//{
//    Console.WriteLine(shape);
//}

//Console.ReadKey();

//class Shape : IComparable
//{
//    public string Name { get; set; }
//    public double Area { get; set; }

//    public Shape(string name, double area)
//    {
//        Name = name;
//        Area = area;
//    }

//    public int CompareTo(object obj)
//    {
//        if (obj == null) return 1;
//        if (!(obj is Shape other))
//            throw new ArgumentException("Object is not a Shape");

//        return Area.CompareTo(other.Area);
//    }

//    public override string ToString()
//    {
//        return $"Shape: {Name}, Area: {Area:F2}";
//    }
//}

#endregion

#region Problem:
/*
    o Create an abstract class GeometricShape with: 
         Properties: double Dimension1, double Dimension2. 
         Abstract method: double CalculateArea(). 
         Abstract property: double Perimeter { get; }. 
    o Create derived classes: 
         Triangle: Override CalculateArea() using 0.5 * Dimension1 * Dimension2. 
         Rectangle: Implement area as Dimension1 * Dimension2 and perimeter as 2 * (Dimension1 + Dimension2). 
    o Write a program to create and display instances of these shapes. 
*/

//double triBase = InputAndValidate<double>("Enter Triangle Base: ", false, -1.0);
//double triHeight = InputAndValidate<double>("Enter Triangle Height: ", false, -1.0);
//double triSide3 = InputAndValidate<double>("Enter Triangle Side 3: ", false, -1.0);
//double rectWidth = InputAndValidate<double>("Enter Rectangle Width: ", false, -1.0);
//double rectHeight = InputAndValidate<double>("Enter Rectangle Height: ", false, -1.0);

//GeometricShape triangle = new Triangle(triBase, triHeight, triSide3);
//GeometricShape rectangle = new Rectangle(rectWidth, rectHeight);

//Console.WriteLine("\nTriangle Details:");
//Console.WriteLine($"Area: {triangle.CalculateArea():F2}, Perimeter: {triangle.Perimeter:F2}");

//Console.WriteLine("\nRectangle Details:");
//Console.WriteLine($"Area: {rectangle.CalculateArea():F2}, Perimeter: {rectangle.Perimeter:F2}");

//Console.ReadKey();

//abstract class GeometricShape
//{
//    public double Dimension1 { get; set; }
//    public double Dimension2 { get; set; }

//    public GeometricShape(double dim1, double dim2)
//    {
//        Dimension1 = dim1;
//        Dimension2 = dim2;
//    }

//    public abstract double CalculateArea();
//    public abstract double Perimeter { get; }
//}

//class Triangle : GeometricShape
//{
//    private double Dimension3 { get; set; }

//    public Triangle(double baseLength, double height, double side3) : base(baseLength, height)
//    {
//        Dimension3 = side3;
//    }

//    public override double CalculateArea()
//    {
//        return 0.5 * Dimension1 * Dimension2;
//    }

//    public override double Perimeter
//    {
//        get { return Dimension1 + Dimension2 + Dimension3; }
//    }
//}

//class Rectangle : GeometricShape
//{
//    public Rectangle(double width, double height) : base(width, height)
//    {
//    }

//    public override double CalculateArea()
//    {
//        return Dimension1 * Dimension2;
//    }

//    public override double Perimeter
//    {
//        get { return 2 * (Dimension1 + Dimension2); }
//    }
//}

#endregion

#region Problem:
/*
    o Write your own SelectionSort method for sorting an integer array: 
        public static void SelectionSort(int[] numbers) 
    o Use this method to sort an array of shape areas generated in Part 2. 
*/

//double triBase = InputAndValidate<double>("Enter Triangle Base: ", false, -1.0);
//double triHeight = InputAndValidate<double>("Enter Triangle Height: ", false, -1.0);
//double triSide3 = InputAndValidate<double>("Enter Triangle Side 3: ", false, -1.0);
//double rectWidth1 = InputAndValidate<double>("Enter Rectangle 1 Width: ", false, -1.0);
//double rectHeight1 = InputAndValidate<double>("Enter Rectangle 1 Height: ", false, -1.0);
//double rectWidth2 = InputAndValidate<double>("Enter Rectangle 2 Width: ", false, -1.0);
//double rectHeight2 = InputAndValidate<double>("Enter Rectangle 2 Height: ", false, -1.0);

//GeometricShape[] shapes = new GeometricShape[]
//{
//    new Triangle(triBase, triHeight, triSide3),
//    new Rectangle(rectWidth1, rectHeight1),
//    new Rectangle(rectWidth2, rectHeight2)
//};

//int[] areas = new int[shapes.Length];
//for (int i = 0; i < shapes.Length; i++)
//{
//    areas[i] = (int)shapes[i].CalculateArea();
//}

//Console.WriteLine("\nShape Areas before sorting:");
//for (int i = 0; i < areas.Length; i++)
//{
//    Console.WriteLine($"Shape {i + 1} ({shapes[i].GetType().Name}): Area = {areas[i]}");
//}

//SelectionSort(areas);

//Console.WriteLine("\nShape Areas after sorting (ascending):");
//for (int i = 0; i < areas.Length; i++)
//{
//    Console.WriteLine($"Area {i + 1}: {areas[i]}");
//}

//Console.ReadKey();

//static void SelectionSort(int[] numbers)
//{
//    if (numbers == null || numbers.Length == 0) return;

//    for (int i = 0; i < numbers.Length - 1; i++)
//    {
//        int minIndex = i;
//        for (int j = i + 1; j < numbers.Length; j++)
//        {
//            if (numbers[j] < numbers[minIndex])
//            {
//                minIndex = j;
//            }
//        }
//        if (minIndex != i)
//        {
//            int temp = numbers[i];
//            numbers[i] = numbers[minIndex];
//            numbers[minIndex] = temp;
//        }
//    }
//}

//abstract class GeometricShape
//{
//    public double Dimension1 { get; set; }
//    public double Dimension2 { get; set; }

//    public GeometricShape(double dim1, double dim2)
//    {
//        Dimension1 = dim1;
//        Dimension2 = dim2;
//    }

//    public abstract double CalculateArea();
//    public abstract double Perimeter { get; }
//}

//class Triangle : GeometricShape
//{
//    private double Dimension3 { get; set; }

//    public Triangle(double baseLength, double height, double side3) : base(baseLength, height)
//    {
//        Dimension3 = side3;
//    }

//    public override double CalculateArea()
//    {
//        return 0.5 * Dimension1 * Dimension2;
//    }

//    public override double Perimeter
//    {
//        get { return Dimension1 + Dimension2 + Dimension3; }
//    }
//}

//class Rectangle : GeometricShape
//{
//    public Rectangle(double width, double height) : base(width, height)
//    {
//    }

//    public override double CalculateArea()
//    {
//        return Dimension1 * Dimension2;
//    }

//    public override double Perimeter
//    {
//        get { return 2 * (Dimension1 + Dimension2); }
//    }
//}

#endregion

#region Problem:
/*
    o Create a ShapeFactory class with a method CreateShape(string shapeType, 
      double dim1, double dim2). 
    o Use the factory to create instances of different geometric shapes (Rectangle, 
      Triangle, etc.). 
*/

//string shapeType1 = InputAndValidate("Enter first shape type (Triangle/Rectangle): ", false, "Unknown");
//double dim1_1 = InputAndValidate<double>("Enter first dimension for shape 1: ", false, -1.0);
//double dim1_2 = InputAndValidate<double>("Enter second dimension for shape 1: ", false, -1.0);

//string shapeType2 = InputAndValidate("Enter second shape type (Triangle/Rectangle): ", false, "Unknown");
//double dim2_1 = InputAndValidate<double>("Enter first dimension for shape 2: ", false, -1.0);
//double dim2_2 = InputAndValidate<double>("Enter second dimension for shape 2: ", false, -1.0);

//ShapeFactory factory = new ShapeFactory();

//GeometricShape shape1 = factory.CreateShape(shapeType1, dim1_1, dim1_2);
//GeometricShape shape2 = factory.CreateShape(shapeType2, dim2_1, dim2_2);

//Console.WriteLine("\nShape 1 Details:");
//Console.WriteLine($"Type: {shape1.GetType().Name}, Area: {shape1.CalculateArea():F2}, Perimeter: {shape1.Perimeter:F2}");

//Console.WriteLine("\nShape 2 Details:");
//Console.WriteLine($"Type: {shape2.GetType().Name}, Area: {shape2.CalculateArea():F2}, Perimeter: {shape2.Perimeter:F2}");

//Console.ReadKey();

//abstract class GeometricShape
//{
//    public double Dimension1 { get; set; }
//    public double Dimension2 { get; set; }

//    public GeometricShape(double dim1, double dim2)
//    {
//        Dimension1 = dim1;
//        Dimension2 = dim2;
//    }

//    public abstract double CalculateArea();
//    public abstract double Perimeter { get; }
//}

//class Triangle : GeometricShape
//{
//    private double Dimension3 { get; set; }

//    public Triangle(double baseLength, double height, double side3) : base(baseLength, height)
//    {
//        Dimension3 = side3;
//    }

//    public override double CalculateArea()
//    {
//        return 0.5 * Dimension1 * Dimension2;
//    }

//    public override double Perimeter
//    {
//        get { return Dimension1 + Dimension2 + Dimension3; }
//    }
//}

//class Rectangle : GeometricShape
//{
//    public Rectangle(double width, double height) : base(width, height)
//    {
//    }

//    public override double CalculateArea()
//    {
//        return Dimension1 * Dimension2;
//    }

//    public override double Perimeter
//    {
//        get { return 2 * (Dimension1 + Dimension2); }
//    }
//}

//class ShapeFactory
//{
//    public GeometricShape CreateShape(string shapeType, double dim1, double dim2)
//    {
//        if (string.IsNullOrWhiteSpace(shapeType))
//            throw new ArgumentException("Shape type cannot be null or empty.");

//        switch (shapeType.ToLower())
//        {
//            case "triangle":
//                // For triangle, assume Dimension3 = dim1 for simplicity to ensure valid triangle
//                return new Triangle(dim1, dim2, dim1);
//            case "rectangle":
//                return new Rectangle(dim1, dim2);
//            default:
//                throw new ArgumentException($"Unknown shape type: {shapeType}");
//        }
//    }
//}

#endregion