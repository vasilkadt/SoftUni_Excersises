using System;
using System.Collections.Generic;

namespace _08.SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            string guests = Console.ReadLine();
            HashSet<string> VIP = new HashSet<string>();
            HashSet<string> regular = new HashSet<string>();

            while (guests != "PARTY")
            {
                if (guests.Length == 8)
                {
                    if ((int)guests[0] >= 48 && (int)guests[0] <= 57)
                    {
                        VIP.Add(guests);
                    }
                    else
                    {
                        regular.Add(guests);
                    }
                }
                guests = Console.ReadLine();
            }

            guests = Console.ReadLine();
            while (guests != "END")
            {
                if (VIP.Contains(guests))
                {
                    VIP.Remove(guests);
                }

                if (regular.Contains(guests))
                {
                    regular.Remove(guests);
                }

                guests = Console.ReadLine();
            }

            Console.WriteLine(VIP.Count + regular.Count);
            foreach (var vip in VIP)
            {
                Console.WriteLine(vip);
            }
            foreach (var reg in regular)
            {
                Console.WriteLine(reg);
            }
        }
    }
}
