// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, является ли оно палиндромом. Через строку нельзя решать само собой.

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите целое число: ");
        int number = int.Parse(Console.ReadLine());

        bool isPalindrome = IsPalindrome(number);

        if (isPalindrome)
            Console.WriteLine("Число является палиндромом.");
        else
            Console.WriteLine("Число не является палиндромом.");
    }

    static bool IsPalindrome(int number)
    {
        int originalNumber = number;
        int reversedNumber = 0;

        while (number > 0)
        {
            int remainder = number % 10;
            reversedNumber = reversedNumber * 10 + remainder;
            number /= 10;
        }

        return originalNumber == reversedNumber;
    }
}