// Задача 3
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Hello, World!");
int ReadInt(string message)
{
    System.Console.WriteLine(message);
    string inputedStr = Console.ReadLine();
    int number = Convert.ToInt32(inputedStr);
    return number;
}
int number = ReadInt("Введите число");

for (int i = 1; i <= number; i++)
{
    if (i == number)
    {
        System.Console.Write(i * i * i);
    }
    else
    {
        System.Console.Write(i * i * i + ", ");
    }

}