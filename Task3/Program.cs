// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница



Console.WriteLine("Введите номер дня недели: ");
int dayweek = Convert.ToInt32(Console.ReadLine());
switch (dayweek)
{
    case 1:
    Console.WriteLine("Mon");
    break;
    case 2:
    Console.WriteLine("Tues");
    break;
    case 3:
    Console.WriteLine("Wedn");
    break;
    case 4:
    Console.WriteLine("Thurs");
    break;
    case 5:
    Console.WriteLine("Fri");
    break;
    case 6:
    Console.WriteLine("Satur");
    break;
    case 7:
    Console.WriteLine("Sun");
    break;
    default:
    Console.WriteLine("Нет такого номера их всего от 1 до 7! Попробуй еще раз!");
    break;
}





// int Mon = 1;
// int Tues = 2;
// int Wedn = 3;
// int Thurs = 4;
// int Fri = 5;
// int Satur = 6;
// int Sun = 7;
// Console.WriteLine("Введите номер дня недели: ");
// int dayweek = Convert.ToInt32(Console.ReadLine());
// if (dayweek == 1)
// {
//     Console.WriteLine("Mon");
// }

// if (dayweek == 2)
// {
//     Console.WriteLine("Tues");
// }
// if (dayweek == 3)
// {
//     Console.WriteLine("Wedn");
// }
// if (dayweek == 4)
// {
//     Console.WriteLine("Thurs");
// }
// if (dayweek == 5)
// {
//     Console.WriteLine("Fri");
// }
// if (dayweek == 6)
// {
//     Console.WriteLine("Satur");
// }
// if (dayweek == 7)
// {
//     Console.WriteLine("Sun");
// }


