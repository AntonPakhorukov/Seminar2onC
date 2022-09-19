//Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа.

//78 -> 8 
//12-> 2 
//85 -> 8

Console.Clear();

int randomNum = new Random().Next(10, 99);
Console.WriteLine(randomNum);
int x = randomNum / 10;
int y = randomNum % 10;
if (x > y) {
    Console.WriteLine($"Max = {x}");
} else {
    Console.WriteLine($"Max = {y}");
}
