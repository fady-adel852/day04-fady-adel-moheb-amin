//Question 2 and 3 Start:

using System;

enum DayOfWeek
{
    Saturday = 1,
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday
}


class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number (1-7):");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int dayNumber) && dayNumber >= 1 && dayNumber <= 7)
        {
            DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), dayNumber.ToString());
            Console.WriteLine($"The corresponding day is: {day}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
        }
    }
}

/*What happens if the user enters a value outside the range of 1 to 7?
If the user enters a value outside the range of 1 to 7,
the program will display the message: "Invalid input.
Please enter a number between 1 and 7."*/

//Question 2 and 3 End: