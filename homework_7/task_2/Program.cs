// Задача 2. Напишите программу, 
// которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет
// 1,2 -> 4

int ReadInt(string message)
{
    System.Console.WriteLine(message);
    string inputedStr = Console.ReadLine();
    int number = Convert.ToInt32(inputedStr);
    return number;
}

int[,] GenerateArray()
{
    int[,] array = new int[3, 3];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }

    return array;
}


void ShowElement(int[,] array, int elemI, int elemJ)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }

    try
    {
        System.Console.WriteLine(array[elemI - 1, elemJ - 1]);
    }
    catch (Exception e)
    {
        System.Console.WriteLine("Такого элемента нет");
    }
}

int[,] array = GenerateArray();

ShowElement(array, ReadInt("Введите строку >"), ReadInt("Введите колонку колонок >"));


