// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int Kub(int num)
{
    int res = 1;
    int res2 = 1;
    while (res2 <= num)
    {
        res = res2 * res2 * res2;
        System.Console.Write($"{res} ;");
        res2 = res2 + 1;
    }
    return num;
}

int n = Prompt("Введите число:  ");
int result = Kub(n);
