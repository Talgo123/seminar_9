// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


int SqrNumber( int number1, int number2, int sum)
{
    sum = sum * number1;
    if (number2 > 1)
    {
        number2--;
        SqrNumber(number1, number2, sum);
    }
    else
    {
         System.Console.WriteLine(sum);
    }
    return sum; 
}
int sum = 1;
Console.Write("Введите число А: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.Write("Введите число В: ");
int secondNumber = int.Parse(Console.ReadLine());
int result = SqrNumber(firstNumber, secondNumber, sum);

// Другой вариант решения 

// int SqrNumber( int number1, int number2)
// {
//     if(number2 <= 0) return 1;
//     return SqrNumber(number1, --number2 <-- (number2 -1) ) * number1;
// }


