﻿int ReadInt(string a){ 
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



// int row = ReadInt("строки: ");
// int coloumn = ReadInt("столбцы: ");
// int[,] array = CreateAdnFillArray(row, coloumn);

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

// int row1 = ReadInt("m1 row: ");
// int cln1 = ReadInt("m1 cln: ");

// int row2 = ReadInt("m2 row: ");
// int cln2 = ReadInt("m2 cln: ");

// int[,] matrix1 = CreateAdnFillArray(row1, cln1);
// int[,] matrix2 = CreateAdnFillArray(row2, cln2);


bool WeCanMultiply(int[,] m1, int[,] m2) //можем ли умножить
{
    return m1.GetLength(0) == m2.GetLength(1);
}

int[,] Task58EmptyMatrix(int[,] m1, int[,] m2) //создаем пустой двумерный
{
    int newRow = m1.GetLength(0);
    int newCln = m2.GetLength(1);
    
    int[,] array = new int[newRow, newCln];
    return array;
}


int[,] MatrixProduct(int[,] m1, int[,] m2) //перемножаем
{
    int[,] array = Task58EmptyMatrix(m1, m2);
    for (int i = 0; i < m1.GetLength(0); i++)
    {
        for (int j = 0; j < m2.GetLength(1); j++)
        {
            array[i,j] = 0;
            for (int k = 0; k < m1.GetLength(1); k++)
            {
                array[i,j] += m1[i,k] * m2[k,j];
            } 
        }
    }
    return array;
}

/*
if(WeCanMultiply(matrix1,matrix2))
{
    System.Console.WriteLine();
    int[,] arr = MatrixProduct(matrix1, matrix2);
    Print(arr);
}*/








/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

// int x = ReadInt("x");
// int y = ReadInt("y");
// int z = ReadInt("z");
// int[,,] array = new int[2, 2, 2]; //z - слой, x- срока, y- столбец

int[,,] array = 
{
    {
        {6, 8},
        {1, 4}
    },
    {
        {15, 9},
        {5, 0}
    }
};


for(int z = 0; z < array.GetLength(0); z++)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(2); j++)
        {
            System.Console.Write(String.Format("{0,10}", $"{array[z, i, j]} ({z}{i}{j})"));
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}
