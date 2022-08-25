// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


Console.WriteLine("Задайте число М - количество чисел, которые вы хотите ввести с клавиатуры");
int M = Convert.ToInt32(Console.ReadLine());
int count = 0;
int positCount = 0;

for (int i=1; i<=M; i++)
{
Console.WriteLine($"Введите число номер {i}");
count = Convert.ToInt32(Console.ReadLine());
if (count>0)
{
  positCount = positCount + 1;  
}
}
Console.WriteLine($"Количество положительных чисел - {positCount}");