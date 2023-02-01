
int weekday = Convert.ToInt32(DateTime.Now.DayOfWeek);

//Console.WriteLine(weekday);

Console.WriteLine("Tänane nädalapäev on:");

if(weekday ==0)
{
    Console.WriteLine("Pühapäev");
}
else if (weekday == 1)
{
    Console.WriteLine("Esmaspäev");
}
else if (weekday == 2)
{
    Console.WriteLine("Teisipäev");
}
else if (weekday == 3)
{
    Console.WriteLine("Kolmapäev");
}
else if (weekday == 4)
{
    Console.WriteLine("Neljapäev");
}
else if (weekday == 5)
{
    Console.WriteLine("Reede");
}
else 
{
    Console.WriteLine("Laupäev");
}
