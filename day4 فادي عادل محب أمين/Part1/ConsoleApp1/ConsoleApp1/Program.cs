//Question 1 Start:


using System;
using System.Net.NetworkInformation;

class Program
{
    static void Main()
    {
        // Initializing a One-Dimensional Array in Three Different Ways

        //Using new int[size]:
        int[] array1 = new int[5];

        //Using an Initializer List:
        int[] array2 = new int[] { 1, 2, 3, 4, 5 };

        //Using Array Syntax Sugar:
        int[] array3 = { 1, 2, 3, 4, 5 };

        // Assigning values to array1
        for (int i = 0; i < array1.Length; i++)
        {
            array1[i] = i + 1;
        }

        // Printing array1
        Console.WriteLine("Array1:");
        foreach (int value in array1)
        {
            Console.WriteLine(value);
        }

        // Printing array2
        Console.WriteLine("Array2:");
        foreach (int value in array2)
        {
            Console.WriteLine(value);
        }

        // Printing array3
        Console.WriteLine("Array3:");
        foreach (int value in array3)
        {
            Console.WriteLine(value);
        }

        // Demonstrating IndexOutOfRangeException
        try
        {
            Console.WriteLine(array1[10]);
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine("IndexOutOfRangeException caught: " + e.Message);
        }
    }
}

/*What is the default value assigned to array elements in C#? 
In C#, the default value assigned to array elements of type int is 0.
This means that if you create an array of integers
and do not explicitly assign values to its elements,
they will all be initialized to 0.
 */


//Question 1 End:







//Question 2 Start:

using System;

class Program
{
    static void Main()
    {
        // Create two arrays
        int[] arr1 = { 1, 2, 3, 4, 5 };
        int[] arr2 = new int[arr1.Length];

        // Perform a shallow copy
        arr1.CopyTo(arr2, 0);

        // Modify arr1 and demonstrate the effect on arr2 (shallow copy)
        arr1[0] = 10;
        Console.WriteLine("After modifying arr1:");
        Console.WriteLine("arr1: " + string.Join(", ", arr1));
        Console.WriteLine("arr2: " + string.Join(", ", arr2));

        // Perform a deep copy using the Clone method
        int[] arr3 = (int[])arr1.Clone();

        // Modify arr1 and demonstrate the effect on arr3 (deep copy)
        arr1[1] = 20;
        Console.WriteLine("After modifying arr1 again:");
        Console.WriteLine("arr1: " + string.Join(", ", arr1));
        Console.WriteLine("arr3: " + string.Join(", ", arr3));
    }
}

//Note:
/*in the deep copy: We use the Clone method to perform a deep copy of arr1 to arr3.
Modifying arr1 will not affect arr3
because Clone creates a new array with the same values.*/

//What is the difference between Array.Clone() and Array.Copy()? 
/*Array.Clone(): This method creates a shallow copy of the array.
It returns a new array object containing all the elements
in the original array. For value types.

Array.Copy(): This method copies a range of elements from one array to another.
It allows you to specify the source and destination arrays.
*/

//Question 2 End:







//Question 3 Start:
using System;

class Program
{
    static void Main()
    {
        // Create a 2D array for 3 students and 3 subjects
        int[,] grades = new int[3, 3];

        // Take input from the user to fill the array
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Enter grades for student {i + 1}:");
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Subject {j + 1}: ");
                grades[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Print the grades for each student using nested loops
        Console.WriteLine("\nGrades for each student:");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Student {i + 1}:");
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine($"Subject {j + 1}: {grades[i, j]}");
            }
        }
    }
}

/*Difference Between GetLength() and Length for Multi-Dimensional Arrays
GetLength(int dimension): This method returns the number of elements
in the specified dimension of the array.
For example:
grades.GetLength(0) returns the number of rows (students),
grades.GetLength(1) returns the number of columns (subjects).

Length: This property returns the total number of elements in the array.
For a 3x3 array, grades.Length would return 9, as there are 9 elements in total
*/

//Question 3 End:






//Question 4 Start:

using System;

class Program
{
    static void Main()
    {
        // Initialize an array
        int[] array = { 5, 3, 8, 1, 2 };

        // Sort the array
        Array.Sort(array);
        Console.WriteLine("After Sort: " + string.Join(", ", array));
        // Before: 5, 3, 8, 1, 2
        // After: 1, 2, 3, 5, 8

        // Reverse the array
        Array.Reverse(array);
        Console.WriteLine("After Reverse: " + string.Join(", ", array));
        // Before: 1, 2, 3, 5, 8
        // After: 8, 5, 3, 2, 1

        // Find the index of an element
        int index = Array.IndexOf(array, 3);
        Console.WriteLine("Index of 3: " + index);
        // Index of 3: 2

        // Copy the array
        int[] arrayCopy = new int[array.Length];
        Array.Copy(array, arrayCopy, array.Length);
        Console.WriteLine("After Copy: " + string.Join(", ", arrayCopy));
        // Before: (arrayCopy is empty)
        // After: 8, 5, 3, 2, 1

        // Clear the array
        Array.Clear(array, 0, array.Length);
        Console.WriteLine("After Clear: " + string.Join(", ", array));
        // Before: 8, 5, 3, 2, 1
        // After: 0, 0, 0, 0, 0
    }
}

/*Difference Between Array.Copy() and Array.ConstrainedCopy()
Array.Copy(): This method copies a range of elements from one array to another.
It is flexible and can be used with arrays of different types

Array.ConstrainedCopy(): This method is similar to Array.Copy(),
but it ensures that the entire operation is atomic.
If any part of the copy operation fails,
no changes are made to the destination array.

*/


//Question 4 End:




//Question 5 Start:

using System;

class Program
{
    static void Main()
    {
        // Initialize a 1D array
        int[] array = { 1, 2, 3, 4, 5 };

        // Using a for loop to print all elements
        Console.WriteLine("Using for loop:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }

        // Using a foreach loop to print all elements
        Console.WriteLine("Using foreach loop:");
        foreach (int element in array)
        {
            Console.WriteLine(element);
        }

        // Using a while loop to print all elements in reverse order
        Console.WriteLine("Using while loop (reverse order):");
        int index = array.Length - 1;
        while (index >= 0)
        {
            Console.WriteLine(array[index]);
            index--;
        }
    }
}

/*Why is foreach Preferred for Read-Only Operations on Arrays?
The foreach loop is preferred for read-only operations on arrays because:

Simplicity: It provides a simpler and more readable syntax for iterating
through all elements of an array.

Safety: It prevents modification of the array elements,
reducing the risk of unintended changes.
The foreach loop does not allow changing the elements of the array,
making it ideal for read-only operations.

Less Error-Prone: It eliminates the need for managing loop counters
and boundary conditions, which can be a source of errors in for and while loops.
 */

//Question 5 End:






//Question 6 Start:
using System;

class Program
{
    static void Main()
    {
        int number;
        bool isValid;

        do
        {
            Console.WriteLine("Please enter a positive odd number:");
            string input = Console.ReadLine();
            isValid = int.TryParse(input, out number) && number > 0 && number % 2 != 0;

            if (!isValid)
            {
                Console.WriteLine("Invalid input. Make sure it's a positive odd number.");
            }
        } while (!isValid);

        Console.WriteLine($"You entered a valid positive odd number: {number}");
    }
}


/*Why is Input Validation Important When Working with User Inputs?

Data Integrity: It ensures that the data processed by the program is
accurate and consistent,
reducing the risk of errors and inconsistencies.

Reliability: It ensures that the program operates correctly
by handling unexpected
or incorrect inputs gracefully.
*/

//Question 6 End:







//Question 7 Start:
using System;

class Program
{
    static void Main()
    {
        // Create a 2D array with fixed values
        int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        // Print the array elements in a matrix format
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}


/*How can you format the output of a 2D array for better readability?
i can use:
the line breaks: use Console.WriteLine() to move to the next line
after printing each row.

use tabs or spaces: use the \t (tab) character or spaces
to align the elements in columns.

*/

//Question 7 End:














//Question 8 Start:


using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a month number (1-12):");
        string input = Console.ReadLine();
        int monthNumber;

        if (int.TryParse(input, out monthNumber))
        {
            // Using if-else statement
            string monthNameIfElse = "";
            if (monthNumber == 1) monthNameIfElse = "January";
            else if (monthNumber == 2) monthNameIfElse = "February";
            else if (monthNumber == 3) monthNameIfElse = "March";
            else if (monthNumber == 4) monthNameIfElse = "April";
            else if (monthNumber == 5) monthNameIfElse = "May";
            else if (monthNumber == 6) monthNameIfElse = "June";
            else if (monthNumber == 7) monthNameIfElse = "July";
            else if (monthNumber == 8) monthNameIfElse = "August";
            else if (monthNumber == 9) monthNameIfElse = "September";
            else if (monthNumber == 10) monthNameIfElse = "October";
            else if (monthNumber == 11) monthNameIfElse = "November";
            else if (monthNumber == 12) monthNameIfElse = "December";
            else monthNameIfElse = "Invalid month number";

            Console.WriteLine("Using if-else: " + monthNameIfElse);

            // Using switch statement
            string monthNameSwitch = monthNumber switch
            {
                1 => "January",
                2 => "February",
                3 => "March",
                4 => "April",
                5 => "May",
                6 => "June",
                7 => "July",
                8 => "August",
                9 => "September",
                10 => "October",
                11 => "November",
                12 => "December",
                _ => "Invalid month number"
            };

            Console.WriteLine("Using switch: " + monthNameSwitch);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid month number (1-12).");
        }
    }
}

/*When should you prefer a switch statement over if-else?
Readability: Switch statements are often more readable and
concise when dealing with multiple conditions
that depend on the value of a single variable.
*/

//Question 8 End:









//Question 10 Start:
using System;

class Program
{
    static void Main()
    {
        // Create an array of integers
        int[] array = { 1, 2, 3, 4, 5 };

        // Calculate and print the sum using a for loop
        int sumFor = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sumFor += array[i];
        }
        Console.WriteLine("Sum using for loop: " + sumFor);

        // Calculate and print the sum using a foreach loop
        int sumForeach = 0;
        foreach (int element in array)
        {
            sumForeach += element;
        }
        Console.WriteLine("Sum using foreach loop: " + sumForeach);
    }
}

/*Which loop (for or foreach) is more efficient for calculating the sum of an 
array, and why?

while both loops are efficient for calculating the sum of an array,
the foreach loop is often preferred for its simplicity and readability
in read-only operations. However, the for loop can be more flexible
when you need to work with indices or modify the array elements.

*/

//Question 10 End: