// Задача 2: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadInt(string message)
{
    System.Console.WriteLine(message);
    string inputedStr = Console.ReadLine();
    int number = Convert.ToInt32(inputedStr);
    return number;
}

int sum(int m, int n)
{
    int sum = 0;

    for (int i = m; i <= n; i++)
    {
        sum += i;
    }

    return sum;
}

int m = ReadInt("Введите число M >");
int n = ReadInt("Введите число N >");
System.Console.WriteLine(sum(m, n));

