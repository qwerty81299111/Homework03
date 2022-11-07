// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
//Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

//14212 -> нет

//12821 -> да

//23432 -> да


bool Palendrome(int number)
{
    int firstnum = number / 10000;
    int secondnum = number / 1000;
    int lastnum = number % 10;
    int fourthnum = number % 100;

    return firstnum == lastnum || secondnum == fourthnum;
}

Console.WriteLine("Введите пятизначное число ");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (num > 9999 && num < 100000) Console.WriteLine(Palendrome(num) ? "Да, это палиндром" 
: "Нет, это не палиндром");else Console.WriteLine("число не является пятизначным");


