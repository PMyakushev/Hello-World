// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3




// Задача 42: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)




// Задача 43 (ДОП, по желанию, на 5 нужно сделать 2 задачки): Напишите программу, которая будет преобразовывать
//  десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10




// int[] GetArray = {345, 172, 86, 43 , 21 , 10, 5, 2, 1,};
// int size = GetArray.Length;


// int[] ArraySystem(int[] array)
// {
//     int[] result = new int[size]; // Копия - такой же размер
//     for (int i = 0; i < size; i++) // проходимся по массиву
//     {
//       result[i] =   ; //делим 1 и последне значение на остаток

//     }
//     return result;
// }

int[] ArrayTwoNumbers(int[] array)
{
    int[] result = new int[size]; // Копия - такой же размер
    for (int i = 0; i < size; i++) // проходимся по массиву
    {
      result[i] = array[i]%2  ; //делим 1 и последне значение на остаток

    }
    return result;
}

int[] CopyReverseArray(int[] array)
{
    int[] result = new int[size]; // Копия - такой же размер
    int last = size - 1;
    for (int i = 0; i < size; i++) // i++ - слево - направо
    {
      result[i] = array[last - i]; // Последний элемент - текущий
    }
    return result;
}

Console.WriteLine($"Array: {String.Join(", ", GetArray)}");
Console.WriteLine();
Console.WriteLine($"DIV: {String.Join(", ", ArrayTwoNumbers(GetArray))}");
Console.WriteLine($"Around: {String.Join(", ", CopyReverseArray(ArrayTwoNumbers(GetArray)))}");







// Console.WriteLine(temp);
// int[] GetArray(int size)
// {
//     int[] array = new int[size];
//     for(int i=0;i>size;i++)
//     {
//         array[i] = size/2;
//     }
//     return array;
// }
// int[] RUT = GetArray(size);
// Console.WriteLine(string.Join(" ", RUT)); // вывели массив  RUT