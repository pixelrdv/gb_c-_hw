 //==================================================
// №47 Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
// * При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)
//==================================================

using System.Drawing;

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
    double[,] arr = new double[nSize,mSize];
    for (int i = 0; i < nSize; i++)
    {
        for (int j = 0; j < mSize; j++)
        {
            arr[i,j] = Math.Round(new Random().NextDouble() * 100 , 1) ;    
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
                Console.Write(arr[i,j]+"\t");    
            }
            Console.WriteLine();
        }
}

// void ColorPrint2DArray(double[,] arr, int n, int m)
// {
//     for (int i = 0; i < n; i++)
//         {
//             for (int j = 0; j < m; j++)
//             {
//                 Console.Write(arr[i,j]+"\t");    
//             }
//             Console.WriteLine();
//         }
// }

string m = ReadData("Введите количество столбцов в массиве : ");
string n = ReadData("Введите количество строк в массиве : ");

if(m == "" | n == "" | int.Parse(m)<=0 | int.Parse(m)<=0)
{
    Console.WriteLine("Указана некорректная размарность массива");
    Environment.Exit(0);
}



int mInt = int.Parse(m);
int nInt = int.Parse(n);

double[, ] arr = Generate2DArray(nInt,mInt);
Print2DArray(arr, nInt, mInt);

