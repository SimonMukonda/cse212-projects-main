using System.Collections.Generic;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  
    /// For example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  
    /// Assume that length is a positive integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Step 1: Create an array of size 'length' to hold the results.
        // Step 2: Loop from 0 up to length-1.
        // Step 3: For each index i, calculate (i+1) * number.
        // Step 4: Store the result in the array at position i.
        // Step 5: After the loop finishes, return the array.

        double[] result = new double[length];
        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }
        return result;
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
    public static double[] MultiplesOfAlt(double start, int count)
    {
        double[] multiples = new double[count];
        for (int i = 0; i < count; i++)
        {
            multiples[i] = start * (i + 1);
        }
        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  
    /// For example, if the data is List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3  
    /// then the list after the function runs should be List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  
    /// The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Step 1: Identify how many elements need to be moved. This is given by 'amount'.
        // Step 2: Take the last 'amount' elements from the list.
        // Step 3: Remove those elements from the end of the list.
        // Step 4: Insert those elements at the beginning of the list in the same order.
        // Step 5: The list is now rotated to the right by 'amount'.

        int n = data.Count;
        if (n == 0 || amount <= 0 || amount >= n) return;

        List<int> tail = data.GetRange(n - amount, amount);
        data.RemoveRange(n - amount, amount);
        data.InsertRange(0, tail);
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
    public static List<int> RotateListRightAlt(List<int> data, int amount)
    {
        List<int> lastPart = data.GetRange(data.Count - amount, amount);
        List<int> firstPart = data.GetRange(0, data.Count - amount);

        List<int> rotated = new List<int>();
        rotated.AddRange(lastPart);
        rotated.AddRange(firstPart);

        return rotated;
    }
}
