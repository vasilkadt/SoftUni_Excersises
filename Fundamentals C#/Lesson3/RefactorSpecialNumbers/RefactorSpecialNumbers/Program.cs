using System;

namespace RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                int current = 0;
                bool isSimple = false;
                current = i;
                while (i > 0)
                {
                    sum += current % 10;
                    current = current / 10;
                }
                isSimple = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{current} -> {isSimple}");
            }
        }
    }
}
