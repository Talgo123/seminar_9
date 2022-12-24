// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int SumDigit(int number, int sum)
{
    sum += number %10;
    if (number > 0)
    {
        SumDigit(number/10, sum);
    }
    else
    {
        System.Console.WriteLine(sum);
    }
    return sum;
}

int sum = 0;
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
sum = SumDigit(number, sum);


// Другой вариант 
// if (number < 0)
// {
//     return num;
// }
// return SumNumber(num / 10) + num % 10;