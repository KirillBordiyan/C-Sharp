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

