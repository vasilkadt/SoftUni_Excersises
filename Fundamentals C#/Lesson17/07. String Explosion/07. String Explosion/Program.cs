using System;
using System.Text;

namespace _07._String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();
            StringBuilder outputText = new StringBuilder();
            int bombPower = 0;

            for (int i = 0; i < inputStr.Length; i++)
            {
                char currCh = inputStr[i];

                if (currCh == '>')
                {
                    int currBombPower = convertCharacterToInt(inputStr[i + 1]);
                    outputText.Append(currCh);
                    bombPower += currBombPower;
                }
                else
                {
                    if (bombPower > 0)
                    {
                        bombPower--;
                    }
                    else
                    {
                        outputText.Append(currCh);
                    }
                }
            }
            Console.WriteLine(outputText.ToString());
        }

        static int convertCharacterToInt(char ch)
        {
            return (int)ch - 48;
        }
    }
}
