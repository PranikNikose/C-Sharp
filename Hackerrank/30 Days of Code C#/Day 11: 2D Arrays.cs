using System;

class Solution
{
    static void Main()
    {
        int[][] arr = new int[6][];

        for (int arrelement = 0; arrelement < 6; arrelement++)
        {
            arr[arrelement] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }
        int Result = -9 * 7;
        int RowCount = arr.Length;
        int ColumnCount = arr[0].Length;

        for (int c = 0; c < ColumnCount - 2; c++)
        {
            for (int r = 0; r < RowCount - 2; r++)
            {
                int FirstRowSum = arr[r][c] + arr[r][c + 1] + arr[r][c + 2];
                int SecondRowSum = arr[r + 1][c + 1];
                int ThirdRowSum = arr[r + 2][c] + arr[r + 2][c + 1] + arr[r + 2][c + 2];
                int TotalHourGlass = FirstRowSum + SecondRowSum + ThirdRowSum;

                Result = Math.Max(Result, TotalHourGlass);
            }
        }
        Console.WriteLine(Result);
    }
}
