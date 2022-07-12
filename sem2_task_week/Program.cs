// Задача с днями недели при помощи массива

int num = Convert.ToInt32(Console.ReadLine());
string[] weekDays = new string[] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресение" };
Console.WriteLine(weekDays[num-1]);
