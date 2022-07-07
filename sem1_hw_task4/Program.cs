/*
Задача 4

Напишите программу, которая принимает
на вход три числа и выдаёт максимальное
из этих чисел.
*/

Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число С: ");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;
if (max < numberB)
{
    max = numberB;
}
if (max < numberC)
{
    max = numberC;
}
Console.WriteLine("Максимальное из трех чисел: " + max);