int ReadInputNumber(string input)
{
    System.Console.Write($"{input}");
    int i;
    while(!int.TryParse(System.Console.ReadLine(), out i))
    {
        System.Console.WriteLine("not number! ");
    } 
    return i;
}

System.Console.WriteLine("m & n must be positive");
int m = ReadInputNumber("input M: ");
int n = ReadInputNumber("input N: ");


/*Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 6, 7, 8"*/


void NaturalBeetween() //использование чисел при подсчете, а не определения количества, т.е не учитывается 0
{
    while (m <= 0)
    {
        System.Console.WriteLine("M is negative or 0 is out");
        m = ReadInputNumber("input M again: ");
    }
    while (n <= 0)
    {
        System.Console.WriteLine("N is negative or 0 is out or n = 1");
        n = ReadInputNumber("input N again: ");
    }
    
    if (m > n)
    {
        System.Console.WriteLine("m>n");
        System.Console.WriteLine("start again");
    }
    else
    {
        while(m <= n)
        {
            System.Console.Write($"{m} ");
            m++;
        }
    }
}

NaturalBeetween();

