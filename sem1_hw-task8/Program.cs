﻿/*
Задача 8

Напишите программу, которая на вход
принимает число (N), а на выходе показывает
все чётные числа от 1 до N
*/

Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
//for (int i = 1; i < 4; i++) Console.WriteLine(i);
for (int i = 1; i < numberA; i++);
if (numberA % 2 == 0)
{
    Console.WriteLine(numberA);
}
//if (numberA % 2 == 0)
//    Console.WriteLine("Вы ввели ЧЕТНОЕ число!");