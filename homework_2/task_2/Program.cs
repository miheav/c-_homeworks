// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
int ReadInt(string message)
{
    System.Console.WriteLine(message);
    string inputedStr = Console.ReadLine();
    int number = Convert.ToInt32(inputedStr);
    return number;
}

int number = ReadInt("Введите трехзначное число число");
if (number < 100)
{
    System.Console.WriteLine("Третьей цифры нет");
}
else
{
    string strNumber = Convert.ToString(number);

    System.Console.WriteLine(strNumber[2]);
}

