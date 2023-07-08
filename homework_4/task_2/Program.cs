// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadInt(string message)
{
    System.Console.WriteLine(message);
    string inputedStr = Console.ReadLine();
    int number = Convert.ToInt32(inputedStr);
    return number;
}

int work(int number)
{

    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number = number / 10;
    }

    return result;
}

int number = ReadInt("Введите число");
System.Console.WriteLine($"Сумма всех чисел в цифре {number} = {work(number)}");

