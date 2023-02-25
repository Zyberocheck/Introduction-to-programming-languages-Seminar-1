// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет


int a = 25, b = 5;
int c = 2, d = 10;
int e = 9, f = -3;
int g = -3, h = 9;

if(b * b == a)
{
    Console.WriteLine(a);
}
else
{
    Console.WriteLine("Нет!");
}

if(d * d == c)
{
    Console.WriteLine(c);
}
else
{
    Console.WriteLine("Нет!");
}

if(f * f == e)
{
    Console.WriteLine(e);
}
else
{
    Console.WriteLine("Нет!");
}

if(h * h == g)
{
    Console.WriteLine(g);
}
else
{
    Console.WriteLine("Нет!");
}


