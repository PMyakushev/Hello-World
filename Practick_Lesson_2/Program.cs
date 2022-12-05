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
int number = new Random().Next(100, 300);
int First = number / 100;
int Second1 = number % 100;
int Second = Second1 / 10;
int Third =Second1 % 10;

Console.WriteLine(number);
Console.Write(First);
Console.Write(Third);
