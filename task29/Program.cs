/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

Console.Write("Введите количество элементов в массиве: ");
int N = Convert.ToInt32(Console.ReadLine());
int [] array = new int [N];
for(int i = 0; i < N; i++)
{
    Console.Write($"Введите {i+1}-й элемент массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
string otvet = string.Join(",", array);
Console.Write("[");
Console.Write(otvet);
Console.Write("]");