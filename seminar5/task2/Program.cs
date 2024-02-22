// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int[,] CreateMatrix(int rows, int cols) //метод создания двумерного массива случайных чисел от 0 до 100
{
    int[,] matr = new int[rows, cols]; // [стр, столбцы]
    Random rnd = new Random();
    for (int i = 0; i < rows; i++) // rows = matr.GetLength(0)
    {
        for (int j = 0; j < cols; j++) // columns = matr.GetLength(1)
        {
            matr[i, j] = rnd.Next(101); // [0,100], (0, 101)
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr) //метод вызова этого массива
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

void PrintArray(int[,] array) //метод вызова нового массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] SwapFirstLastRows(int[,] array) // метод обмена первой с последней строкой
{
    for(int i = 0; i < array.GetLength(1); i++)
    {
        SwapItems(array, i);
    }
    return array;
}

void SwapItems(int[,] array, int i) //метод обмена элементами массива
{
    int temp = array[0, i];
    array[0, i] = array[array.GetLength(0) - 1, i];
    array[array.GetLength(0) - 1, i] = temp;
}



Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateMatrix(rows, cols); // Матрица rows на colums
PrintMatrix(array);
Console.WriteLine("Новый массив:");
PrintArray(SwapFirstLastRows(array));