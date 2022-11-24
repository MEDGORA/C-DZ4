/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12  */

Console.Write("Введите число: ");
string number = Console.ReadLine();
int Length = number.Length;
int result = 0;
if (number[0] == '-')
{
for (int i = 1; i < Length; i++)
{
    int a = (int)Char.GetNumericValue(number[i]);
    if (i == 1)
    {
        a = a * (-1);
    }
    result = result + a;
}
}
else
{
for (int i = 0; i < Length; i++)
{
    int a = (int)Char.GetNumericValue(number[i]);
    result = result + a;
}
}
Console.WriteLine($"Сумма цифр числа {number} = {result}");
