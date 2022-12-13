// int temp = -7;
// if (temp => 5 && temp <= -10 ) Console.WriteLine("Температура меньше -25: " + temp);
// else if (temp < -20 ) Console.WriteLine("Надеть шапку");
//  else if (temp < -40 ) Console.WriteLine("Лучше сиди дома");
//  else if (temp < -5 ) Console.WriteLine("Сиди дома");

// 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8


// int number = new Random().Next(10, 100); // Next (star, **finish+1**) //new Random().Next(10, 100)
// Console.WriteLine(number);
// int FirstNubmer = number / 10;
// int SecondNumber = number % 10;
// int max = FirstNubmer;
// if (max > SecondNumber)
// {
//     max = SecondNumber;
        
// }


// Console.WriteLine("Исходящее число: " +number );
// Console.WriteLine("Максимальное число: " + max);
// Console.WriteLine("Они равны: " );


// 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
// int number = new Random().Next(100, 300);
// int First = number / 100;
// int Second1 = number % 100;
// int Second = Second1 / 10;
// int Third =Second1 % 10;

// Console.WriteLine(number);
// Console.Write(First);
// Console.Write(Third);

// 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// int numberone = new Random().Next(10, 100);
// int numbertwo = new Random().Next(1, 10);
// int max = numberone%numbertwo;
// Console.WriteLine(numberone);
// Console.WriteLine(numbertwo);
// if (max == 0)
// Console.Write("Кратно");
// else
// Console.Write("Не кратно");


// 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number % 7 == 0 && number % 23 == 0)
// {
//    Console.WriteLine("Кратно");
// }
// else 
// {
//     Console.WriteLine("Некратно"); 
// }
   
// 16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

// Console.WriteLine("Введите числа");
// int numberone = Convert.ToInt32(Console.ReadLine());
// int numbertwo = Convert.ToInt32(Console.ReadLine());
// ;
// if ((numberone*numberone) == numbertwo)
// {
//     Console.WriteLine("да");
// }
// else
// {
//     Console.WriteLine("нет"); 
// }