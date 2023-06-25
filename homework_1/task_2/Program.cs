// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите 3 числа через пробел");
string[] strArray = (Console.ReadLine()).Split(' ');

int max = 0;
foreach (var item in strArray)
{
    if (max < Convert.ToInt32(item))
    {
        max = Convert.ToInt32(item);
    }
}
Console.WriteLine(max);