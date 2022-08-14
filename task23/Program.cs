/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

Console.Write("Введите натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

for (int valueNumber = 1; valueNumber <= numberN; valueNumber++)
{
    Console.WriteLine(Math.Pow(valueNumber,3));
}