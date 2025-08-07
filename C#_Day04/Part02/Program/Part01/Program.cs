// Top - Level statement to save some space 

#region Define an enum called DayOfWeek with values: Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday. 

// The definition of the enum is at the end of the doucment (top - level statement rule)

//Console.WriteLine("Days of the Week:");
//foreach (DayOfWeek day in Enum.GetValues(typeof(DayOfWeek)))
//{
//    Console.WriteLine(day);
//}

#endregion

#region Write a program that takes an integer input from the user (1-7) and prints the corresponding day using the enum. 

//Console.Write("Enter a number (1-7) to select a day of the week: ");
//string input = Console.ReadLine();
//int DayNumber;
//while (!int.TryParse(input, out DayNumber) || DayNumber < 1 || DayNumber > 7)
//{
//    Console.Write("Invalid input. Please enter a number between 1 and 7: ");
//    input = Console.ReadLine();
//}

//// Use Enum.Parse to convert an integer to an enum value. 
//DayOfWeek day = (DayOfWeek)DayNumber;
//Console.WriteLine($"The day is: {day}");

#endregion

#region What happens if the user enters a value outside the range of 1 to 7?

/*
 * If the integer does not match any defined enum value, the cast still succeeds,
 * and the enum takes on the raw integer value. it displays as the integer itself rather than 
 * an enum member name, because no matching name exists in the enum definition.
 *
 */

#endregion

Console.ReadKey();

enum DayOfWeek
{
    Monday = 1,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}