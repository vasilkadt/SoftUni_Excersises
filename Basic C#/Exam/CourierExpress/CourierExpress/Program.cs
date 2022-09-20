using System;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double delivery = double.Parse(Console.ReadLine());
            string service = Console.ReadLine();
            int distance = int.Parse(Console.ReadLine());
            double stotinkiForKm = 0; ;
            if (service == "standard")
            {
                if (delivery < 1)
                {
                    stotinkiForKm = 3;
                }
                else if (delivery >= 1 && delivery < 10)
                {
                    stotinkiForKm = 5;
                }
                else if (delivery >= 10 && delivery < 40)
                {
                    stotinkiForKm = 10;
                }
                else if (delivery >= 40 && delivery < 90)
                {
                    stotinkiForKm = 15;
                }
                else if (delivery >= 90 && delivery < 150)
                {
                    stotinkiForKm = 20;
                }
                Console.WriteLine($"The delivery of your shipment with weight of {delivery:F3} kg. would cost {distance * stotinkiForKm / 100:F2} lv.");
            }
            else if (service == "express")
            {
                if (delivery < 1)
                {
                    stotinkiForKm = 0.03 * 0.8 * delivery * distance + distance * 0.03;
                }
                else if (delivery >= 1 && delivery < 10)
                {
                    stotinkiForKm = delivery * 0.4 * 0.05 * distance + distance * 0.05;
                }
                else if (delivery >= 10 && delivery < 40)
                {
                    stotinkiForKm = delivery * 0.10 * 0.05 * distance + distance * 0.1;
                }
                else if (delivery >= 40 && delivery < 90)
                {
                    stotinkiForKm = delivery * 0.15 * 0.02 * distance + distance * 0.15;
                }
                else if (delivery >= 90 && delivery < 150)
                {
                    stotinkiForKm = 0.20 * 0.01 * delivery * distance + distance * 0.2;
                }
                Console.WriteLine($"The delivery of your shipment with weight of {delivery:F3} kg. would cost {stotinkiForKm:F2} lv.");
            }
        }
    }
}