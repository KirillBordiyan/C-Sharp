/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

//вводим размер массива
int ReadInt_Task34(string a){ 
    Console.Write($"input {a}: ");

    int i;
    while (! int.TryParse(System.Console.ReadLine(), out i)){
        System.Console.WriteLine("not number");
    };

    return i;
}

//заолнить массив:
void FillArray_Task34(int[] array)
{
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100, 1000);
    }
}

//массив элементов :
int[] NewArrayEmpty_Task34()
{
    int size = ReadInt_Task34("size: ");
    int[] array = new int[size];
    FillArray_Task34(array);
    return array;
}

//вывод массива: 
void PrintArray_Task34(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
} 

//кол-во четных элементов:
int Count_Task34()
{
    int[] array = NewArrayEmpty_Task34();
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            count += 1;
        }
    }
    PrintArray_Task34(array);
    return count;
}

System.Console.WriteLine(Count_Task34());


/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

//вводим размер массива
int ReadInt_Task36(string a){ 
    Console.Write($"input {a}: ");

    int i;
    while (! int.TryParse(System.Console.ReadLine(), out i)){
        System.Console.WriteLine("not number");
    };

    return i;
}

//заолнить массив:
void FillArray_Task36(int[] array)
{
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-100, 100);
    }
}

//массив элементов :
int[] NewArrayEmpty_Task36()
{
    int size = ReadInt_Task36("size: ");
    int[] array = new int[size];
    FillArray_Task36(array);
    return array;
}

//вывод массива: 
void PrintArray_Task36(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
} 

//сумма эл с нечетными индексами:
int Summ()
{
    int sum = 0;
    int[] array = NewArrayEmpty_Task36();

    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 == 1)
        {
            sum += array[i];
        }
    }
    PrintArray_Task36(array);
    return sum;
}

System.Console.WriteLine(Summ());







/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
[3,21 7,04 22,93 -2,71 78,24] -> 80,95*/


//вводим размер массива
int ReadInt_Task38(string a){ 
    Console.Write($"input {a}: ");

    int i;
    while (! int.TryParse(System.Console.ReadLine(), out i)){
        System.Console.WriteLine("not number");
    };

    return i;
}

//заолнить массив:
void FillArray_Task38(double[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble(random.Next(-1000, 1000)/100.0);
    }
}

//массив элементов :
double[] NewArrayEmpty_Task38()
{
    int size = ReadInt_Task38("size: ");
    double[] array = new double[size];
    FillArray_Task38(array);
    return array;
}

//вывод массива: 
void PrintArray_Task38(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
} 

//разница max и min:
double Difference()
{
    double[] array = NewArrayEmpty_Task38();
    double max = array[0];
    double min = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
        if(array[i] < min)
        {
            min = array[i];
        }
    }
    PrintArray_Task38(array);
    double diff = max - min;
    return diff;
}

System.Console.WriteLine(Difference());
