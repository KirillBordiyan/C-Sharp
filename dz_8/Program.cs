int ReadInt(string a){ 
    Console.Write($"input {a}: ");

    int i;
    while (! int.TryParse(System.Console.ReadLine(), out i)){
        System.Console.WriteLine("not number");
    };

    return i;
}

void Print(int[,] array)
{   
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j= 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(String.Format("{0,3}", array[i, j]));
        }
        System.Console.WriteLine();
    } 
}

/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/



int row = ReadInt("строки: ");
int coloumn = ReadInt("столбцы: ");
int[,] array = CreateAdnFillArray(row, coloumn);

int[,] CreateAdnFillArray(int row, int coloumn)
{
    int[,] array = new int[row, coloumn];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0,10);
        }
    }

    Print(array);
    System.Console.WriteLine();
    return array;
}

void ArraySort(int[,] array)
{
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1)-1; j++)
        {
            for (int k = j+1; k < array.GetLength(1); k++)
            {
               if(array[i,k] > array[i, j])
                {
                    int temp = array[i,j];
                    array[i,j] = array[i,k];
                    array[i, k] = temp;
                }   
            }       
        }
    }
    Print(array);
}

// ArraySort(array);



/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/


// int[] arrayTask56 = CreateArraySum(array);
// SummaryByRow(arrayTask56);

bool IsNotSquare(int[,] array) //проверяет, является ли матрица квадратной
{
    return array.GetLength(0) != array.GetLength(1);
}

int[] EmptyArrayOfSumm(int[,] array) // создает пустой массив размерностью == n-строк двумерного массива
{
    int[] summary = new int[array.GetLength(0)];
    foreach(int item in summary)
    {
        System.Console.Write($"{item} ");
    }
    System.Console.WriteLine();
    return summary;
}

int[] CreateArraySum(int[,] array) //заполняет пустой одномерный массив суммами по строкам из двумерного
{
    int[] newArray = EmptyArrayOfSumm(array);
    if(IsNotSquare(array))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum += array[i,j];
            }
            System.Console.WriteLine($"{i+1} -- {sum}");
            newArray[i] = sum; 
        }
    }
    return newArray;
}

void SummaryByRow(int[] array) //выводит, какая строка двумерного массива имеет наименьшую сумму элементов (индекс одномерного массива == номеру строки двумерного)
{
    int min = 0;
    for(int i = 1; i < array.Length; i++)
    {
        if (array[i] < array[min])
        {
            min = i;
        }
    }
    System.Console.WriteLine($"строка минимальной суммы -- {min+1}");
}



/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/
