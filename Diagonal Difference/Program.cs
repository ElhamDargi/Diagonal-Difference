using System;
using System.Collections.Generic;

namespace Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> list2D = new List<List<int>>( );
            List<int> row1 = new List<int> {11,2,4 };
            List<int> row2 = new List<int> { 4,5,6 };
            List<int> row3 = new List<int> { 10,8,-12 };
            list2D.Add((row1));
            list2D.Add(row2);
            list2D.Add(row3);
            int sumL2R = 0, sumR2L = 0;
            for (int i = 0, j = list2D.Count; i < list2D.Count; i++,j--)
            {
                sumL2R += list2D[i][i];
                sumR2L+= list2D[i][j-1];
            }

            int result = Math.Abs(sumL2R - sumR2L);
            Console.WriteLine("Hello World!");
        }
    }
}
