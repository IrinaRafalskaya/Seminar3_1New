//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] number = new double[size];
FillArrayRandomNumbers(number);
PrintArray(number);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int a = 0; a < number.Length; a++)
{
    if (number[a] > max)
    {
        max = number[a];
    }
    if (number[a] < min)
    {
        min = number[a];
    }
}

Console.WriteLine($"Максимальный элемент = {max}, минимальный элемент = {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементом = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for (int i = 0; i < number.Length; i++)
    {
        number[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
    }
}
void PrintArray(double[] number)
{
    for (int i = 0; i < number.Length; i++)
    {
        Console.Write(number[i] + " ");
    }
    Console.WriteLine();
}