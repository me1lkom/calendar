using System;

class Program
{
    static void Main()
    {
        Console.Write("С какого дня начинается май? (1-пн, 2-вт, 3-ср, 4-чт, 5-пт, 6-сб, 7-вс):");
        if (int.TryParse(Console.ReadLine(), out int startDay) && startDay >= 1 && startDay <= 7)
        {
            Dev(startDay);
        }
        else
        {
            Console.WriteLine("Ошибка: введите число от 1 до 7!");
            Main();
        }
    }

    static void Dev(int startDay)
    {
        Console.Write("Введите число мая: ");
        if (int.TryParse(Console.ReadLine(), out int day) && day >= 1 && day <= 31)
        {
            int currentDay = startDay;

            for (int i = 1; i < day; i++)
            {
                currentDay++;
                if (currentDay > 7)
                {
                    currentDay = 1;
                }
            }

            int weekDay = currentDay;

            if ((day >= 1 && day <= 5) || (day >= 8 && day <= 10))
            {
                Console.WriteLine("Выходной день - праздник");
            }
            else if (weekDay == 6 || weekDay == 7)
            {
                Console.WriteLine("Выходной день");
            }
            else
            {
                Console.WriteLine("Рабочий день");
            }
        }
        else
        {
            Console.WriteLine("Ошибка: введите число от 1 до 31!");
            Dev(startDay);
        }

        Console.WriteLine("Нажмите Enter для выхода...");
        Console.ReadLine();
    }
}