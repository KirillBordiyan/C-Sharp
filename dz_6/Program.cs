/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

int ReadInt(string a)
{
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
    System.Console.WriteLine("next or any");
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



/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/


void PointOfIntersection()
{
    int k1 = ReadInt("k1: ");
    int k2 = ReadInt("k2: ");
    int b1 = ReadInt("b1: ");
    int b2 = ReadInt("b2: ");
    double x = (double) (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;

    System.Console.WriteLine($"({x}, {y})");
}



void Menu()
{
    System.Console.WriteLine("number tasks - 41 or 43");
    string task = System.Console.ReadLine();

    switch(task)
    {
        case "41": BiggerThanOu();
        break;

        case "43": PointOfIntersection();
        break;
    }
        
}

Menu();
