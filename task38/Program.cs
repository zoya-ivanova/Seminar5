// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] numbers = new double[size];
FillArray(numbers);
Console.WriteLine("Массив: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
        {
            max = numbers[i];
        }
    if (numbers[i] < min)
        {
            min = numbers[i];
        }
}

Console.WriteLine();
Console.WriteLine($"Всего {numbers.Length} элементов массива. Максимальное значение {max}, минимальное значение {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArray(double[] array)   //метод. заполнение массива
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
}

void PrintArray(double[] array) //вывод массива на экран
{
    foreach(var item in array)
    {
        Console.Write($"{item}, ");
    }
}