/*
Задача 2

Напишите программу, которая на вход
принимает два числа и выдаёт, какое
число большее, а какое меньшее.
*/

Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
{
    Console.WriteLine("Число А больше чила В");
}
else
{
    Console.WriteLine("Число В больше чила А");
}

