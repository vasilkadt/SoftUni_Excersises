using System;

namespace OnTimefortheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            examMinutes += examHour * 60;
            arrivalMinutes += arrivalHour * 60;
            if (examMinutes < arrivalMinutes)
            {
                Console.WriteLine("Late");
                int diff = arrivalMinutes - examMinutes;
                int lateHours = diff / 60;
                int lateMinutes = diff % 60;
                if (lateHours >= 1)
                {
                    if (lateMinutes <= 10)
                    {
                        Console.WriteLine($"{lateHours}:0{lateMinutes} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{lateHours}:{lateMinutes} hours after the start");
                    }
                }
                else if (diff > 0 && lateHours >= 0)
                {
                    Console.WriteLine($"{diff} minutes after the start");
                }
            }
            if ((examMinutes >= arrivalMinutes) && (examMinutes - arrivalMinutes <= 30))
            {
                Console.WriteLine("On time");
                int onTimeMinutes = examMinutes - arrivalMinutes;
                if (examMinutes - arrivalMinutes > 0)
                {
                    Console.WriteLine($"{onTimeMinutes} minutes before the start");
                }
            }

            if ((examMinutes >= arrivalMinutes) && (examMinutes - arrivalMinutes > 30))
            {
                Console.WriteLine("Early");
                int diff = examMinutes - arrivalMinutes;
                int earlyHours = diff / 60;
                int earlyMinutes = diff % 60;
                if (earlyHours >= 1)
                {
                    if (earlyMinutes <= 10)
                    {
                        Console.WriteLine($"{earlyHours}:0{earlyMinutes} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine($"{earlyHours}:{earlyMinutes} hours before the start");
                    }
                }
                else if (diff > 0 && earlyHours >= 0)
                {
                    Console.WriteLine($"{diff} minutes before the start");
                }
            }
        }
    }
}
