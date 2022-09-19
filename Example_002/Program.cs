/*
Напишите программу, которая выводит случайное трёхзначное число 
и удаляет вторую цифру этого числа
456 -> 46
782 -> 72
918 -> 98
*/
int random = new Random().Next(100,1000);
int x = random / 100;
int y = random % 10;

Console.WriteLine($"Случайное число: {random}");
Console.WriteLine();

Console.Write("первый способ: ");
Console.Write(x);
Console.WriteLine(y);   
Console.WriteLine();

int value = ((random / 100) * 10) + (random % 10);
Console.WriteLine($"Второй способ: {value}");