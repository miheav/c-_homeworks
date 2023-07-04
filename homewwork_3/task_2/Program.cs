// Задача 2
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53


int[] ReadInt(string message)
{
    System.Console.WriteLine(message);
    string inputedStr = Console.ReadLine();
    string[] coordsStr = inputedStr.Split(' ');
    int[] coords = new int[3];
    coords[0] = Convert.ToInt32(coordsStr[0]);
    coords[1] = Convert.ToInt32(coordsStr[1]);
    coords[2] = Convert.ToInt32(coordsStr[2]);

    return coords;
}

int[] coord1 = ReadInt("Введите координаты первой точки через пробел");
int[] coord2 = ReadInt("Введите координаты второй точки через пробел");
int rangex = coord1[0] - coord2[0];
int rangey = coord1[1] - coord2[1];
int rangez = coord1[2] - coord2[2];
double range = Math.Sqrt(rangex * rangex + rangey * rangey + rangez * rangez);
Console.WriteLine(range);
