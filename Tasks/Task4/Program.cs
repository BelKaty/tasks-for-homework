Console.Write("Введите первое значение:");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе значение:");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье значение:");
int numberC = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    if (numberA > numberC)
    {
        Console.Write(numberA + " - самое большое число из заданных");
    }
    else
    {
        Console.Write(numberC + " - самое большое число из заданных");
    }
}
else
{
    if (numberB > numberC)
    {
        Console.Write(numberB + " - самое большое число из заданных");
    }
    else
    {
        Console.Write(numberC + " - самое большое число из заданных");
    }
}