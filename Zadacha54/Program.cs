// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива

int rows = new Random().Next(1, 10);
int columns = new Random().Next(1, 10);
int[,] number = new int[rows, columns];
FillArrayRandomNumbers(number);

PrintArray(number);

for (int i = 0; i < number.GetLength(0); i++)
{
    for (int j = 0; j < number.GetLength(1) - 1; j++)
    {
        for (int z = 0; z < number.GetLength(1) - 1; z++)
        {
            if (number[i, z] < number[i, z + 1])
            {
                int temp = 0;
                temp = number[i, z];
                number[i, z] = number[i, z + 1];
                number[i, z + 1] = temp;
            }
        }
    }
}
Console.WriteLine("");

PrintArray(number);

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
