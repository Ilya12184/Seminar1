/* Напишите программу, которая на вход принимает число (N), а
на выходе показывает все чётные числа от 1 до N.*/

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
int count = 2;  

while(count <= a)
{
    Console.WriteLine(count);
    count = count + 2;
}