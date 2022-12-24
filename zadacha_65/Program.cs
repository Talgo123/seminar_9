// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


void Recursion(int leftNumber, int rightNumber)
{
    if (rightNumber >= leftNumber)
    {
        Recursion(leftNumber, rightNumber - 1);
        Console.Write(rightNumber + " ");
    }
}


Console.Write("Введите левую границу: ");
int leftNumber = int.Parse(Console.ReadLine());
Console.Write("Введите правую границу: ");
int rightNumber = int.Parse(Console.ReadLine());
Recursion(leftNumber,rightNumber);