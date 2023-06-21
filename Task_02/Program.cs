/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

int ReadInt(string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine()); 
    return number;
}

int xA = ReadInt("Введите координату хA");
int yA = ReadInt("Введите координату yA");
int zA = ReadInt("Введите координату zA");

int xB = ReadInt("Введите координату хB");
int yB = ReadInt("Введите координату yB");
int zB = ReadInt("Введите координату zB");

double distanceX = xA-xB;
double distanceY = yA-yB;
double distanceZ = zA-zB;

double distance = Math.Sqrt(distanceX * distanceX + distanceY * distanceY + distanceZ * distanceZ);
Console.WriteLine($"Расстояние между точками {distance:f2}");