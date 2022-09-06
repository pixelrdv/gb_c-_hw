//===================================================================
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//===================================================================



Console.Write("Write a = ");
string? a = Console.ReadLine();

Console.Write("Write b = ");
string? b = Console.ReadLine();

if (a != null && b != null) {
    int b_int = int.Parse(b);
    int a_int = int.Parse(a);
    Console.Write("max = ");
    Console.WriteLine( Math.Max(a_int,b_int) );
}


