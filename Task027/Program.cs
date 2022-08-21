// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Программа, которая принимает на вход число и выдаёт сумму цифр в числе.");
Console.WriteLine();
Console.WriteLine("Введите целое число:");

int SumOfNumbers(int a)
{
    int sum = 0;

    if (a < 0)
        a = a * (-1);

    while (a > 0)
    {
        sum = sum + a % 10;
        a = a / 10;
    }
    return sum;
}

var number = int.Parse(Console.ReadLine()!);

var result = SumOfNumbers(number);
Console.WriteLine("Сумма цифр введенного числа: " + result);