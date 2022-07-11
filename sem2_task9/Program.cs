/*
Задача 9

Напишите программу, которая выводит случайное
число из отрезка [10, 99] и показывает
наибольшую цифру числа
*/

/*
int numberA = new Random().Next(10, 99);
Console.WriteLine(numberA);
int firstnum = numberA / 10;
int secondnum = numberA % 10;
if (firstnum < secondnum)
{
    Console.WriteLine(secondnum+ " больше чем " +firstnum);
}
else
{
    Console.WriteLine(firstnum+ " больше чем " +secondnum);
}
*/


// запись в виде функции
/*
int numberA = new Random().Next(10, 99);
Console.WriteLine(numberA);
int firstnum = numberA / 10;
int secondnum = numberA % 10;
void compareNumber(int firstnum, int secondnum)
{
    if (firstnum < secondnum)
    {
        Console.WriteLine(secondnum+ " больше чем " +firstnum);
    }
    else
    {
        Console.WriteLine(firstnum+ " больше чем " +secondnum);
    }
}

compareNumber(firstnum, secondnum);
*/

// все обернуто в функцию
void compareNumber(int firstnum, int secondnum)
{
    if (firstnum < secondnum)
    {
        Console.WriteLine(secondnum+ " больше чем " +firstnum);
    }
    else
    {
        Console.WriteLine(firstnum+ " больше чем " +secondnum);
    }
}

void randomNumbersCompare(int start, int finish)
{
    int numberA = new Random().Next(start, finish);
    Console.WriteLine(numberA);
    int firstnum = numberA / 10;
    int secondnum = numberA % 10;
    compareNumber(firstnum, secondnum);
}

randomNumbersCompare(10, 99);