//==================================================
// №38 Задайте массив вещественных чисел. Найдите разницу между максимальным и
// минимальным элементов массива.
// [3 7 22 2 78] -> 76
// [2 0,4 9 7,2 78] -> 77,6
// * Отсортируйте массив методом вставки и методом подсчета, а затем найдите
// разницу между первым и последним элементом. Для задачи со звездочкой
// использовать заполнение массива целыми числами.
//==================================================

//создаем массив
double[] GenerateArray(int n)
{
    double [] arr = new double[n];

    for (int i = 0; i < n; i++)
    {
        arr[i] = Math.Round(new Random().NextDouble() * 100 , 1) ;
    }
    return arr;
}

//функция по печати массивов
void PrintData(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]+"\t");
    }
    Console.WriteLine();
}


void GetDeltaMinMax(double[] arr)
{
    double min = double.MaxValue;
    double max = double.MinValue;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    Console.WriteLine("Разница между максимальным и минимальным элементом массива:");
    Console.Write("{0} - {1} = {2}", max, min, max-min);
}

double[] randomArray = GenerateArray(new Random().Next(1,20));
Console.WriteLine("Сгенерированный массив:");
PrintData(randomArray);


GetDeltaMinMax(randomArray);
// Console.Write("сумма нечетных чисел в массиве: ");
// Console.WriteLine( SumUnevenNumbers(randomArray) );

// GetPrintCouple(randomArray);