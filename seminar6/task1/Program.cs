void PrintMatrix(char[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t "); // "\t" = 4 пробела
        }
        Console.WriteLine(); //перенос на новую строку
    }
}

string CreateStringFromMatrix(char[,] array)
{
    string result = "";
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result += array[i, j];
        }
    }
    return result;
}
char[,] charMatrix = new char[,] { { 'a', 'b', 'c' }, { 'd', 'e', 'f' } };
Console.WriteLine("Массив: ");
PrintMatrix(charMatrix);
string result = CreateStringFromMatrix(charMatrix);
Console.WriteLine($"Строка: {result}");