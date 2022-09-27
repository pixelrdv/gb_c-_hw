//==================================================
// №52 Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// * Дополнительно вывести среднее арифметическое по диагоналям и диагональ выделить разным
// цветом.
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

void CalculateRownAvg (double[,] arr, int n, int m)
{
    Console.WriteLine("Средние по строкам :");
    double sumElement = 0;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            sumElement = sumElement + arr[i,j];
        }
        Console.Write($"{sumElement/n} \t" );
        sumElement = 0;
    }
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
CalculateRownAvg(arr, nInt, mInt);
