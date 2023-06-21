/* Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

int ReadInt(string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine()); 
    return number;
}

int Cube(int x)
{
    x = x*x*x;
    return x; 
}

int N = ReadInt("Введите число N");
for (int i = 0; i < N; i++)
{
   Console.Write(Cube(i + 1));
   Console.Write(" ");
}
