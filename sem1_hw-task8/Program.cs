/*
Задача 8

Напишите программу, которая на вход
принимает число (N), а на выходе показывает
все чётные числа от 1 до N
*/

//for (int i = 1; i < 4; i++) Console.WriteLine(i);

Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= numberA)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i + " - четное число в составе числа " + numberA);
    }
    i++;
}
//for (int i = 1; i < numberA; i++) Console.WriteLine(i);
