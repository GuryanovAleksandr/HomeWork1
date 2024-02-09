// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.
Console.Write("Введите координату X: ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Y: ");
int y = int.Parse(Console.ReadLine()!);
if (x > 0 && y > 0)
{
    Console.WriteLine("I координатная четверть");
}
if (x < 0 && y > 0)
{
    Console.WriteLine("II координатная четверть");
}
if (x < 0 && y < 0)
{
    Console.WriteLine("III координатная четверть");
}
if (x > 0 && y < 0)
{
    Console.WriteLine("IV координатная четверть");
}