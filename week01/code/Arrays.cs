using System.Security.Cryptography.X509Certificates;

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


        //Plan: The starting position is the number in the parameters, the following positions are the result of multipling the number x the length
        //Example MulitplesOf(4,4) -> 4x1=4, 4x2=8, 4x3=12, 4x4=16
        //I'll start with the length number and decrease it by 1 and at the end I'll sort it
        //I need to create a new list to hold the multiples array
        // I need to create a loop that goes from i=1 to i<= length. It's important it stops when i greater or equal. It will stop when it's equal. 
        // I'll create an x variable that multiplies the number parameter times i, the value in the loop. 
        // I'll add the x var to the multiples List
        List<double> multiples = new();
        for (var i = 1; i <= length; i++)
        {
            var x = number * i;
            multiples.Add(x);
        }
        return multiples.ToArray();
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
        // Ensure the amount is within the range of the list length
        amount = amount % data.Count;
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //PLAN
        ////////////
        ///Ill use the GetRange function
        ///I'll split the data in 2 different ranges, the first range will start in the data.Count- amount position and will include the #amount elements.
        ///The second range will start in the 0 position and go up to the data.Count-amount position.
        ///In order to not duplicate the elements in the data we need to clear it. 
        ///and then add the two ranges we created. 
        List<int> firstRange = data.GetRange(data.Count - amount, amount);
        List<int> secondRange = data.GetRange(0, data.Count - amount);
        data.Clear();
        data.AddRange(firstRange);
        data.AddRange(secondRange);
    }
}
