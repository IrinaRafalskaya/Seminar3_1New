﻿//  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int rows = new Random().Next(2, 8);
int columns = new Random().Next(2, 8);
int[,] numbers = new int[rows, columns];

FillArrayRandomNumbers(numbers);

PrintArray(numbers);

int minsum = Int32.MaxValue;
int indexLine = 0;

for (int i = 0; i < numbers.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < numbers.GetLength(1); j++)
        {
        sum = sum + numbers[i, j];
        }
    if (sum < minsum)
        {
        minsum = sum;
        indexLine++;
        }
}

Console.WriteLine($"Строка с наименьшей суммой элементов: " + (indexLine) + ", равной: " + (minsum) );

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(2, 8);
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