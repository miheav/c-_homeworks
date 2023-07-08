// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GenerateArray(int len, int min, int max)
{
    int[] array = new int[len];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    int evens = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((i + 1) % 2 != 0)
        {
            evens = evens + array[i];
        }
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"Cумма элементов на нечетных позициях = {evens}\t");
}

int[] array = GenerateArray(new Random().Next(4, 10), -99, 99);

ShowArray(array);

