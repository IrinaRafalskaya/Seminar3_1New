// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введите номер строки: ");
int cellA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int cellB = Convert.ToInt32(Console.ReadLine());
int rows = new Random().Next(1, 10);
int columns = new Random().Next(1, 10);
int[,] array = new int[rows, columns];
FillArrayRandomNumbers(array);

if (cellA > array.GetLength(0) || cellB > array.GetLength(1))
{
    Console.WriteLine("Такого элемента нет");
}
else
{
    Console.WriteLine($"Эначение элемента {cellA} строки и {cellB} столбца равно {array[cellA - 1, cellB - 1]} ");
}

PrintArray(array);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100) / 10;
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}