// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

void IfMultiple(int a)
{
    if (a % 7 == 0)
    {
        if (a % 23 == 0) 
        Console.WriteLine("Да");
    }
    else Console.WriteLine("Нет");
}

Console.Write("Введите число: ");
IfMultiple(int.Parse(Console.ReadLine()));
