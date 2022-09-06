//===================================================================
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//===================================================================


Console.Write("Write a = ");
string? a = Console.ReadLine();

Console.Write("Write b = ");
string? b = Console.ReadLine();

Console.Write("Write c = ");
string? c = Console.ReadLine();

if (a != null && b != null && c != null) {
    int b_int = int.Parse(b);
    int a_int = int.Parse(a);
    int c_int = int.Parse(c);
    int[] ints = new int[3];
    ints[0] = a_int;
    ints[1] = b_int;
    ints[2] = c_int;

    Console.Write("max = ");
    Console.WriteLine( ints.Max() );
}


