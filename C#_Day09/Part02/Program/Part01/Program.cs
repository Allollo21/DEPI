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

#region Problem 1: Generic Method For Reversing An Array
/*
    Description: Create a generic method to reverse the elements of an array.
    Requirements:
        The method should accept an array of any type and return a new array with the elements in reverse order.
        Ensure the method works for different types such as integers, strings, and custom objects.
*/

//int[] intArray = { 1, 2, 3, 4, 5 };
//string[] stringArray = { "apple", "banana", "cherry", "date" };
//Person[] personArray = 
//{
//    new Person("Ali", 30),
//    new Person("Abdo", 25),
//    new Person("Salama", 35)
//};

//Console.WriteLine("Original Integer Array: " + string.Join(", ", intArray));
//int[] reversedIntArray = Helper.ReverseArray(intArray);
//Console.WriteLine("Reversed Integer Array: " + string.Join(", ", reversedIntArray));

//Console.WriteLine("\nOriginal String Array: " + string.Join(", ", stringArray));
//string[] reversedStringArray = Helper.ReverseArray(stringArray);
//Console.WriteLine("Reversed String Array: " + string.Join(", ", reversedStringArray));

//Console.WriteLine("\nOriginal Person Array:");
//foreach (var person in personArray) { Console.WriteLine(person); }
//Person[] reversedPersonArray = Helper.ReverseArray(personArray);
//Console.WriteLine("Reversed Person Array:");
//foreach (var person in reversedPersonArray) { Console.WriteLine(person); }

//Console.ReadKey();

//static class Helper
//{
//    public static T[] ReverseArray<T>(T[] array)
//    {
//        if (array == null)
//            throw new ArgumentNullException(nameof(array));

//        T[] reversed = new T[array.Length];
//        for (int i = 0; i < array.Length; i++)
//        {
//            reversed[i] = array[array.Length - 1 - i];
//        }
//        return reversed;
//    }
//}

//class Person
//{
//    public string Name { get; set; }
//    public int Age { get; set; }

//    public Person(string name, int age)
//    {
//        Name = name;
//        Age = age;
//    }

//    public override string ToString()
//    {
//        return $"Person [Name: {Name}, Age: {Age}]";
//    }
//}

#endregion

#region Problem 2: Generic Class for a Stack
/*
    Description: Implement a generic class for a stack data structure.
    Requirements:
           The class should support standard stack operations such as push, pop, and peek. 
           Ensure type safety using generics.
*/

//Stack<int> intStack = new Stack<int>();
//Console.WriteLine("Integer Stack Operations:");
//intStack.Push(1);
//intStack.Push(2);
//intStack.Push(3);
//Console.WriteLine("After pushing 1, 2, 3:");
//Console.WriteLine($"Peek: {intStack.Peek()}");
//Console.WriteLine($"Pop: {intStack.Pop()}");
//Console.WriteLine($"Peek after pop: {intStack.Peek()}");

//Stack<string> stringStack = new Stack<string>();
//Console.WriteLine("\nString Stack Operations:");
//stringStack.Push("apple");
//stringStack.Push("banana");
//stringStack.Push("cherry");
//Console.WriteLine("After pushing apple, banana, cherry:");
//Console.WriteLine($"Peek: {stringStack.Peek()}");
//Console.WriteLine($"Pop: {stringStack.Pop()}");
//Console.WriteLine($"Peek after pop: {stringStack.Peek()}");

//Stack<Person> personStack = new Stack<Person>();
//Console.WriteLine("\nPerson Stack Operations:");
//personStack.Push(new Person("Ali", 30));
//personStack.Push(new Person("Abdo", 25));
//personStack.Push(new Person("Hamed", 35));
//Console.WriteLine("After pushing Ali, Abdo, Hamed:");
//Console.WriteLine($"Peek: {personStack.Peek()}");
//Console.WriteLine($"Pop: {personStack.Pop()}");
//Console.WriteLine($"Peek after pop: {personStack.Peek()}");

//Console.ReadKey();

//class Stack<T>
//{
//    private T[] items;
//    private int top;
//    private const int DefaultCapacity = 4;

//    public Stack()
//    {
//        items = new T[DefaultCapacity];
//        top = -1;
//    }

//    public void Push(T item)
//    {
//        if (top + 1 == items.Length)
//        {
//            Array.Resize(ref items, items.Length * 2);
//        }
//        items[++top] = item;
//    }

//    public T Pop()
//    {
//        if (top < 0)
//            throw new InvalidOperationException("Stack is empty.");
//        T item = items[top];
//        items[top--] = default(T);
//        return item;
//    }

//    public T Peek()
//    {
//        if (top < 0)
//            throw new InvalidOperationException("Stack is empty.");
//        return items[top];
//    }

//    public int Count => top + 1;
//}

//class Person
//{
//    public string Name { get; set; }
//    public int Age { get; set; }

//    public Person(string name, int age)
//    {
//        Name = name;
//        Age = age;
//    }

//    public override string ToString()
//    {
//        return $"Person [Name: {Name}, Age: {Age}]";
//    }
//}

#endregion

#region Problem 3: Generic Method for Swapping Elements
/*
    Description: Implement a generic method to swap two elements in an array. 
    Requirements:
            The method should accept an array and two indices.
            Swap the elements at the given indices.
*/

//int[] intArray = { 1, 2, 3, 4, 5 };
//string[] stringArray = { "apple", "banana", "cherry", "date", "elderberry" };
//Person[] personArray =
//{
//    new Person("Ali", 30),
//    new Person("Abdo", 25),
//    new Person("Saryanosy", 35)
//};

//Console.WriteLine("Original Integer Array: " + string.Join(", ", intArray));
//int index1 = InputAndValidate("Enter first index for integer array (0-4): ", false, -1);
//int index2 = InputAndValidate("Enter second index for integer array (0-4): ", false, -1);
//Helper.SwapElements(intArray, index1, index2);
//Console.WriteLine("After Swapping: " + string.Join(", ", intArray));

//Console.WriteLine("\nOriginal String Array: " + string.Join(", ", stringArray));
//index1 = InputAndValidate("Enter first index for string array (0-4): ", false, -1);
//index2 = InputAndValidate("Enter second index for string array (0-4): ", false, -1);
//Helper.SwapElements(stringArray, index1, index2);
//Console.WriteLine("After Swapping: " + string.Join(", ", stringArray));

//Console.WriteLine("\nOriginal Person Array:");
//foreach (var person in personArray) { Console.WriteLine(person); }
//index1 = InputAndValidate("Enter first index for person array (0-2): ", false, -1);
//index2 = InputAndValidate("Enter second index for person array (0-2): ", false, -1);
//Helper.SwapElements(personArray, index1, index2);
//Console.WriteLine("After Swapping:");
//foreach (var person in personArray) { Console.WriteLine(person); }

//Console.ReadKey();

//static class Helper
//{
//    public static void SwapElements<T>(T[] array, int index1, int index2)
//    {
//        if (array == null)
//            throw new ArgumentNullException(nameof(array));
//        if (index1 < 0 || index1 >= array.Length || index2 < 0 || index2 >= array.Length)
//            throw new ArgumentOutOfRangeException("Index out of range.");

//        T temp = array[index1];
//        array[index1] = array[index2];
//        array[index2] = temp;
//    }
//}

//class Person
//{
//    public string Name { get; set; }
//    public int Age { get; set; }

//    public Person(string name, int age)
//    {
//        Name = name;
//        Age = age;
//    }

//    public override string ToString()
//    {
//        return $"Person [Name: {Name}, Age: {Age}]";
//    }
//}

#endregion

#region Problem 4: Generic Method for Finding Maximum Element
/*
     Description: Implement a generic method to find the maximum element in an array.
     Requirements:
            The method should accept an array of any type that implements IComparable. 
            Return the maximum element in the array.
*/

//int[] intArray = { 5, 2, 8, 1, 9, 3 };
//double[] doubleArray = { 3.14, 2.71, 1.41, 4.67, 0.58 };
//Person[] personArray =
//{
//    new Person("Ali", 30),
//    new Person("Mohamed", 25),
//    new Person("Sherif", 35),
//    new Person("Abdo", 28)
//};

//Console.WriteLine("Integer Array: " + string.Join(", ", intArray));
//Console.WriteLine($"Maximum Integer: {Helper.FindMax(intArray)}");

//Console.WriteLine("\nDouble Array: " + string.Join(", ", doubleArray));
//Console.WriteLine($"Maximum Double: {Helper.FindMax(doubleArray):F2}");

//Console.WriteLine("\nPerson Array:");
//foreach (var person in personArray) { Console.WriteLine(person); }
//Console.WriteLine($"Maximum Person (by Age): {Helper.FindMax(personArray)}");

//Console.ReadKey();

//static class Helper
//{
//    public static T FindMax<T>(T[] array) where T : IComparable<T>
//    {
//        if (array == null || array.Length == 0)
//            throw new ArgumentException("Array cannot be null or empty.");

//        T max = array[0];
//        for (int i = 1; i < array.Length; i++)
//        {
//            if (array[i] != null && array[i].CompareTo(max) > 0)
//            {
//                max = array[i];
//            }
//        }
//        return max;
//    }
//}

//class Person : IComparable<Person>
//{
//    public string Name { get; set; }
//    public int Age { get; set; }

//    public Person(string name, int age)
//    {
//        Name = name;
//        Age = age;
//    }

//    public int CompareTo(Person other)
//    {
//        if (other == null) return 1;
//        return Age.CompareTo(other.Age);
//    }

//    public override string ToString()
//    {
//        return $"Person [Name: {Name}, Age: {Age}]";
//    }
//}

#endregion