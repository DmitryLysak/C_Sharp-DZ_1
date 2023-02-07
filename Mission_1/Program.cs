// Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число: ");
int num_A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num_B = Convert.ToInt32(Console.ReadLine());

int max = num_A;
int min = num_A;

if (num_A > num_B)
{
    max = num_A;
    min = num_B;
}
if (num_A < num_B)
{
    max = num_B;
    min = num_A;
}
Console.WriteLine("Большее число это:  " + max);
Console.WriteLine("Меньшее число это:  " + min);