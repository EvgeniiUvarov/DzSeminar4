//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

using System;
using static System.Console;
Clear();

Write("Введите число: ");
int number = Convert.ToInt32(ReadLine());

int summa = 0;

while (number > 0)
{
    int num = number % 10;
    number/= 10;
    summa += num;
}
Write($"Сумма цифр в числе рована: {summa}");

 

