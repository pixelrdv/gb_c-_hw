//==================================================
// №25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в
// натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// * Написать калькулятор с операциями +, -, /, * и возведение в степень
//==================================================

string ReadData()
{
    Console.Write("Write inputNumber = ");
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

long Pow(int A, int B)
{
    if (B == 0)
    {
        return 1;
    }

    long res = 1;
    for (int i = 0; i < B; i++)
    {
        res = res * A;
    }
    return res;
}

void PrintData(long res)
{
    Console.WriteLine("A в степени В равно :" + res);
}

string A = ReadData();
string B = ReadData();
long result = Pow( int.Parse(A) , int.Parse(B) );
PrintData(result);
