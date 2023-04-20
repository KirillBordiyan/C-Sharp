/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
/*_____________________________________________________________
int ReadInt(string arg)
{
    System.Console.WriteLine($"число {arg}");
    int i;
    while(!int.TryParse(System.Console.ReadLine(), out i))
    {
        System.Console.WriteLine("again");
    }
    return i;
}

int a = ReadInt("A: ");
int b = ReadInt("B: ");

int PowAB(int a, int b)
{
    int diff_a = a;
    for (int i = 1; i < b; i++) // i = 3, a*a*a 1
    {
        diff_a *= a;
    }
    
    return diff_a;
}

System.Console.WriteLine(PowAB(a,b));

___________________________________________________*/



/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/


int ReadNumber(string arg)
{
    System.Console.WriteLine($"число {arg}");
    int i;
    while(!int.TryParse(System.Console.ReadLine(), out i))
    {
        System.Console.WriteLine("again");
    }
    return i;
}

int number = ReadNumber("input");

int SumOfNumber(int a)
{
    string number_string = a.ToString();
    int sum = 0;

    for (int i = 0; i < number_string.Length; i++)
    {
        sum += int.Parse(number_string[i].ToString());
    }
   return sum;
}

System.Console.WriteLine(SumOfNumber(number));
