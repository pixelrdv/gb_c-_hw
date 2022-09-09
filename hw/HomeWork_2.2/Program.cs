//===================================================================
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
//===================================================================

Console.Write("Write inputNumber = ");
string inputNumber = Console.ReadLine();
if (inputNumber != null && inputNumber.Length >= 3)
{
    Console.WriteLine(inputNumber.ToCharArray()[2]);
}
else
{
    Console.WriteLine("третьей цифры нет");
}