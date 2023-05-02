/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

int ReadInt(string a){ //вводим размер массива
    Console.Write($"input {a}: ");

    int i;
    while (! int.TryParse(System.Console.ReadLine(), out i)){
        System.Console.WriteLine("not number");
    };

    return i;
}

void BiggerThanOu()
{
    int count = 0;
    Stack<int> arrayOfNumbers = new Stack<int>();
    while (System.Console.ReadLine() == "next")
    {
        arrayOfNumbers.Push(ReadInt("num: "));
    }

    while(arrayOfNumbers.TryPop(out int i))
    {
        if(i >= 1) count += 1;
    }
    System.Console.WriteLine(count);
}
BiggerThanOu();


/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/


int k1 = ReadInt("k1: ");
int k2 = ReadInt("k2: ");
int b1 = ReadInt("b1: ");
int b2 = ReadInt("b2: ");


void PointOfIntersection(int k1, int b1, int k2, int b2)
{
    double x = 0;
    double AB = k1 * x + b1;
    double CD = k2 * x + b2;

    x = (b2 - b1) / (k1 - k2);

    System.Console.WriteLine($"({x}, {x})");
}

PointOfIntersection(k1, b1, k2, b2);

