// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
/*
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
*/

/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int ReadCordinat(string arg){ 
    System.Console.WriteLine($"координата {arg}: ");

    int i;
    while (! int.TryParse(System.Console.ReadLine(), out i)){
        System.Console.WriteLine("not num");
    }
    return i;
}

var A = (x: ReadCordinat("X1"), y: ReadCordinat("Y1"), z: ReadCordinat("Z1"));
var B = (x: ReadCordinat("X2"), y: ReadCordinat("Y2"), z: ReadCordinat("Z2"));

double DistanceOf((int x, int y, int z) A, (int x, int y, int z) B){
    double distans = Math.Sqrt(Math.Pow((A.x-B.x),2) + Math.Pow((A.y-B.y),2) + Math.Pow((A.z-B.z),2));
    System.Console.WriteLine(distans);
    return distans;
}

DistanceOf(A, B);

