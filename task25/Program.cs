/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

if (B == 0)
{
    Console.WriteLine($"Число {A} в степени {B} = 1");
}
else if (B> 0)
{
int result = 1;
for (int i = 1; i < (B+1) ; i++)
{
     result = result * A;
}
Console.WriteLine($"Число {A} в степени {B} = {result}");
}
else if (B < 0)
{
Console.WriteLine($"Число B: {B} должно быть натуральным (больше нуля)");
}