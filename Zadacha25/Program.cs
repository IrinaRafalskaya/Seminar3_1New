// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите число A --> ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B --> ");
int b = Convert.ToInt32(Console.ReadLine());
int pow = a;

for (int i = 1; i < b; i++)
{
    pow = pow * a;
}
Console.WriteLine("Число A в натуральной степени B равно: " + pow);
