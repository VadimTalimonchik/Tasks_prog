﻿/* Напишите программу, которая на вход принимает
два числа и проверяет, является ли первое число
квадратом второго.
a = 5; b = 25 -> да 
a = 2 b = 10 -> нет 
a = 9; b = -3 -> нет 
a = -3 b = 9 -> да */

Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA == numberB*numberB)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
