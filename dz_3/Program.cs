// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int number = ReadNumber();

int ReadNumber()
{
    System.Console.WriteLine("введите 5 значное число: ");
    int num;
    while (!int.TryParse(System.Console.ReadLine(), out num))
    {
        System.Console.Write("еще раз: ");
    }
    return num;
}


bool QantOfNum(int num)
{
    if(num > 10000 && num <=99999)
    {
        return true;
    }
    return false;
}


bool Palindrom(int number)
{
    string num = number.ToString();
    return num[0] == num[4] && num[1] == num[3];
}


if (QantOfNum(number)){
    System.Console.WriteLine(Palindrom(number));
}else{
    System.Console.WriteLine("not");
}
