// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. m = 3, n = 4.

double[,] array = new double[3, 4];

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}