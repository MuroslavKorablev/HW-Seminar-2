System.Console.WriteLine("Введите день недели");
int dayOfWeek = Convert.ToInt32(Console.ReadLine());
if (dayOfWeek == 6 || dayOfWeek == 7)
{
    System.Console.WriteLine("Это выходной");
}
else if (dayOfWeek > 7 || dayOfWeek < 1 )
{
    System.Console.WriteLine("Error");
}
else
{
    System.Console.WriteLine("Это не выходной");
}

