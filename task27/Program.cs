/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.Write("Введите число: ");
string number = Console.ReadLine();
int b = number.Length;
int result = 0;
for (int i = 0; i < b ; i++)
{
    Console.WriteLine(result);
    int a = Convert.ToInt32(number[i]);
    Console.WriteLine(a);
    result = result + a;
    Console.WriteLine(number[i]);
    //Console.WriteLine(result);
}
Console.WriteLine($"Сумма цифр числа {number} = {result}");
