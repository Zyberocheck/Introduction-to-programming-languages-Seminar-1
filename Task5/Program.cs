// Задача №7. Напишите программу, 
// которая принимает на вход 
// трёхзначное число и на выходе 
// показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8


Console.WriteLine("Введите трехначное число: ");
int trip = Convert.ToInt32(Console.ReadLine());
int div = 0;

if (trip >= 100 && trip< 1000)
{
    div = trip % 10;
    Console.WriteLine(div);
} else
{
    Console.WriteLine("Введите трехзначное число!");
}