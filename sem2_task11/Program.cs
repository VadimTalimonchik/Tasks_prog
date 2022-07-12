/*
Задача 11.

Напишите программу, которая выводит 
случайное трёхзначное число и удаляет 
вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/

/*
int numberA = new Random().Next(100, 999);
Console.WriteLine(numberA);
int thirdnumber = numberA % 10;
int firstnumber = numberA / 100;
Console.WriteLine(thirdnumber + firstnumber * 10);
*/

// обернутое в функцию
int something (int start, int finish)
{
    int numberA = new Random().Next(start, finish);
    Console.WriteLine(numberA);
    int thirdnumber = numberA % 10;
    int firstnumber = numberA / 100;
    int result = thirdnumber + firstnumber * 10;
    return result;
}

int A = something (100, 999);
Console.WriteLine(A);