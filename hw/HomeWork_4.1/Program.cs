//==================================================
// №25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в
// натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// * Написать калькулятор с операциями +, -, /, * и возведение в степень
//==================================================

using System.Text.RegularExpressions;

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
        Console.WriteLine("Writed NULL string");
        Environment.Exit(0);
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


//парсинг строки
int[] getNumbers(string mathOperation)
{
    int[] numbers = new int[2];
    Regex regex = new Regex(@"(-?\d+)");
    MatchCollection reNumbers = regex.Matches(mathOperation);
    if (reNumbers.Count == 2)
    {
        numbers[0]= int.Parse(reNumbers[0].Value);
        numbers[1]= int.Parse(reNumbers[1].Value);
    }
    else
    {
        Console.WriteLine("Некорректная строка");
        Environment.Exit(0);
    }
    return numbers;
}

string getOperator(string mathOperation)
{
    Regex regex = new Regex(@"(?<=\d|\s)(\+|\-|\/|\*|\^)");
    MatchCollection reChar = regex.Matches(mathOperation);
    if (reChar.Count > 0)
    {
        return  reChar[0].Value ;
    }
    else
    {
        Console.WriteLine("Некорректная строка");
        Environment.Exit(0);
    }
    return "1";
}

void PrintData(string stringToPrint, double res)
{
    Console.WriteLine(stringToPrint + res);
}

Console.WriteLine("Справка.\nЕсли используете отрицательные числа, то перед вторым числом поставьте пробел.\n\nПример:\n-1* -7\n\n в противном случае можете писать любое количество пробелов между числами");
string A = ReadData("\nВведите математическую операцию: ");

int[] result = getNumbers(A);
string mathOperator = getOperator(A);

if (mathOperator == "+")
{
    PrintData("Сумма чисел равна : ", result[0] + result[1]);
}

if (mathOperator == "-")
{
    PrintData("Разность чисел равна : ", result[0] - result[1]);
}

if (mathOperator == "*")
{
    PrintData("Произведение чисел равно : ", result[0] * result[1]);
}

if (mathOperator == "/")
{
    PrintData("частное чисел равно : ", Convert.ToDouble(result[0]) / result[1])  ;
}

if (mathOperator == "^")
{
    PrintData("Возведение в степень равно : ", Pow(result[0] , result[1]) );
}

// long result = Pow(int.Parse(A), int.Parse(B));
// PrintData(result);
