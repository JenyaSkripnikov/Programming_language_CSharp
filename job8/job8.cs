/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Например:
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.Write("Введите число: ");
int number = int.Parse (Console.ReadLine());
for (int N = 1; N <= number; N++)
if (N %2==0) 
{
    Console.WriteLine ($"{N}");
}
