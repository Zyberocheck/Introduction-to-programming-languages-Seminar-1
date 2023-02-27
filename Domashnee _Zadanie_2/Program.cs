// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.WriteLine("Введите три числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int d = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("max = " + a);
}
if (b > max)
{
    Console.WriteLine("max = " + b);
}
if (d > max)
{
    Console.WriteLine("max = " + d);
}













// {
//     Console.Write(a);
//     Console.WriteLine(" больше чем " + b);
// } else
// {
//     Console.Write(b);
//     Console.WriteLine(" больше чем " + a);


// }if (b > d)
// {
//     Console.Write(b);
//     Console.WriteLine(" больше чем " + d);
// } else
// {
//     Console.Write(d);
//     Console.WriteLine(" больше чем " + b);
// }