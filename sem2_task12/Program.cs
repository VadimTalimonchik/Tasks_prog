/*
Задача 12

Напишите программу, которая будет принимать 
на вход два числа и выводить, является ли второе 
число кратным первому. Если число 2 не кратно числу 1, 
то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
*/

/*
Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA % numberB == 0)
{
    Console.WriteLine("Число В кратно числу А");
}
else
{
    int num = numberA % numberB;
    Console.WriteLine("Число В не кратно числу А, остаток " + num);
}
*/

/*
int numberA = new Random().Next(10, 99);
Console.WriteLine("Число А: " + numberA);
int numberB = new Random().Next(1, 9);
Console.WriteLine("Число В: " + numberB);
if (numberA % numberB == 0)
{
    Console.WriteLine("Число В кратно числу А");
}
else
{
    int num = numberA % numberB;
    Console.WriteLine("Число В не кратно числу А, остаток " + num);
}
*/

// функция

void outnumber (int numberA, int numberB)
{
    if (numberA % numberB == 0)
    {
        Console.WriteLine("Число " + numberB + " кратно числу" + numberA);
    }
    else
    {
        int num = numberA % numberB;
        Console.WriteLine("Число " + numberB + " не кратно числу " + numberA + " , остаток " + num);
    }
}

outnumber (20, 3);