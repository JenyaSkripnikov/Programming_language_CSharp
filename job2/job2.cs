/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Например:
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Введите два числа: ");
String numberStrA = Console.ReadLine();
String numberStrB = Console.ReadLine();
int numberA = int.Parse(numberStrA);
int numberB = int.Parse(numberStrB);
if (numberA > numberB)
{
    Console.WriteLine($"Число {numberA} больше числа {numberB}");
}
else
{
    Console.WriteLine($"Число {numberB} больше числа {numberA}");
}
