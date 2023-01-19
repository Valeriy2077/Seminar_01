// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите 2 числа, чтобы я выяснил какое из них больше");
int min = 0;
int max = 0;

System.Console.WriteLine("Введите  A:");
int number1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите B:");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    max = number1;
    min = number2;
}
else
{
    max = number2;
    min = number1;
}

Console.WriteLine("max = " + max);