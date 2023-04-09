// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int task2(){

    System.Console.WriteLine("Введите первое число: ");
    int a = int.Parse(Console.ReadLine());
    System.Console.WriteLine("Введите второе число: ");
    int b = int.Parse(Console.ReadLine());

    int maxNum = 0;
    if (a > b) {
        System.Console.WriteLine($"{a} максимальное");
        maxNum = a;
    }
    else{
        System.Console.WriteLine($"{b} максимальное");
        maxNum = b;
    }
    return maxNum;
}

// task2();

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int task4(){
    
    System.Console.WriteLine("Введите первое число: ");
    int a = int.Parse(Console.ReadLine());

    System.Console.WriteLine("Введите второе число: ");
    int b = int.Parse(Console.ReadLine());

    System.Console.WriteLine("Введите третье число: ");
    int c = int.Parse(Console.ReadLine());
    int max = a;

    if (b > max) max = b;
    if (c > max) max = c;
    
    System.Console.WriteLine($"{max} максимальное");
    return max;
}

// task4();

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

int task6(){

    System.Console.WriteLine("Введите число для проверки четности: ");
    int a = int.Parse(Console.ReadLine());

    if (a % 2 == 0) {
        System.Console.WriteLine($"{a} четное");
    }
    else {
        System.Console.WriteLine($"{a} нечетное");
    }

    return a;
}

task6();

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
