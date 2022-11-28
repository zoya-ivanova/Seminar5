// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];
FillArray(array);
PrintArray(array);
Console.WriteLine($"{"Количество четных чисел в массиве: "}{NumbersEven(array)}");

int NumbersEven(int[] array)
{
    int count = 0;
    foreach(var item in array)
    {
        if(item % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

void FillArray(int[] array)   //метод. заполнение массива
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] array) //вывод массива на экран
{
    foreach(var item in array)
    {
        Console.Write($"{item}, ");
    }
}