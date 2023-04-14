// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

// for (int i = 0; i < 20; i++)
// {
//     int number = new Random().Next(10000, 1000000);
//     int n1 = number / 10;
//     int n2 = number % 10;
//     int n3 = number % 100;
//     int n4 = number % 1000;
//     int n5 = number % 10000;
//     int result = (n3-n2)/10;
//     Console.WriteLine ($"{number}-> 1 цифра {n1} ");
//     Console.WriteLine ($"{number}-> 2 цифра {n2} ");
//     Console.WriteLine ($"{number}-> 3 цифра {n3} ");
//     Console.WriteLine ($"{number}-> 4 цифра {n4} ");
//     Console.WriteLine ($"{number}-> 5 цифра {n5} ");
//     //Console.WriteLine ($"{number}-> вторая цифра {result} ");
// }


//int number = new Random().Next(10000, 100000);
Console.WriteLine ("Введите число");
int number = Convert.ToInt32 (Console.ReadLine()); 

int n2 = number % 10;
int n3 = number % 100;
int n4 = number % 1000;
int n5 = number % 10000;

int res = number/10000;
Console.WriteLine ($"{number}-> 1 цифра {res} ");
int result5 = (n5-n4)/1000;
Console.WriteLine ($"{number}-> 2 цифра {result5} ");
int result4 = (n4-n3)/100;
Console.WriteLine ($"{number}-> 3 цифра {result4} ");
int result3 = (n3-n2)/10;
Console.WriteLine ($"{number}-> 4 цифра {result3} ");
int result2 = (n2);
Console.WriteLine ($"{number}-> 5 цифра {result2} ");

if (res == result2 && result5 == result3)
{
    Console.WriteLine ($"{number}-> полиндром ");
}
else
{
    Console.WriteLine ($"{number}-> нет ");
}