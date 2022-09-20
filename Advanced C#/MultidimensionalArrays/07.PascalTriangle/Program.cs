using System;

namespace _07.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int currentlength = 1;
            long[][] triangle = new long[rows][];

            for (int i = 0; i < rows; i++)
            {
                triangle[i] = new long[currentlength];
                triangle[i][0] = 1;                             //-> set triangle's firstelement value 0
                triangle[i][currentlength - 1] = 1;             //-> set triangle's lastelement value 0

                if (currentlength > 2)
                {
                    for (int j = 1; j < currentlength - 1; j++)
                    {
                        triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
                    }
                }

                currentlength++;
            }

            foreach (long[] row in triangle)
            {
                Console.WriteLine(String.Join(' ', row));
            }
        }
    }
}