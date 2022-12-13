// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// Console.Write("Введите число: ");
// string number = Convert.ToString(Console.ReadLine());

// void CheckingNumber(string number)
// {
//   if (number[0]==number[4] && number[1]==number[3])
//   {
//     Console.WriteLine("Ваше число палиндром. " + number);
//   }
//   else Console.WriteLine("Ваше число не палиндром. " + number);
// }
// if (number.Length == 5)
// {
//   CheckingNumber(number);
// }
// else 
// Console.WriteLine("Введи правильное число");


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// l^2 = (x2-x1)^2+(y2-y1)^2+(z2-z1)^2.

// Console.Write("Введите координату перовой точки по оси x1:  ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату перовой точки по оси y1:  ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату перовой точки по оси z1:  ");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату второй точки по оси x2:  ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату второй точки по оси y2:  ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату перовой точки по оси z2:  ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// // Math.Sqrt(Число) = Math.Sqrt(25) = 5
// // Math.Pow (2, 3) => 8 = 2*2*2
// double d = Math.Sqrt((Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2))+Math.Pow((z2-z1), 2)); // Pow(x2-x1, 2)
// Console.WriteLine("Расстояние между точками " + d);



// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cube)
{
  int counter = 0;
  int length = cube.Length;
  while (counter <  length)
  {
    cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
    counter++;
  }
}

void PrintArry(int[] coll)
{
  int count = coll.Length;
  int index = 0;
  while(index < count){
    Console.Write(coll[index]+ " ");
    index++;
  }
} 

int[] arry = new int[cube+1];
Cube(arry);
PrintArry(arry);