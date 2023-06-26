// Задача 3: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет



int ReadInt(string message)
{
    System.Console.WriteLine(message);
    string inputedStr = Console.ReadLine();
    int number = Convert.ToInt32(inputedStr);
    return number;
}

int number = ReadInt("Введите цифру день недели");

if (number < 1 || number > 7)
{
    System.Console.WriteLine("Некорректный ввод");
}
else if (number >= 6)
{
    System.Console.WriteLine("да");
}
else
{
    System.Console.WriteLine("нет");
}

