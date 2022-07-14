/*
Задача 13

Напишите программу, которая выводит
третью цифру заданного числа или
сообщает, что третьей цифры нет.
*/

Console.Write("Введите любое число: ");
int x = Convert.ToInt32(Console.ReadLine());

void hasThirdNumber(int x)
{
    int div = 1;
    while (x / div >= 10)
    {
        div *= 10;
    }
    if (div < 100)
    {
        Console.WriteLine("В числе нет третьей цифры!");
    }
    else
    {
        int digit = (x / (div / 100)) % 10;
        Console.WriteLine("Третья цифра в числе: {0}", digit);
    }
}

hasThirdNumber(x);
