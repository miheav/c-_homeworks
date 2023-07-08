// Задача 1
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Не использовать строки (только / и % используем)
//14212 -> нет
//12821 -> да
//23432 -> да


int ReadInt(string message)
{
    System.Console.WriteLine(message);
    string inputedStr = Console.ReadLine();
    int number = Convert.ToInt32(inputedStr);
    return number;
}

int number = ReadInt("Введите пятизначное число число");

int fives = number % 10;

int fourth = number / 10 % 10;

int third = number / 10 / 10 % 10;

int second = number / 10 / 10 / 10 % 10;

int first = number / 10 / 10 / 10 / 10 % 10;



if (fives == first && fourth == second)
{
    System.Console.WriteLine("Введенное число является полиндромом");
}
else
{
    System.Console.WriteLine("Введенное число не является полиндромом");
}

System.Console.WriteLine($"{first} {second} {third} {fourth} {fives}");