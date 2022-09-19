/*
12. Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. Если число 2 не кратно числу 1, 
то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
*/

// Первое решение

/*
int x = new Random().Next(1, 100);
int y = new Random().Next(1, 10);
Console.WriteLine($"Первое число: {x}");
Console.WriteLine($"Второе число: {y}");
int z = x % y;
if (x % y == 0) {
    Console.WriteLine("Кратно");
} else {
    Console.WriteLine($"Не кратно, остаток {z}");
}
*/

// Второе решение

Console.Write("Введите первое число: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int y = int.Parse(Console.ReadLine());
int z = x % y;
if (x % y == 0) {
    Console.WriteLine("Кратно");
} else {
    Console.WriteLine($"Не кратно, остаток {z}");
}
