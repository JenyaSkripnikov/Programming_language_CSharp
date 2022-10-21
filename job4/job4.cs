/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Например:
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите три числа: ");
String numberStrA = Console.ReadLine();
String numberStrB = Console.ReadLine();
String numberStrС = Console.ReadLine();
int numberA = int.Parse(numberStrA);
int numberB = int.Parse(numberStrB);
int numberC = int.Parse(numberStrС);
if (numberA > numberB && numberA > numberC)
{
    Console.WriteLine($"Число {numberA} больше числа {numberB} и {numberC}");
}
else 
{
    if (numberB > numberA && numberB > numberC)
    {
         Console.WriteLine($"Число {numberB} больше числа {numberA} и {numberC}");
    }
    else
    {
        if (numberC > numberA && numberC > numberB)
        {
             Console.WriteLine($"Число {numberC} больше числа {numberA} и {numberB}");
        }
    }
}