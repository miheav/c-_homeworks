// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

double[] GenerateArray(int len, int min, int max)
{
    double[] array = new double[len];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.NextDouble() * (max - min);
    }
    return array;
}

void ShowArray(double[] array)
{
    double max = 0;
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine($"{max} - {min} = ");
    System.Console.WriteLine
    ($"Разница между максимальным и минимальным элементов массива = {(max - min)}\t");
}

double[] array = GenerateArray(new Random().Next(4, 10), 0, 99);

ShowArray(array);

