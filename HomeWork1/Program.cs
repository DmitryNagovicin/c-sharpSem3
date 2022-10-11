// Напишите программу, которая принимает на вход пятизначное число и проверяет,
//  является ли оно палиндромом. Не применять строки!
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}


// int num = Prompt("Ведите число:  ");                           //проверка любого числа является ли оно 
// int n = num;                                                   // палиндромом
// int div = 0;
// int reverse = 0;
// while (n > 0)
// {
//     div = n % 10;
//     reverse = reverse * 10 + div;
//     n = n / 10;
// }

// if (num == reverse)
// {
//     System.Console.Write($"Число {num} является палиндромом.");
// }
// else System.Console.Write($"Число {num} НЕ является палиндромом.");

int num = Prompt("Ведите число:  ");
int n = num;
int div = 0;
int reverse = 0;

if (num < 100000 && num > 9999)
{
    while (n > 0)
    {
        div = n % 10;
        reverse = reverse * 10 + div;
        n = n / 10;
    }
    if (num == reverse)
    {
        System.Console.Write($"Число {num} является палиндромом.");
    }
    else System.Console.Write($"Число {num} НЕ является палиндромом.");
}
else System.Console.WriteLine("Вы ввели не пятизначное число");
