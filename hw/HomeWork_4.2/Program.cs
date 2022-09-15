//==================================================
// №27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в
// числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// * Сделать оценку времени алгоритма через вещественные числа и строки
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

long Calculate1(string inputNumber)
{
    long res = 0;
    for (int i = 0; i < inputNumber.Length; i++)
    {
        int temp = int.Parse(inputNumber[i].ToString());
        res = res + temp;
    }
    return res;
}

void PrintData(long res)
{
    Console.WriteLine("Сумма чисел равна : " + res);
}

string A = ReadData();
long result = Calculate1(A);
PrintData(result);
