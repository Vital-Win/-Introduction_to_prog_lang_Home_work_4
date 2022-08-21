// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Программа, которая возводит число A в натуральную степень B");
Console.WriteLine();

int powAinB(int a, int b)
{
    int sum = 1;
    for (int i = 1; i <= b; i++)
    {
        sum = sum * a;
    }
    return sum;
}


Console.WriteLine("Введите целое положительное число A:");
var numberA = int.Parse(Console.ReadLine()!);
if (numberA < 0)
{
    Console.WriteLine("Вы ввели отрицательное число!");
    return;
}

else if (numberA == 0)
{
    Console.WriteLine("Ноль в любой степепи равен нулю!");
    return;
}


Console.WriteLine("Введите целое положительное число B:");
var numberB = int.Parse(Console.ReadLine()!);
if (numberB < 0)
{
    Console.WriteLine("Вы ввели отрицательное число!");
    return;
}

var result = powAinB(numberA, numberB);
Console.WriteLine("Число " + numberA + " в степени " + numberB + " равно " + result);