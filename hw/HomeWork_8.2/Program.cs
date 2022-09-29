//==================================================
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

//создаем массив
int[,] Generate2DArray(int nSize,  int minArrayValue, int maxArrayValue)
{
    int[,] arr = new int[nSize, nSize];
    for (int i = 0; i < nSize; i++)
    {
        for (int j = 0; j < nSize; j++)
        {
            arr[i, j] = new Random().Next(minArrayValue, maxArrayValue);
        }
    }
    return arr;
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


// функция поиска строки с минимальной суммой в 2Д массиве
int FindMinSumByRown(ref int[,] arr)
{
    int sum = 0;
    int minSum = int.MaxValue;
    int rownWithMinSum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {      
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            sum = sum + arr[i,j];
            // в качестве практики использовал инструкцию goto 
            // в случаях когда сумма по строке уже больше чем минимум и не имеет смысла дальше считать
            if (sum> minSum) 
            {
                sum = 0;
                goto OverSum;
            }
        }

        if(sum < minSum)
        {
            minSum = sum;
            rownWithMinSum=i;
        }
        OverSum: 
        sum = 0;
    }
    return rownWithMinSum+1;
}

string m = ReadData("Введите размерность двумерного массива : ");
int[,] generatedArray = Generate2DArray(int.Parse(m), 0, 10);
Console.WriteLine("\n Сгенерированный массив\n");
Print2DArray(generatedArray);
Console.WriteLine($"\n Минимальная сумма в {FindMinSumByRown(ref generatedArray)} строке\n");
