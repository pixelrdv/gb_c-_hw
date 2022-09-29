//==================================================
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
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

// функция сортировки одномерного массива. В данной задаче нужна для сортировки строки
int[] CouterSort(
    ref int[] arr,
    ref Dictionary<int, int> countNum,
    ref List<int> uniqueNum
    )
{
    int j = countNum.Count;
    //сортируем список значений
    for (int n = 0; n < j; n++)
    {
        for (int m = n + 1; m < j; m++)
        {
            if (uniqueNum[n] < uniqueNum[m])
            {
                // смена позиций без использования третьей переменной
                uniqueNum[n] = uniqueNum[n] + uniqueNum[m];
                uniqueNum[m] = uniqueNum[n] - uniqueNum[m];
                uniqueNum[n] = uniqueNum[n] - uniqueNum[m];
            }
        }
    }


    //создаем новый массив с отсортированными значениями
    int[] arrSort = new int[arr.Length];
    int k = 0;
    for (int i = 0; i < j; i++)
    {

        while (countNum[uniqueNum[i]] > 0)
        {
            arrSort[k] = uniqueNum[i];

            k++;
            countNum[uniqueNum[i]]--;
        }
    }
    return arrSort;
}

// главная функция сортировки строк двумерного массива. В теле вызывает отдельную функцию для сортировки строки
void SortRown2DArray(ref int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int[] bufArray = new int[arr.GetLength(0)]; // создаем темповый массив для сортировки линии
        Dictionary<int, int> countNum = new Dictionary<int, int>(); //словарь уникальных элементов
        List<int> uniqueNum = new List<int>(); // список уникальных значений (для упрощенной сортировки)

        // за один цикл собираем уникальные элементы и их кол-во
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            bufArray[j] = arr[i, j];
            if (countNum.ContainsKey(arr[i, j]))
            {
                countNum[arr[i, j]]++;
            }
            else
            {
                countNum[arr[i, j]] = 1;
                uniqueNum.Add(arr[i, j]);
            }
        }

        // сортируем строку и далее передаем значения опять в строку
        bufArray = CouterSort(ref bufArray, ref countNum, ref uniqueNum);
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            arr[i, j] = bufArray[j];
        }
    }
}

string m = ReadData("Введите количество столбцов в массиве : ");
string n = ReadData("Введите количество строк в массиве : ");

int[,] generatedArray = Generate2DArray(int.Parse(n), int.Parse(m), 0, 10);
Console.WriteLine("\n Сгенерированный массив\n");
Print2DArray(generatedArray);
SortRown2DArray(ref generatedArray);
Console.WriteLine("\n Отсортированный массив\n");
Print2DArray(generatedArray);