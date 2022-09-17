// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int size = 7;
int[] array = new int[7];
Random myRandom = new Random();

Console.WriteLine("Вывод массива");
for (int i = 0; i < array.Length; i++)
{
    array[i] = myRandom.Next(0, 7);
    Console.WriteLine("{0} ", array[i]);
}
