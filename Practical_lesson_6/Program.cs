// // [1/40/20/30] =>30 / 800
// int [] vag = {1,2,3,4,5};
// int size = vag.Length / 2 + vag.Length % 2;
// Console.WriteLine(size);
// int[] result = new int[size];

// int first = 0; // первый элемент из массива vag
// int last = vag.Length-1; // последний элемент из массива vag
// int i = 0; // индекс результирующего массива.

// while(last>first)
// {
//     result[i] = vag[first]*vag[last];
//     i++; // result[0], result [1] увеличиваем индекс массива
//     first++; //vag[0], vag[1] vag[2]
//     last--; //vag[4], vag[3] vag[2]
// }
// Console.WriteLine(string.Join(", ", result));



// Задача 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
//

// Console.WriteLine("Введите кол-во цифр в массиве: ");
// int size =Convert.ToInt32(Console.ReadLine());
// int[] GetArray(int size)
// {
//     int[] array = new int[size];
//     for(int i=0;i<size;i++)
//     {
//         array[i] = new Random().Next(0, 100);
//     }
//     return array;
// }
// int[] RUT = GetArray(size);
// Console.WriteLine(string.Join(" ", RUT)); // вывели массив  RUT

// int[] CopyReverseArray(int[] array)
// {
//     int[] result = new int[size]; // Копия - такой же размер
//     int last = size - 1;
//     for (int i = 0; i < size; i++) // i++ - слево - направо
//     {
//         result[i] = array[last - i]; // Последний элемент - текущий
//     }
//     return result;
// }

// Console.WriteLine($"Array: {String.Join(", ", RUT)}");
// Console.WriteLine();
// Console.WriteLine($"Around: {String.Join(", ", CopyReverseArray(RUT))}");


// // Метод 2: Пузырек
// void Bubble(int[] array)
// {
//     int temp = 0;
//     for (int i = 0; i < size / 2; i++)
//     {
//         temp = array[i];
//         array[i]=array[array.Length-1-i];
//         array[array.Length-1-i]=temp;
//     }
//    }
// Bubble(RUT); // запись через Void Функции Bubble для Массива RUT
// Console.WriteLine($"Bubble: {String.Join(", ", RUT)}"); // новый вывод


// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

// Console.WriteLine("Ввдите 3 числа");
// int a  =   Convert.ToInt32(Console.ReadLine());
// int b  =   Convert.ToInt32(Console.ReadLine());
// int c  =   Convert.ToInt32(Console.ReadLine());

// int sum1=a+b;
// int sum2=c+a;
// int sum3=c+b;

// if (sum1<sum2 && sum2<sum3 && sum1<sum3)
// {
//     Console.WriteLine("Треугольник Существует");
// }
// else
// Console.WriteLine("Треугольник не  Существует");

// bool IsTriangle(int a, int b, int c) // Принимает три стороны треугольника
// {
//     return ((a+b>c) && (a+c>b) && (b+c>a)); // True, False
// } 
// Console.WriteLine(IsTriangle(5,3,4));





// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8 

int firstElement = 0;
int secondElement = 1;
int number = 3; // кол-во чисел Фибоначи 0,1,1,2

Console.WriteLine($"1. {FirstElement}");
Console.WriteLine($"2. {secondElement}");

for (int i = 0; i <= number; i++)
{
    int nextElemnt= firstElement + secondElement; // next = 1
}

//  Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.