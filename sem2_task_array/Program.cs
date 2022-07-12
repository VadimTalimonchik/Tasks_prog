/* Массивы

Задача

Задать число, создаётся массив с количеством
элементов равных заданному числу, причем каждый
элемент должен быть равен своему порядковому номеру.
*/

int num = Convert.ToInt32(Console.ReadLine());
int [] array = new int[num];
for (int i = 0; i < num; i++)
{
    array[i] = i;
    Console.WriteLine(array[i]);
}

// после dotnet run надо ввести число