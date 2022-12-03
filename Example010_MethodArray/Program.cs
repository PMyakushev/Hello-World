int [] array = { 1, 3, 3, 4, 5, 6, 7, 3, 9, 1};

int n = array.Length; // возврат элементов массива
int find = 5;
int index = 0;

while (index < n)
{   
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;//прервать
    }
    //index = index + 1;
    index++;
}
