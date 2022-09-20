using System;
using System.Text.RegularExpressions;
 //NOT CORRECT
namespace _05._Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternHealth = @"([A-Za-z]+)";
            string patternDamage = @"(-*\d+(.\d+)?)";
            decimal totalDamage = 0m;
            int totalHealt = 0;

            string[] input = Console.ReadLine().Split(',');
            for (int i = 0; i < input.Length; i++)
            {
                Match helthInfo = Regex.Match(input[i], patternHealth);
                Match damageInfo = Regex.Match(input[i], patternDamage);
                if(helthInfo.Success)
                {
                    char helth = char.Parse(helthInfo.Groups[0].Value);
                    totalHealt += (int)helth;
                }
                if(damageInfo.Success)
                {
                    decimal damage = decimal.Parse(damageInfo.Groups[0].Value);
                    totalDamage += damage;
                }
            }
        }
    }
}
