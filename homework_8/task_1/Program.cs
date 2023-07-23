// Задача 1: Задайте двумерный массив. 
// Напишите программу, которая упорядочивает по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int ReadInt(string message)
{
    System.Console.WriteLine(message);
    string inputedStr = Console.ReadLine();
    int number = Convert.ToInt32(inputedStr);
    return number;
}

int[,] GenerateArray(int rows, int cols)
{
    int minRange = 0;
    int maxRange = 10;
    int[,] array = new int[rows, cols];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(minRange, maxRange);
        }
    }

    return array;
}

int[,] sortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int currentValue = 0;
        int nextValue = 0;
        for (int j = 1; j < array.GetLength(1); j++)
        {


            if (array[i, j] > array[i, j - 1])
            {
                currentValue = array[i, j - 1];
                nextValue = array[i, j];
                array[i, j - 1] = nextValue;
                array[i, j] = currentValue;
                j = 0;
            }

        }

    }

    return array;
}


void printD2Array(int[,] array)
{
    System.Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int[,] array = GenerateArray(ReadInt("Введите количество строк >"), ReadInt("Введите количество колонок >"));
printD2Array(array);
array = sortArray(array);
printD2Array(array);