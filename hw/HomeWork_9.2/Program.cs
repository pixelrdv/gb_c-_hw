//==================================================
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
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

int RecNto1 (int m, int n)
{
    if (n==m) return m;
    return n + RecNto1(m, n-1)   ;
}

string m = ReadData("Введите M : ");
string n = ReadData("Введите N : ");
Console.WriteLine( RecNto1( int.Parse(m), int.Parse(n) ) );
