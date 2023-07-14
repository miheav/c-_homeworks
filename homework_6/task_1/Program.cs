// Задача 1: Пользователь вводит 
// с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int[] ReadInt(string message)
{
    System.Console.WriteLine(message);
    string inputedStr = Console.ReadLine();

    string[] numbers = inputedStr.Split(',');
    int[] arr2 = Array.ConvertAll(numbers, s => int.Parse(s));

    return arr2;
}


int[] intArray = ReadInt("Введите через запятую числа");
int count = 0;
for (int i = 0; i < intArray.Length; i++)
{
    if (intArray[i] > 0)
    {
        count++;
    }
}

System.Console.WriteLine($"Количество чисел больше 0 равно {count}");




