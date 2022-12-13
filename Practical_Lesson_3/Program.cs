// Задача 17 Напишите программу, которая принимает на вход координаты точки
// (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// Console.Write("Введите координату по оси оX:  ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату по оси оY:  ");
// int y = Convert.ToInt32(Console.ReadLine());

// // 1: ++
// if (x>0 && y>0)
// {
//     Console.WriteLine("I Четверь");
// }
// if (x<0 && y>0)
// {
//     Console.WriteLine("II Четверь");
// }
// if (x<0 && y<0)
// {
//     Console.WriteLine("III Четверь");
// }
// if (x>0 && y<0)
// {
//     Console.WriteLine("IV Четверь");
// }


// Задача 18 Напишите программу, которая по заданному номеру 
// четверти, показывает диапазон возможных координат точек в этой четверти (x и y).


// Console.Write("Введите четверь:  ");
// int  f = Convert.ToInt32(Console.ReadLine());

// if (x>0 && y>0)
// {
//     int x = new Random().Next(1, 1000);
//     int y = new Random().Next(1, 1000);
//     Console.WriteLine("I Четверь");
// }
// if (x<0 && y>0)
// {
//     int x = new Random().Next(-1, -1000);
//     int y = new Random().Next(1, 1000); 
//     Console.WriteLine("II Четверь");    
// }
// if (x<0 && y<0)
// {
//     int x = new Random().Next(-1, -1000);
//     int y = new Random().Next(-1, -1000); 
//     Console.WriteLine("III Четверь"); 
// }
// if (x>0 && y<0)
// {
//     int x = new Random().Next(1, 1000);
//     int y = new Random().Next(-1, -1000); 
//     Console.WriteLine("IV Четверь"); 
// }

// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// Console.Write("Введите координату перовой точки по оси x1:  ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату перовой точки по оси y1:  ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату второй точки по оси x2:  ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату второй точки по оси y2:  ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// // Math.Sqrt(Число) = Math.Sqrt(25) = 5
// // Math.Pow (2, 3) => 8 = 2*2*2
// double d = Math.Sqrt((Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2))); // Pow(x2-x1, 2)
// // Math.Round число и кол-во знаков
// // $ = S
// Console.WriteLine("Расстояние между точками " + Math.Round(d, 3)); // Конкатенация: "1" + "2" = "12"
// // A (3, 6); B (2, 1) -> 5,09
// // $ = Shift + 4 на англ. раскладке
// Console.WriteLine($"Расстояние между двумя точками: {d}"); // Интерполяция
// Console.WriteLine($"Расстояние между двумя точками: {x1},{y1}, {x2},{y2} = {Math.Round(d,3)}");



// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
// Цикл while

// Console.Write("Введите число n ");
// int n = Convert.ToInt32(Console.ReadLine()); // Идем от 1 до N: [1;n]

// int start = 1; // Start -> Finish

// while (start <= n)
// {
//     Console.Write(Math.Pow(start, 2) + " ");
//     start++; //start= start+1 or start+=1
// }


// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
// Цикл for

Console.Write("Введите число n ");
int n = Convert.ToInt32(Console.ReadLine());
// Точка начало, Условия выхода из цикла, Увеличение счетчика
for (int start = 1; start <= n; start++)
{
    Console.Write(Math.Pow(start, 2) + " ");
}