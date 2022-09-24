/*
9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
78 -> 8 
12-> 2 
85 -> 8
*/
int getRandomNumberFromRange(int minBorder, int maxBorder)
{
    int result = new int();
    result = new Random().Next(minBorder, maxBorder + 1);
    return result;
}


int randomNumber = getRandomNumberFromRange(100,999);
Console.WriteLine($"Случайное значение {randomNumber}");
int number3 = randomNumber%10;
int number1 = randomNumber/100;
int resultnumber = number1*10+number3;
Console.WriteLine($"Результат {resultnumber}");
