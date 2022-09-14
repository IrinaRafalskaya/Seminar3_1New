// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Tableofcubes(number);

void Tableofcubes(int number)
{
    int count = 1;
    while(count <= number)
    {
        Console.WriteLine($"Число в кубе {count} = {count*count*count}");
        count++;
    }
}
