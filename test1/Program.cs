void CompareDigits()
{
    int x = new Random().Next(10, 100);
    int x1 = x / 10;
    int x2 = x % 10;
    Console.WriteLine($"Сгенерированно случайное число {x}");
    if (x1 > x2) Console.WriteLine(x1);
    else if (x2 > x1) Console.WriteLine(x2);
    else Console.WriteLine("Это палиндром");
}
CompareDigits();
