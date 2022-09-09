//===================================================================
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
//===================================================================

string inputNumber = "";
int inputNumberInt = -1;

void ReadData()
{
    Console.Write("Write inputNumber = ");
    inputNumber = Console.ReadLine();
}

void IsHolyday()
{
    if (inputNumberInt > 5)
    {
        string answer = (inputNumberInt > 7) ? "Wrong format" : "да";
        Console.WriteLine(answer);
    }
    else
    {
        Console.WriteLine("нет");
    }
}


ReadData();

if (inputNumber != null && inputNumber.Length == 1)
{
    Console.WriteLine(inputNumber);
    inputNumberInt = int.Parse(inputNumber);
    IsHolyday();
}
else
{
    Console.WriteLine("wrong format!");
}