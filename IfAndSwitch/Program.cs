
using System;

int weekday = Convert.ToInt32(DateTime.Now.DayOfWeek);

//Console.WriteLine(weekday);

Console.WriteLine("Tänane nädalapäev on:");

switch (weekday) //väärtus mida kontrollitakse
    {
    case 0: //case 0 = if (weekday == 0)
        Console.WriteLine("Pühapäev");
        break;
    case 1:
        Console.WriteLine("Esmaspäev");
        break;
    case 2:
        Console.WriteLine("Teisipäev");
        break;
    case 3:
        Console.WriteLine("Kolmapäev");
        break;
    case 4:
        Console.WriteLine("Neljapäev");
        break;
    case 5:
        Console.WriteLine("Reede");
        break;
    case 6:
        Console.WriteLine("Laupäev");
        break;
    default:
        Console.WriteLine("Andmed pole kalendrist loetavad!!")
}   

    Console.WriteLine("Kena päeva!!");

