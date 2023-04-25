﻿/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
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






/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
[3,21 7,04 22,93 -2,71 78,24] -> 80,95*/
