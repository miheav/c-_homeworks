// Задача 1: Напишите цикл, который принимает на 
// вход два числа (A и B) и возводит число A в натуральную степень B. Сделать через функции
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int ReadInt(string message)
{
    System.Console.WriteLine(message);
    string inputedStr = Console.ReadLine();
    int number = Convert.ToInt32(inputedStr);
    return number;
}

void work()
{
    int a = ReadInt("Введите число A");
    int b = ReadInt("Введите число B");
    long c = (long)Math.Pow(a, b);
    System.Console.WriteLine(c);
}

work();