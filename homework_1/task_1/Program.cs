// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число а");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число б");
int b = Convert.ToInt32(Console.ReadLine());

if (a < b)
{
    Console.WriteLine("max = " + b);
}
else if (b < a)
{
    Console.WriteLine("max = " + a);
}
else
{
    Console.WriteLine("max = " + a);
}