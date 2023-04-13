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

// task10();


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

task13();
