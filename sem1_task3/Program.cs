/*
задача 3
Напишите программу, которая будет выдавать 
название дня недели по заданному номеру.
1 -> Понедельник 
2 -> Вторник
3 -> Среда
4 -> Четверг 
5 -> Пятница
6 -> Суббота
7 -> Воскресенье
*/

// Вариант 1
/*
Console.WriteLine("Введите номер дня недели: ");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA == 1)
{
    Console.WriteLine("Понедельник");
}
if (numberA == 2)
{
    Console.WriteLine("Вторник");
}
if (numberA == 3)
{
    Console.WriteLine("Среда");
}
if (numberA == 4)
{
    Console.WriteLine("Четверг");
}
if (numberA == 5)
{
    Console.WriteLine("Пятница");
}
if (numberA == 6)
{
    Console.WriteLine("Суббота");
}
if (numberA == 7)
{
    Console.WriteLine("Воскресенье");
}
if (numberA > 7 || numberA < 1)  // && - условное "и"; || - условное "или".
{
    Console.WriteLine("Ошибка");
}
*/


// Вариант 2

Console.WriteLine("Введите номер дня недели: ");
int numberA = Convert.ToInt32(Console.ReadLine());

    switch (numberA)
    {
        case 1:
            Console.WriteLine("Понедельник");
            break;
        case 2:
            Console.WriteLine("Вторник");
            break;
        case 3:
            Console.WriteLine("Среда");
            break;
        case 4:
            Console.WriteLine("Четверг");
            break;
        case 5:
            Console.WriteLine("Пятница");
            break;
        case 6:
            Console.WriteLine("Суббота");
            break;
        case 7:
            Console.WriteLine("Воскресенье");
            break;
        default:
            Console.WriteLine("Ошибка");
            break;
    };