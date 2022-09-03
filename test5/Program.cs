// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

void IfSquare(int a, int b)
{
    if (b > a)
    {
        int temp = b;
        b = a;
        a = temp;
    }
    if (b * b == a) Console.WriteLine("Да");
    else Console.WriteLine("Нет");
}

Console.WriteLine("Введите два числа");
IfSquare(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
