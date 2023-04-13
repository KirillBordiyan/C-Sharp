// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.Write("введите трехзначное число: ");
int a = int.Parse(System.Console.ReadLine());
int num1 = a % 100;
int num2 = num1 / 10;
System.Console.WriteLine($"{num2}");
