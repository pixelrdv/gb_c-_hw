//==================================================
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
//==================================================

// функция для сбора параметров
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


//функция по печати массивов
void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


//создаем массив
int[,] Generate2DArray(int nSize, int mSize, int minArrayValue, int maxArrayValue)
{
    int[,] arr = new int[nSize, mSize];
    for (int i = 0; i < nSize; i++)
    {
        for (int j = 0; j < mSize; j++)
        {
            arr[i, j] = new Random().Next(minArrayValue, maxArrayValue);
        }
    }
    return arr;
}

int[,] MatrixMultiplication(int[,] arr1, int[,] arr2, ref bool resultBool)
{
    if (arr1.GetLength(0) == arr2.GetLength(1))
    {
        int[,] result = new int[arr1.GetLength(0), arr2.GetLength(1)];
        for (int i = 0; i < arr1.GetLength(0); i++)
        {
            for (int j = 0; j < arr2.GetLength(1); j++)
            {
                for (int k = 0; k < arr2.GetLength(0); k++)
                {
                    result[i, j] += arr1[i, k] * arr2[k, j];
                }
            }
        }
        resultBool = true;
        return result;
    }
    else
    {
        resultBool = false;
        return new int[1, 1];
    }


}

string m1 = ReadData("Введите количество столбцов в массиве 1 : ");
string n1 = ReadData("Введите количество строк в массиве 1 : ");

string m2 = ReadData("Введите количество столбцов в массиве 2 : ");
string n2 = ReadData("Введите количество строк в массиве 2 : ");

int[,] generatedArray1 = Generate2DArray(int.Parse(n1), int.Parse(m1), 0, 10);
int[,] generatedArray2 = Generate2DArray(int.Parse(n2), int.Parse(m2), 0, 10);

Console.WriteLine("\n Сгенерированный массив 1 \n");
Print2DArray(generatedArray1);
Console.WriteLine("\n Сгенерированный массив 2 \n");
Print2DArray(generatedArray2);

bool goodResult = false;
int[,] multiArray = MatrixMultiplication(generatedArray1, generatedArray2, ref goodResult);
if (goodResult)
{
    Console.WriteLine("\n Результат перемножения матриц\n");
    Print2DArray(multiArray);
}
else
{
    Console.WriteLine("\n Перемножение матриц невозможно\n");
}