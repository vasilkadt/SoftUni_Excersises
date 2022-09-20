using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());
            int[] bullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] locks = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int money = int.Parse(Console.ReadLine());

            Queue<int> locksQueue = new Queue<int>(locks);
            Stack<int> bulletsStack = new Stack<int>(bullets);

            int bulletsShoot = 0;
            int counter = 0;
            while (locksQueue.Count > 0 && bulletsStack.Count > 0)
            {
                int currentLock = locksQueue.Peek();
                int currentBullet = bulletsStack.Peek();
                if (currentLock >= currentBullet)
                {
                    locksQueue.Dequeue();
                    bulletsStack.Pop();
                    Console.WriteLine("Bang!");
                    counter++;
                    bulletsShoot++;
                }
                else
                {
                    bulletsStack.Pop();
                    Console.WriteLine("Ping!");
                    counter++;
                    bulletsShoot++;
                }

                if (counter == gunBarrelSize)
                {
                    if (bulletsStack.Count > 0)
                    {
                        Console.WriteLine("Reloading!");
                        counter = 0;
                    }
                }
            }

            if (locksQueue.Count > 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locksQueue.Count}");
            }

            if (bulletsStack.Count > 0)
            {
                Console.WriteLine($"{bulletsStack.Count} bullets left. Earned ${money - bulletsShoot * bulletPrice}");
            }

            if (locksQueue.Count == 0 && bulletsStack.Count == 0)
            {
                Console.WriteLine($"{bulletsStack.Count} bullets left. Earned ${money - bulletsShoot * bulletPrice}");
            }
        }
    }
}
