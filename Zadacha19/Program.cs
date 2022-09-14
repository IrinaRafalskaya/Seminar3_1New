//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

int num, rem, sum = 0, temp;
    Console.Write("Введите число: ");
    num = Convert.ToInt32(Console.ReadLine());
    temp = num;
        while (Convert.ToBoolean(num))
            {
            rem = num % 10;  
            num = num / 10; 
            sum = sum * 10 + rem; 
            }
            Console.WriteLine("Перевернутое число это: {0} ", sum);
        if (temp == sum) 
            {
            Console.WriteLine("Палиндром");
            }
        else
            {
            Console.WriteLine("Это не палиндром");
            }
        Console.ReadLine();