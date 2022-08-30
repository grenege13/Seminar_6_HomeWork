// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Бинарное число : ");
// Console.Write(number / 2);

string BinaryVar = "";

while (number != 1)
{
    BinaryVar = BinaryVar + (number % 2);
    
    number = number / 2;

    if (number == 1) 
    {
        BinaryVar = BinaryVar + 1;
        break;
    }
}

int BinaryVarLength = BinaryVar.Length;

for (int i = BinaryVarLength - 1; i >= 0; i--)
{
    Console.Write(BinaryVar[i]);
}