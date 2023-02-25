// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное
// на само себя).

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

int number = Convert.ToInt32(Console.ReadLine());
int result = number * number;
string hello = "hello";
Console.WriteLine("Your result is: " + result);
Console.WriteLine("Your {1} result is: {0} ", result, hello);
Console.WriteLine($"Your result is: {number * number}");

