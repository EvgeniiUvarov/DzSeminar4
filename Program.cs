//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
//вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

using System;
using static System.Console;
Clear();

WriteLine("Введите трёх значное число: ");
int a = Convert.ToInt32(ReadLine());

if ((Math.Abs(a) < 100) || (Math.Abs(a) > 999))
{
    WriteLine("Введите не трёх значное число: ");
    return;
}

int curent = a / 10;
int curent1 = curent % 10;
WriteLine(curent1);
