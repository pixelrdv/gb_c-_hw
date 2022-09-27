//==================================================
// №50 Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// * Заполнить числами Фиббоначи и выделить цветом найденную цифру
//==================================================

using System.Drawing;
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
        return "";
    }

}

double[,] Generate2DArray(int nSize, int mSize)
{
    double[,] arr = new double[nSize, mSize];
    for (int i = 0; i < nSize; i++)
    {
        for (int j = 0; j < mSize; j++)
        {
            arr[i, j] = Math.Round(new Random().NextDouble() * 100, 1);
        }

    }
    return arr;
}

void Print2DArray(double[,] arr, int n, int m)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

//парсинг строки
int[] ParseCoordinate(string coodinate, int[] arraySize)
{
    Regex regex = new Regex(@"(-?\d)");
    MatchCollection coodinatesArr = regex.Matches(coodinate);
    int j = 0;
    int[] point = new int[2];
    if (coodinatesArr.Count > 0)
    {
        for (int m = 0; m < 2; m++)
        {
            if (int.Parse(coodinatesArr[m].Value) <= 0 |
               int.Parse(coodinatesArr[m].Value) > arraySize[m])
            {
                Console.WriteLine("Указана некорректная точка массива");
                Environment.Exit(0);
            }
            else
            {
                point[m] = int.Parse(coodinatesArr[m].Value);
            }

        }
    }
    else
    {
        Console.WriteLine("Совпадений не найдено");
    }
    return point;
}

string m = ReadData("Введите количество столбцов в массиве : ");
string n = ReadData("Введите количество строк в массиве : ");

if (m == "" | n == "" | int.Parse(m) <= 0 | int.Parse(m) <= 0)
{
    Console.WriteLine("Указана некорректная размарность массива");
    Environment.Exit(0);
}

int mInt = int.Parse(m);
int nInt = int.Parse(n);

double[,] arr = Generate2DArray(nInt, mInt);
Print2DArray(arr, nInt, mInt);

string position = ReadData("укажите позицию элемента в массиве (строка, столбец) : ");
if (position == "")
{
    Console.WriteLine("Указана некорректная точка массива");
    Environment.Exit(0);
}
else
{
    int[] positionArr = ParseCoordinate(position, new int[2]{nInt, mInt});
    Console.WriteLine(arr[positionArr[0]-1, positionArr[1]-1]);
}

