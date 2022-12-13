// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49


// int a = 4, b = -3, c = -7;
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int resault = number * number;
// Console.WriteLine(resault);


// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

// Console.Write("Введите первое число: ");
// int FirstNubmer = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int SecondNumber = Convert.ToInt32(Console.ReadLine());  

// if (SecondNumber * SecondNumber == FirstNubmer)
// {    
//     Console.WriteLine("Первое число являеться квадратом второго");
//     System.Console.WriteLine();
// }
// else Console.WriteLine("Первое число не являеться квадратом второго");

// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 	3 -> Среда 
// 5 -> Пятница




// Console.Write("Введите число недели ");
// int DayWeek = Convert.ToInt32(Console.ReadLine());

// if (DayWeek == 1)
// {  
//     Console.WriteLine("Понедельник");
// }
// if (DayWeek == 2)
// {  
// Console.WriteLine("Вторник");
// }
// if (DayWeek == 3)
// {  
// Console.WriteLine("Среда");
// }
// if (DayWeek == 4)
// {  
// Console.WriteLine("Четверг");
// }
// if (DayWeek == 5)
// {  
// Console.WriteLine("Пятница");
// }
// if (DayWeek == 6)
// {  
//     Console.WriteLine("Суббота");
// }
// if (DayWeek == 7)
// {  
// Console.WriteLine("Воскресенье");
// }

// 5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

Console.Write("Введите число N: ");
int PositivN = Convert.ToInt32(Console.ReadLine()); // N
if (PositivN < 0) PositivN*= -1;
int NegativN = PositivN * (-1); // -5 = 5 * -1

while (NegativN <= PositivN) //пока условие истина
{
    Console.Write(NegativN + " ");
    NegativN++;
}