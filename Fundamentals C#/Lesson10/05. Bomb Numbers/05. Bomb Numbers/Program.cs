using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int[] bombInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int bombNumber = bombInfo[0];
            int bombPower = bombInfo[1];

            while (true)
            { 
                int indexOfBomb = numbers.IndexOf(bombNumber);

                if (indexOfBomb == -1)
                {
                    break;
                }
                DetonateBomb(numbers, indexOfBomb, bombPower);
            }
            Console.WriteLine(numbers.Sum());
        }

        static void DetonateBomb(List<int> numbers, int bombIndex, int bombPower)
        {
            int rightCount = bombIndex + bombPower;

            for (int i = bombIndex; i <= rightCount; i++)
            {
                if (bombIndex >= numbers.Count)
                {
                    break;
                }
                numbers.RemoveAt(bombIndex);
            }

            int leftCount = bombIndex - bombPower;
            if (leftCount < 0)
            {
                leftCount = 0;
            }
            for (int i = leftCount; i < bombIndex; i++)
            {
                if (leftCount >= numbers.Count)
                {
                    break;
                }
                numbers.RemoveAt(leftCount);
            }
        }
    }
}
