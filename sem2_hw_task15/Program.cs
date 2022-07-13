/*
Задача 15

Напишите программу, которая принимает
на вход цифру, обозначающую день недели,
и проверяет, является ли этот день выходным.
*/

Console.Write("Введите число недели: ");
int num = Convert.ToInt32(Console.ReadLine());

string[] weekDays = new string[] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресение" };
//Console.WriteLine(weekDays[num-1]);

    if (num < 6)
    {
        Console.WriteLine("Сегодня " + weekDays[num-1]);
    }
    else
    {
        Console.WriteLine("Сегодня " + weekDays[num-1] + ", выходной!");
    }
    