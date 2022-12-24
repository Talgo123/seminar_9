// Задача 63.
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

void Recursion(int number)
{
    if (number >= 1)
    {
        Recursion(number - 1);
        Console.Write(number + " ");
    }
}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Recursion(number);
