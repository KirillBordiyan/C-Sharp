// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int task10() {
    System.Console.Write("введите трехзначное число: ");
    int a = int.Parse(System.Console.ReadLine());
    int num1 = a % 100;
    int num2 = num1 / 10;
    System.Console.WriteLine($"{num2}");
    return num2;
}

task10();


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

void task13(){
    System.Console.Write("введите число: ");
    int b = 0;
    while (! int.TryParse(System.Console.ReadLine(), out b)){
    System.Console.WriteLine("это не число");
    }

    int ost = 0;
    if (b >= 100){
        do{
            ost = b % 10;
            b = b / 10;
        }
        while(b >= 100);
        System.Console.WriteLine(ost);
    }
    else{
        System.Console.WriteLine("число меньше трехзначного");
    }
}

// task13();


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

void task15(){
    System.Console.WriteLine("введите число от 1 до 7: ");
    int day = 0;
    while ((! int.TryParse(System.Console.ReadLine(), out day) || (day > 7 || day < 1))){
        System.Console.WriteLine("это число не подходит, введите другое: ");
    };
 
    switch(day){
        case int i when (i >= 1 && i <=5):
            System.Console.WriteLine("нет");
            break;
        case int i when (i == 6  || i == 7):
            System.Console.WriteLine("да");
            break;
    }
}

task15();

// f(x) = kx+g - формула прямой 
// коэф прямой
// k = 4 опущена на 
// g = -4 идет вверх
// x0 = 10 -начальная точка
// xN = 20 - конечная точка
// шаг = 0.0000001

double Integral(){
    double start = 10;
    double finish = 20;
    double step = 0.0000001;
    
    double sum = 0;
    int k = 4;
    int g = -4;

    while(start <= finish){
        double h = k * start + g;
        sum += (step * h);
        start += step;
    }

    System.Console.WriteLine(sum);
    return sum;
}

Integral();
