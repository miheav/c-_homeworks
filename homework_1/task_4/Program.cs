// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

string str = "";
for (int i = 0; i <= a; i++)
{

    if (i % 2 == 0)
    {
        str += Convert.ToString(i) + ' ';
    }

}

Console.WriteLine(str);
