﻿using System;

namespace WorkingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            if (time >= 10 && time <= 18)
            {
                switch(day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                    case "Saturday": Console.WriteLine("open"); break;
                    default: Console.WriteLine("closed");break;
                }
            }
            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}
