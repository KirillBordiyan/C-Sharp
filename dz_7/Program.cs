int ReadInt(string a){ //вводим размер массива
    Console.Write($"input {a}: ");

    int i;
    while (! int.TryParse(System.Console.ReadLine(), out i)){
        System.Console.WriteLine("not number");
    };

    return i;
}

int row = ReadInt("строки: ");
int coloumn = ReadInt("столбцы: ");

/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

double[,] CreateAndFillArray(int row, int coln)
{
    double[,] array = new double[row, coln];
    Random rnd = new Random();

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = (double) Convert.ToDouble(rnd.Next(-100, 100)/10.0);
        }
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j= 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(String.Format("{0,6}", array[i, j]));
        }
        System.Console.WriteLine();
    }

    return array;
}



// CreateAndFillArray(row, coloumn);

/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/
/* ВАЖНОЕ ЗАМЕЧЕНИЕ
---------------------
В ПРОГРАММЕ УЧТЕНО, ЧТО ПОЛЬЗОВАТЕЛЬ ЗНАЕТ, ЧТО ОТСЧЕТ ИНДЕКСОВ НАЧИНАЕТСЯ С 0, А НЕ С 1
СЛЕДОВАТЕЛЬНО, В МАССИВЕ РАЗМЕРОМ 5Х5 ЭЛЕМЕНТА [5, 5] НЕ БУДЕТ СУЩЕСТВОВАТЬ, ТК МАКСИМАЛЬНЫЙ ИНДЕКС 4
---------------------
*/


int[,] CreatePrintArray(int row, int cln)
{
    int[,] array = new int[row, cln];

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(-10, 10);
        }
    }

    Print(array);

    return array;
}

void Print(int[,] array)
{   
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j= 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(String.Format("{0,4}", array[i, j]));
        }
        System.Console.WriteLine();
    } 
}

void ExistElement(int[,] array, int rowIndex, int clnIndex)
{
    if(rowIndex >= array.GetLength(0) || clnIndex >= array.GetLength(1)) 
    {
        System.Console.WriteLine($"элемента с индексами {rowIndex}, {clnIndex} не существует");
    }
    else
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                if(i == rowIndex && j == clnIndex) 
                {
                    System.Console.WriteLine($"значение элемента с индексами {rowIndex}, {clnIndex} равно {array[i,j]}");
                }
            }
        }
    }
}


int[,] array = CreatePrintArray(row, coloumn);
int rowIndexToFind = ReadInt("искомая позиция по i: ");
int clnIndexToFind = ReadInt("искомая позиция по j: ");

ExistElement(array, rowIndexToFind, clnIndexToFind);
