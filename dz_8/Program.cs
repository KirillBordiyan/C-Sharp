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
                
        } // надо сделать так, чтобы они не менялись местами, а именно перемещались

    }


    Print(array);
}

ArraySort(array);
