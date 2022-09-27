// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int rows = new Random().Next(1, 10);
int columns = new Random().Next(1, 10);
int[,] array = new int[rows, columns];

FillArrayRandomNumbers(array);

for (int j = 0; j < array.GetLength(1); j++)
{
    double arithmeticMean = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        arithmeticMean = (arithmeticMean + array[i, j]);
    }
    arithmeticMean = arithmeticMean / rows;
    Console.Write(arithmeticMean + "; ");
}
Console.WriteLine();
PrintArray(array);



void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
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