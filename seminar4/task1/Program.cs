// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

while (true)
{
    Console.Write("Введите число или текст: ");
    string text = Console.ReadLine();
    if (text == "q")
    {
        break;
    }
    int number;
    if (int.TryParse(text, out number))
    {
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        if (sum % 2 == 0)
        {
            Console.WriteLine("[STOP]");
            break;
        }
    }        
}
