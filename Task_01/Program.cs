/* Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.
23432 -> да
14212 -> нет
12821 -> да*/

int ReadInt(string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine()); 
    return number;
}

bool Validate(int numb)
{
    if (numb > 99999 || numb < 10000) 
        {   
            Console.WriteLine("Число не пятизначное");
            return false;
        }
    return true;
}

bool Polydrome(int number)
{
    if (number %10 == number /10000) 
    {
        if (number %100 /10 == number %10000 /1000)
        {
            return true;
        }
    }
    return false;
}

int digit = ReadInt("Введите число");
if (Validate(digit))
{
   if (Polydrome(digit))
    {
        Console.WriteLine($" Число {digit} - палиндром");
    }
    else
    {
        Console.WriteLine($" Число {digit} - не является палиндромом");
    } 
}