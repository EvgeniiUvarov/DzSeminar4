//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

using System;
using static System.Console;
Clear();

Write("Введите число A : ");
int NumberA = Convert.ToInt32(ReadLine());

Write("Введите число B : ");
int NumberB = Convert.ToInt32(ReadLine());

int resaut = NumberA;
//double resaut = Math.Pow(NumberA,NumberB);

{ 
   for (int count = 1; count < NumberB; count++)
   {
        resaut*=NumberA;
   }
}
WriteLine($"A в степени B = {resaut}");




