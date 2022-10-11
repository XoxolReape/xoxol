Dota2:
Console.WriteLine("Выберите действие: 1 - Сложение, 2 - Вычитание, 3 - Умножение, 4 - Деление, 5 - Возвести в степень\n" +
    "6 - Найти квадратный корень, 7 - Найти 1 процент от числа, 8 - Найти факториал от числа, 9 - Выйти из программы");
int s, d, f;
string a, b, c;
a = Console.ReadLine();
f = Convert.ToInt32(a);
while (f < 9)
{
    if (f < 6)
    {
        Console.WriteLine("Введите первое число: ");
        b = Console.ReadLine();
        s = Convert.ToInt32(b);

        Console.WriteLine("Введите первое число: ");
        c = Console.ReadLine();
        d = Convert.ToInt32(c);

        if (f == 1)
        {
            Console.WriteLine("Равно: " + (s + d));
            goto Dota2;
        }
        else if (f == 2)
        {
            Console.WriteLine("Равно: " + (s - d));
            goto Dota2;
        }
        else if (f == 3)
        {
            Console.WriteLine("Равно: " + (s * d));
            goto Dota2;
        }
        else if (f == 4)
        {
            Console.WriteLine("Равно: " + (s / d));
            goto Dota2;
        }
        else if (f == 5)
        {
            Console.WriteLine("Равно: " + Math.Pow(s, d));
        }
    }
    if (f == 6)
    {
        Console.WriteLine("Введите число: ");
        b = Console.ReadLine();
        s = Convert.ToInt32(b);
        Console.WriteLine("Равно: " + Math.Sqrt(s));
        goto Dota2;
    }
    else if (f == 7)
    {
        Console.WriteLine(" Введите число: ");
        b = Console.ReadLine();
        double g = Convert.ToDouble(b);
        Console.WriteLine("Равно: " + (g / 100));
        goto Dota2;
    }
    else if (f == 8)
    {
        Console.WriteLine("Введите число: ");
        b = Console.ReadLine();
        int h = Convert.ToInt32(b);
        int q = 1;
        for (int i = 1; i <= h; i++)
        {
            q = q * i;
        }
        Console.WriteLine("Равно: " + q);
        goto Dota2;
    }
}