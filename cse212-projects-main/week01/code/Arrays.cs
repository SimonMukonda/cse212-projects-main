public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        return []; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
    }
}



// Step 1: Define the function MultiplesOf that takes two parameters:
//         - start (the starting number)
//         - count (the number of multiples to generate)
//
// Step 2: Create an array of type double with length equal to count.
//         This will hold the multiples.
//
// Step 3: Use a for loop to iterate from 0 up to count - 1.
//         On each iteration, calculate the multiple as start * (i+1).
//         Store this value in the array.
//
// Step 4: After the loop finishes, return the array.
//
// Example: MultiplesOf(3,5) should return {3,6,9,12,15}.

public static double[] MultiplesOf(double start, int count)
{
    // Create an array to hold the multiples
    double[] multiples = new double[count];

    // Fill the array with multiples of 'start'
    for (int i = 0; i < count; i++)
    {
        multiples[i] = start * (i + 1);
    }

    // Return the filled array
    return multiples;
}




// Step 1: Define the function RotateListRight that takes two parameters:
//         - data (a List of integers)
//         - amount (how many positions to rotate to the right)
//
// Step 2: Understand rotation:
//         Rotating right by 'amount' means the last 'amount' elements
//         move to the front, and the rest shift to the right.
//
// Step 3: Use slicing with GetRange:
//         - Take the last 'amount' elements: data.GetRange(data.Count - amount, amount)
//         - Take the first part: data.GetRange(0, data.Count - amount)
//
// Step 4: Create a new list and add the two slices in order:
//         - First add the last 'amount' elements
//         - Then add the remaining elements
//
// Step 5: Return the new list.
//
// Example: RotateListRight({1,2,3,4,5,6,7,8,9}, 5)
//          → {5,6,7,8,9,1,2,3,4}

public static List<int> RotateListRight(List<int> data, int amount)
{
    // Get the last 'amount' elements
    List<int> lastPart = data.GetRange(data.Count - amount, amount);

    // Get the first part (everything before the last 'amount' elements)
    List<int> firstPart = data.GetRange(0, data.Count - amount);

    // Create a new list and add both parts
    List<int> rotated = new List<int>();
    rotated.AddRange(lastPart);
    rotated.AddRange(firstPart);

    // Return the rotated list
    return rotated;
}





using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // --- Testing MultiplesOf ---
        Console.WriteLine("Testing MultiplesOf:");
        double[] multiples = MultiplesOf(3, 5);
        Console.WriteLine("MultiplesOf(3,5): " + string.Join(", ", multiples));

        multiples = MultiplesOf(7, 4);
        Console.WriteLine("MultiplesOf(7,4): " + string.Join(", ", multiples));

        Console.WriteLine();

        // --- Testing RotateListRight ---
        Console.WriteLine("Testing RotateListRight:");
        List<int> data = new List<int>{1,2,3,4,5,6,7,8,9};

        List<int> rotated = RotateListRight(data, 5);
        Console.WriteLine("RotateListRight({1..9}, 5): " + string.Join(", ", rotated));

        rotated = RotateListRight(data, 3);
        Console.WriteLine("RotateListRight({1..9}, 3): " + string.Join(", ", rotated));
    }

    // MultiplesOf function from Part 1
    public static double[] MultiplesOf(double start, int count)
    {
        // Create an array to hold the multiples
        double[] multiples = new double[count];

        // Fill the array with multiples of 'start'
        for (int i = 0; i < count; i++)
        {
            multiples[i] = start * (i + 1);
        }

        // Return the filled array
        return multiples;
    }

    // RotateListRight function from Part 2
    public static List<int> RotateListRight(List<int> data, int amount)
    {
        // Get the last 'amount' elements
        List<int> lastPart = data.GetRange(data.Count - amount, amount);

        // Get the first part (everything before the last 'amount' elements)
        List<int> firstPart = data.GetRange(0, data.Count - amount);

        // Create a new list and add both parts
        List<int> rotated = new List<int>();
        rotated.AddRange(lastPart);
        rotated.AddRange(firstPart);

        // Return the rotated list
        return rotated;
    }
}
