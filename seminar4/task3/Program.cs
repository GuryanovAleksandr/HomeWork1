// Задача 3: Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

int[] arr = { 1, 2, 3, 4, 5 }; // Исходный массив
int position;
Console.WriteLine($"Массив до: [ {string.Join("; ", arr)} ]");
for (int i = 0; i < arr.Length / 2; i++)
{
    position = arr[i];
    arr[i] = arr[arr.Length - 1 - i];
    arr[arr.Length - 1 - i] = position;
}
Console.WriteLine($"Массив после: [ {string.Join("; ", arr)} ]");