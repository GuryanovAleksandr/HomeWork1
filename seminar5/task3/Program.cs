// Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

int[,] CreateMatrix(int rows, int columns) //метод создания массива случайных чисел от 0 до 100
{
    int[,] matr = new int[rows, columns]; // [стр, столбцы]
    Random rnd = new Random();
    for (int i = 0; i < rows; i++) // rows = matr.GetLength(0)
    {
        for (int j = 0; j < columns; j++) // columns = matr.GetLength(1)
        {
            matr[i, j] = rnd.Next(101); // [0,100], (0, 101)
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // стр
    {
        for (int j = 0; j < matr.GetLength(1); j++) // столбцы
        {
            Console.Write($"{matr[i, j]}\t"); // "\t" = 4 пробела
        } // Закончили обход 0 строки, идем в 1
        Console.WriteLine(); // Перенос на новую строчку
    }
}

int[] SumRows(int[,] array)
{
    int[] sums = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int CurrentSum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            CurrentSum += array[i, j];
            sums[i] = CurrentSum;
        }
    }
    return sums;
}

int MinIndex(int[] array)
{
    int minIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < array[minIndex])
        {
            minIndex = i;
        }
    }
    return minIndex;
}

void PrintResults(int[,] numbers)
{
    int[] sums = SumRows(numbers);
    int minIndex = MinIndex(sums);
    Console.WriteLine(minIndex);
}

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateMatrix(rows, cols); // Матрица rows на cols
PrintMatrix(array);
int[] res = SumRows(array);
Console.WriteLine($"Созданный одномерный массив: [ {string.Join("; ", res)} ]");
Console.Write("Индекс строки с минимальной суммой элементов: ");
PrintResults(array);