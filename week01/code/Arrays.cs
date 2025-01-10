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

        // first, create an array of doubles with the same length as the parameter.
        // then, use a for loop  to iterate through the array and set the value in each index to the product of the number parameter and the index.
        // then, return the new array.

        var multiples = new double[length];
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        return multiples; // replace this return statement with your own
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

        // first, create a new list to store the values at the end that will be swapped to the beginning of the list.
        // then, use a for loop to iterate through the list and set the value of the starting index to the value of the last index minus the amount parameter. 
        // Inside the loop, add the changing numbers to the temporary list.
        // then, use a for loop to iterate through the temporary list and set the value at the index to the value at the index plus the amount parameter.
        // then, assing the values in the temporary list to the beginning of the list, the same index is used for both so the numbers will be placed at the beginning of the list.
        // you don't need to return anything because the list is being modified in place.

        var temp = new List<int>();

        for (int i = data.Count - amount; i < data.Count; i++)
        {
            temp.Add(data[i]);
        }
        for (int i = data.Count - amount - 1; i >= 0; i--)
        {
            data[i + amount] = data[i];
        }
        for (int i = 0; i < amount; i++)
        {
            data[i] = temp[i];
        }
    }
}
