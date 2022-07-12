/*
Задача 10

Напишите программу, которая принимает 
на вход трёхзначное число и на выходе 
показывает вторую цифру этого числа.
*/

/*
// Вариант 1

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int thirdnumber = num % 10;
int firstnumber = num / 100;
int secondnumber = num - (thirdnumber + firstnumber * 100);
Console.WriteLine(secondnumber / 10);
*/


// Вариант 2
/*
int num = new Random().Next(100, 999);
Console.WriteLine(num);
int thirdnumber = num % 10;
int firstnumber = num / 100;
int secondnumber = num - (thirdnumber + firstnumber * 100);
Console.WriteLine(secondnumber / 10);
*/

// Вариант 3

int something (int start, int finish)
{
    int num = new Random().Next(start, finish);
    Console.WriteLine(num);
    int thirdnumber = num % 10;
    int firstnumber = num / 100;
    int secondnumber = num - (thirdnumber + firstnumber * 100);
    Console.WriteLine(secondnumber / 10);
    return secondnumber;
}
int A = something (100, 999);
