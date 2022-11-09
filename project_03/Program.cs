using System;
using System.Collections.Generic;


class OneWeek
{
    public static void Main()
    {
        Console.WriteLine("Enter the date (dd/mm/yy): ");

        DateTime parsedDate = DateTime.Parse(Console.ReadLine());

        DateTime addSevenDays = parsedDate.AddDays(7);

        Console.WriteLine(addSevenDays);
    }
}
