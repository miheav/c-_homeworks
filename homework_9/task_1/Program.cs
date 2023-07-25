// Задача 1: Задайте значение N. Напишите программу, которая выведет все ЧЕТНЫЕ натуральные числа в промежутке от 1 до N. Выполнить с помощью рекурсии.
// N = 5, M = 9 -> "6, 8"
// N = 2, M = 10 -> "2, 4, 6, 8, 10"



int ReadInt(string message)
{
    System.Console.WriteLine(message);
    string inputedStr = Console.ReadLine();
    int number = Convert.ToInt32(inputedStr);
    return number;
}

string iterator(int n, int m, int i, string data)
{
    if (i < n)
    {
        i = n;
    }

    if (i % 2 == 0)
    {
        data += i + ", ";
    }

    if (i >= m)
    {
        data = data.Substring(0, data.Length - 2);
        return data;
    }
    i++;

    return iterator(n, m, i, data);
}


int n = ReadInt("Введите число N >");
int m = ReadInt("Введите число M >");
string data = "";
int i = 0;
data = iterator(n, m, i, data);

System.Console.WriteLine(data);