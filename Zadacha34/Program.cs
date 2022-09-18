// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] number = new int[size];
ArrayRandomNumbers(number);
PrintArray(number);
int count = 0;

for (int a = 0; a < number.Length; a++)
    if (number[a] % 2 == 0)
        count++;

Console.WriteLine($"Массив состоит из {number.Length} чисел, из них чётные - {count}");

void ArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < number.Length; i++)
    {
        number[i] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] number)
{
        for (int i = 0; i < number.Length; i++)
    {
        Console.Write(number[i] + " | ");
    }
       Console.WriteLine();
}
