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



/*Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 6, 7, 8"*/

/*----------------------------------------------------
int IFNatural(string arg) //использование чисел при подсчете, а не определения количества, т.е не учитывается 0
{
    int a = ReadInputNumber($"input {arg}: ");
    while (a <= 0)
    {
        System.Console.WriteLine("A is negative or 0 is out");
        a = ReadInputNumber("input A again: ");
    }

    return a;
}

// int m = IFNatural("task 64 M: ");
// int n = IFNatural("task 64 N: ");

void NaturalBeetween(int m, int n)
{
    if (m<=n)
    {
        System.Console.Write($"{m} ");
        m++;
        NaturalBeetween(m,n);
    }
}

// NaturalBeetween(m,n);
----------------------------------------------------*/





/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

/*------------------------------------------------------------------------------------------------------------------------------------------------------------
int task66_m = ReductionNumber("task 66 M:");
int task66_n = ReductionNumber("task 66 N:");
System.Console.WriteLine(NaturalSum(task66_m, task66_n));

int ReductionNumber(string arg)
{
    int a = ReadInputNumber($"{arg} ");
    if(a <= 0)
    {
        a = 1;
    }

    return a;
}

int NaturalSum(int m, int n, int sum = 0)
{
    if(m <= n)
    {
        sum = m + NaturalSum(m+1, n, sum);
    }
    return sum;    
}

------------------------------------------------------------------------------------------------------------------------------------------------------------*/

/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29*/
