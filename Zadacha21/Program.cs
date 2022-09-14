//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите Х1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Х2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(GetDistance(x1, y1, z1, x2, y2, z2));

double GetDistance (int x1, int y1, int z1, int x2, int y2, int z2)
{
    double distance = 0;
    distance = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));
    return distance;
}