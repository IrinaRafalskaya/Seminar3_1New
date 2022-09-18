// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] number = new int[size];
ArrayRandomNumbers(number);
Console.WriteLine("Массив: ");
PrintArray(number);
int sum = 0;

    for (int a = 1; a < number.Length; a += 2)
        sum += number[a];

Console.WriteLine($"Cумма элементов на нечётных позициях = {sum}");

void ArrayRandomNumbers(int[] number)
{
    for (int i = 0; i < number.Length; i++)
    {
        number[i] = new Random().Next(1, 10);
    }
}
void PrintArray(int[] number)
{
    for (int i = 0; i < number.Length; i++)
    {
        Console.Write(number[i] + " ");
    }
    Console.WriteLine();
}
