// Задача 3: Напишите программу, которая принимает на вход целое число
// из отрезка [10, 99] и показывает наибольшую цифру числа.
Console.Write("Введите двузначное число: ");
int number = int.Parse(Console.ReadLine()!);
int firstDigit = number / 10;
int secondDigit = number % 10;
if(firstDigit > secondDigit)
{
    Console.WriteLine(firstDigit);
}
else
{
    Console.WriteLine(secondDigit);
}