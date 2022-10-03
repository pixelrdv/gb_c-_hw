//==================================================
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
//==================================================

string ReadData(string stringToPrint)
{
    Console.Write(stringToPrint);
    string inputNumber = Console.ReadLine();
    if (inputNumber != null)
    {
        return inputNumber;
    }
    else
    {
        return "";
    }

}

uint A(uint m, uint n)
{
    if (m == 0) return n + 1;

    if ((m != 0) && (n == 0)) return A(m - 1, 1);

    return A(m - 1, A(m, n - 1));
}

string m = ReadData("Введите M : ");
string n = ReadData("Введите N : ");
Console.WriteLine( A ( uint.Parse(m), uint.Parse(n) ) );
