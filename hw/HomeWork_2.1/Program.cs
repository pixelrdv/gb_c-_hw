//===================================================================
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
//===================================================================

Console.Write("Write inputNumber = ");
string inputNumber = Console.ReadLine();
if (inputNumber != null && inputNumber.Length == 3)
{
    Console.WriteLine(inputNumber.ToCharArray()[1]);
}
else
{
    Console.WriteLine("Wrong format");
}