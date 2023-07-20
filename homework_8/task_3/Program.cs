// Задача 3: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// 2 4 | 3 4 2
// 3 2 | 3 3 1
// Результирующая матрица будет:
// 18 20 8
// 15 18 7


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

//не придумал посмотрю решение
int[,] multiplier(int[,] arrayTriple, int[,] arrayTwice)
{
    int[,] newArray = new int[2, 3];
    newArray[0, 0] = arrayTriple[0, 0] * arrayTwice[0, 0];
    newArray[1, 0] = arrayTriple[0, 1] * arrayTwice[1, 0];
    newArray[2, 0] = arrayTriple[0, 1] * arrayTwice[1, 0];
    newArray[0, 1] = arrayTriple[0, 1] * arrayTwice[1, 0];
    newArray[1, 1] = arrayTriple[0, 1] * arrayTwice[1, 0];
    newArray[2, 2] = arrayTriple[0, 1] * arrayTwice[1, 0];
    return newArray;
}

int[,] arrayTwice = GenerateArray(2, 2);
int[,] arrayTriple = GenerateArray(2, 3);


for (int i = 0; i < arrayTriple)
    printD2Array(arrayTwice);
printD2Array(arrayTriple);
