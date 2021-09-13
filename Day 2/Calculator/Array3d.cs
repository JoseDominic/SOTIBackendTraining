using System;

class Array3d
{
    public static void arrayTest()
    {
        //declaring array
        int[] array1 = new int[5];

        //declaring and initializing array
        int[,] array2d = { { 1, 2, 3 }, { 4, 5, 6 } };

        int[ , , ] array3d = {
            { { 1, 2, 3 }, { 4, 5, 6 } }, 
            { { 7, 8, 9 }, { 10, 11, 12 } }
        };

        //jagged array - variable column number in each row
        int[][] jaggedArray = new int[6][];
        jaggedArray[0] = new int[3] { 1, 2, 3 }; //intializing first row of jagged array

        Console.WriteLine($"3dArray element at index 0 0 0: {array3d[0,0,0]}");
    }
}