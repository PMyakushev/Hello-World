// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8 
// 918 -> 1


// int number = new Random().Next(100, 300);
// int First = number / 100;
// int Second1 = number % 100;
// int Second = Second1 / 10;
// int Third =Second1 % 10;

// Console.WriteLine(number);
// Console.Write(Second);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// int number = new Random().Next(100, 300);
// int First = number / 100;
// int Second1 = number % 100;
// int Second = Second1 / 10;
// int Third =Second1 % 10;

// Console.WriteLine(number);
// Console.Write(Second);



// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет


Console.WriteLine("Веди цифру дня недели");
string number = Console.ReadLine();
while (0>=7)
{
    if ( number = 1) Console.WriteLine("Понедельник");
    if ( number = 2) Console.WriteLine("Вторник");
    if ( number = 3) Console.WriteLine("Среда");
    if ( number = 4) Console.WriteLine("Четверг");
    if ( number = 5) Console.WriteLine("Пятница");
    if ( number = 6) Console.WriteLine("Суббота");
    if ( number = 7) Console.WriteLine("Воскресенье");
}
