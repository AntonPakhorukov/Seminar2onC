/*
Напишите программу, которая принимает на вход число и проверяет, 
кратно ли оно одновременно 7 и 23.
14 -> нет 
46 -> нет 
161 -> да
*/
Console.Write("Введите первое число: ");
int x = int.Parse(Console.ReadLine());
if (x % 7 == 0 && x % 23 == 0) {
    Console.WriteLine("Да");
} else {
    Console.WriteLine("Нет");
}