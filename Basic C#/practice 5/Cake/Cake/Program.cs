using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int piecesCake = length * width;

            string input = "";
            int countLeftPieces = piecesCake;
            while (piecesCake > 0)
            {
                input = Console.ReadLine();
                piecesCake -= int.Parse(input);
                if (input == "STOP")
                {
                    break;
                }
                countLeftPieces-= int.Parse(input);
            }
            if (input == "STOP")
            {
                Console.WriteLine($"{countLeftPieces} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(countLeftPieces)} pieces more.");
            }
        }
    }
}
