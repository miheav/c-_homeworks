// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Сделать через функции
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

string[] ReadString(string message)
{
    System.Console.WriteLine(message);
    string inputedStr = Console.ReadLine();
    string[] inputedStrArr = inputedStr.Split(' ');
    return inputedStrArr;
}

void print(string[] myString)
{
    Console.Write("[");

    foreach (var item in myString)
    {
        if (item != "" || item != " ")
        {
            Console.Write($"{item.ToString()},");
        }
    }

    Console.Write("]");
}
string[] myString = ReadString("Введите через пробел 8 цифр");
print(myString);