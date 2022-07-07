/* Задача 0
Напишите программу, которая на вход
принимает число и выдаёт его квадрат,
например: 4 -> 16; -3 -> 9; -7 -> 49. */

Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int summ = numberA * numberA;
Console.WriteLine(summ);