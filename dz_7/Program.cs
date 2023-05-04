int ReadInt(string a){ //вводим размер массива
    Console.Write($"input {a}: ");

    int i;
    while (! int.TryParse(System.Console.ReadLine(), out i)){
        System.Console.WriteLine("not number");
    };

    return i;
}

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

int row = ReadInt("строки: ");
int coloumn = ReadInt("столбцы: ");

CreateAndFillArray(row, coloumn);

