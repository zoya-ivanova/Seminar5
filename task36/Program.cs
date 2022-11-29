// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"{"Cумма элементов массива, стоящих на нечётных позициях: "}{SumOddIndex(array)}");

int SumOddIndex(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

void FillArray(int[] array)   //метод. заполнение массива
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
}

void PrintArray(int[] array) //вывод массива на экран
{
    foreach(var item in array)
    {
        Console.Write($"{item}, ");
    }
}