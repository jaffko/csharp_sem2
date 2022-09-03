Console.Write("Введите 2 числа: ");
try
{
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    if (a % b == 0) Console.WriteLine("Кратно");
    else Console.WriteLine($"Не кратно, остаток {a % b}");
}
catch 
{
    
    Console.WriteLine("Нужно вводить числа!");
}
