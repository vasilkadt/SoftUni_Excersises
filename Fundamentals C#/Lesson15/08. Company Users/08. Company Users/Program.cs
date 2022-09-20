using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> company = new Dictionary<string, List<string>>();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] information = command.Split("->", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string companyName = information[0];
                string employeeName = information[1];

                if (!company.ContainsKey(companyName))
                {
                    company[companyName] = new List<string>();
                }
                if (company[companyName].Contains(employeeName))
                {
                    continue;
                }
                company[companyName].Add(employeeName);
            }

            foreach (var item in company)
            {
                Console.WriteLine($"{item.Key.Trim()}");
                foreach (var employee in item.Value)
                {
                    Console.WriteLine($"-- {employee.Trim()}");
                }
            }
        }
    }
}
