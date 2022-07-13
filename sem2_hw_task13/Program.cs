/*
Задача 13

Напишите программу, которая выводит
третью цифру заданного числа или
сообщает, что третьей цифры нет.
*/
/*
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
    */

int[] myArr = new int[5];
// Инициализируем каждый элемент массива вручную
myArr[0] = 100;
myArr[1] = 23;
myArr[2] = 25;
myArr[3] = 31;
myArr[4] = 1;

foreach (int i in myArr)
Console.WriteLine(i);

Console.ReadLine();