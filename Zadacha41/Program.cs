// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.Write($"Введите количестыо чисел: ");
int arr = Convert.ToInt32(Console.ReadLine());
int[] arrayNumber = new int[arr];

void InNumber(int arr)
{
    for (int i = 0; i < arr; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        arrayNumber[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int Comparison(int[] arrayNumber)
{
    int count = 0;
    for (int i = 0; i < arrayNumber.Length; i++)
    {
        if (arrayNumber[i] > 0) count += 1;
    }
    return count;
}

InNumber(arr);

Console.WriteLine($"Введено положительных чисел: {Comparison(arrayNumber)} ");