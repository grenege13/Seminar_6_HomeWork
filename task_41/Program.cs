// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


Console.WriteLine("Введите количество чисел: ");
int numberAmoumt = Convert.ToInt32(Console.ReadLine());

int aboveNullCount = 0;

for (int i = 0; i < numberAmoumt; i++)
{
    Console.WriteLine("Введите число: ");

    int number = Convert.ToInt32(Console.ReadLine());   

    if (number > 0) aboveNullCount++;
}
System.Console.WriteLine("Чисел больше 0 : " + aboveNullCount);

