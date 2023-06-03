//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());

int originalNumber = number;
int reversedNumber = 0;

    while (number > 0)
    {
        int digit = number % 10;
        reversedNumber = reversedNumber * 10 + digit;
        number /= 10;
    }

    if (originalNumber == reversedNumber)
    {
        Console.WriteLine("Да, число является палиндромом.");
    }
    else
    {
        Console.WriteLine("Нет, число не является палиндромом.");
    }
    