int RandThree ()
{
    int x = new Random().Next(100, 1000000);
    Console.WriteLine($"Трехзначное число -> {x}");
    return (x);
}
int CropSecond(int digit)
{
    int x3 = digit / 100;
    int x1 = digit % 10;
    return x3 * 10 + x1;
}

Console.WriteLine(CropSecond(RandThree()));
