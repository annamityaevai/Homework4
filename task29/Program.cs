// Задача 29. Напишите программу, которая задаёт массив из 8 элементов и 
// выводит их на экран.

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 100);
        index++;
    }
}

void PrintArray(int[] arr)
{
    int count = arr.Length;
    int position = 0;
    while (position < count)
    {
        Console. WriteLine(arr[position]);
        position++;
    }
}

int [] array = new int [8];

FillArray(array);
PrintArray(array);