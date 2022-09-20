using System;
using System.Linq;

namespace _11._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArg = command.Split(' ');
                string cmdType = cmdArg[0];
                if (cmdType == "exchange")
                {
                    int exchandeIndex = int.Parse(cmdArg[1]);
                    if (exchandeIndex < 0 || exchandeIndex >= numbers.Length)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers = exchangeArrayParts(numbers, exchandeIndex);
                }
                else if (cmdType == "max")
                {
                    string oddOrEven = cmdArg[1];

                    int maxIndex = maxElementIndex(numbers, oddOrEven);
                    if (maxIndex == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(maxIndex);
                    }
                }
                else if (cmdType == "max")
                {
                    string oddOrEven = cmdArg[1];
                    int minIndex = minElementIndex(numbers, oddOrEven);
                    if (minIndex == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(minIndex);
                    }
                }
                else if (cmdType == "first" || cmdType == "last")
                {
                    int count = int.Parse(cmdArg[1]);
                    string oddOrEven = cmdArg[2];

                    if (count > numbers.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    if (cmdType == "first")
                    {
                        printFirstElementsOfType(numbers, count, oddOrEven);
                    }
                    else if (cmdType == "last")
                    {
                        printLastElementsOfType(numbers, count, oddOrEven);
                    }
                }
            }
            Console.WriteLine(arrayToString(numbers, numbers.Length));
        }

        static int[] exchangeArrayParts(int[] numbers, int index)
        {
            int[] exchangedNumbers = new int[numbers.Length];
            int exchangedNumberIndex = 0;

            for (int i = index + 1; i < numbers.Length; i++)
            {
                exchangedNumbers[exchangedNumberIndex] = numbers[i];
                exchangedNumberIndex++;
            }
            for (int i = 0; i <= index; i++)
            {
                exchangedNumbers[exchangedNumberIndex] = numbers[i];
                exchangedNumberIndex++;
            }
            return exchangedNumbers;
        }
        
        static int maxElementIndex(int[] numbers, string oddOrEven)
        {
            int index = -1;
            int maxValue = int.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currNum = numbers[i];
                if (oddOrEven == "even")
                {
                    if (currNum % 2 == 0 && currNum >= maxValue)
                    {
                        maxValue = currNum;
                        index = i;
                    }
                }
                else if (oddOrEven == "odd")
                {
                    if (currNum % 2 != 0 && currNum >= maxValue)
                    {
                        maxValue = currNum;
                        index = i;
                    }
                }
            }
            return index;
        }

        static int minElementIndex(int[] numbers, string oddOrEven)
        {
            int index = -1;
            int minValue = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currNum = numbers[i];
                if (oddOrEven == "even")
                {
                    if (currNum % 2 == 0 && currNum <= minValue)
                    {
                        minValue = currNum;
                        index = i;
                    }
                }
                else if (oddOrEven == "odd")
                {
                    if (currNum % 2 != 0 && currNum <= minValue)
                    {
                        minValue = currNum;
                        index = i;
                    }
                }
            }
            return index;
        }

        static void printFirstElementsOfType(int[] numbers, int count, string oddOrEven)
        {
            int[] firstElements = new int[count];
            int firstElementsIndex = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNum = numbers[i];

                if (oddOrEven == "even")
                {
                    if (currentNum % 2 == 0 && firstElementsIndex < count)
                    {
                        firstElements[firstElementsIndex] = currentNum;
                        firstElementsIndex++;
                    }
                }
                else if (oddOrEven == "odd")
                {
                    if (currentNum % 2 != 0 && firstElementsIndex < count)
                    {
                        firstElements[firstElementsIndex] = currentNum;
                        firstElementsIndex++;
                    }
                }
            }
            Console.WriteLine(arrayToString(firstElements, firstElementsIndex));
        }

        static void printLastElementsOfType(int[] numbers, int count, string oddOrEven)
        {
            int[] lastElements = new int[count];
            int lastElementsIndex = 0;

            for (int i = numbers.Length - 1; i > 0; i--)
            {
                int currentNum = numbers[i];

                if (oddOrEven == "even")
                {
                    if (currentNum % 2 == 0 && lastElementsIndex < count)
                    {
                        lastElements[lastElementsIndex] = currentNum;
                        lastElementsIndex++;
                    }
                }
                else if (oddOrEven == "odd")
                {
                    if (currentNum % 2 != 0 && lastElementsIndex < count)
                    {
                        lastElements[lastElementsIndex] = currentNum;
                        lastElementsIndex++;
                    }
                }
            }

            int[] reverse = new int[lastElementsIndex];
            int reverseArrayIndex = 0;
            for (int i = lastElementsIndex - 1; i > 0; i--)
            {
                reverse[reverseArrayIndex] = lastElements[i];
                reverseArrayIndex++;
            }

            Console.WriteLine(arrayToString(reverse, reverseArrayIndex));
        }

        static string arrayToString(int[] arr, int elementsCount)
        {
            string output = string.Empty;
            output += "[";

            for (int i = 0; i < elementsCount; i++)
            {
                if (i == elementsCount - 1)
                {
                    output += arr[i];
                }
                else
                {
                    output += $"{arr[i]}, ";
                }
            }
            output += "]";
            return output;
        }

    }
}
