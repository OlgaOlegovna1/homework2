﻿// Программа которая выводит случайное число от10до99 и показыввает наибольшую Цифру числа пример 78 -> 8

int num = new Random().Next(10,100);
int a1 = num / 10;
int a2 = num % 10; //остаток при делении на 10, например 87, остаток будет 7, тк 80 делитмся на 10
int max = a1;
Console.WriteLine($"{a1}, {a2}");
if (max < a2)
{
    max = a2;
}
Console.WriteLine($"Максимальная цифра в числе {num} -> {max}");
