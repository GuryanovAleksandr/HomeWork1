﻿//Задача 4: Напишите программу, которая на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую.
Console.Write("Введите натуральное число: ");
int number = int.Parse(Console.ReadLine()!);
if (number < 10)
{
Console.WriteLine(number);
}
else
{
    while (number > 0)
    {
        int currentDigit = number % 10;
        number /= 10;
        if (number > 0)
        {
            Console.Write(currentDigit + ", ");
        }
        else
        {
            Console.WriteLine(currentDigit);
        }
    }
}