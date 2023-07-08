// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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
        if (array[i] % 2 == 0)
        {
            evens++;
        }
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"Количество четных цифр в массиве = {evens}\t");
}

int[] array = GenerateArray(new Random().Next(4, 10), 100, 999);

ShowArray(array);

