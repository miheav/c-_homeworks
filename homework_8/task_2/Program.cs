// Задача 2: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка


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

void minSumArray(int[,] array)
{
    int minSumArray = 1000;
    int strokeArray = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumArray = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumArray += array[i, j];

        }

        System.Console.WriteLine(sumArray);
        if (sumArray < minSumArray)
        {
            minSumArray = sumArray;
            strokeArray = i;
        }
    }
    System.Console.WriteLine($"Наименьшая строка {strokeArray + 1}");
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

int[,] array = GenerateArray(4, 4);
printD2Array(array);
minSumArray(array);
