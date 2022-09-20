//==================================================
// №34 Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// [845, 222, 367, 123 -> 1
// * Отсортировать массив методом пузырька
//==================================================

//создаем массив
int[] GenerateArray(int n, int minArrayValue, int maxArrayValue)
{
    int [] arr = new int[n];

    for (int i = 0; i < n; i++)
    {
        arr[i] = new Random().Next(minArrayValue, maxArrayValue);
    }
    return arr;
}

//функция по печати массивов
void PrintData(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]+"\t");
    }
    Console.WriteLine();
}

//подсчет кол-ва четных чисел
int CountEvenNumbers(int[] arr) 
{
    int counter = 0;
    foreach (int num in arr)
    {
        if (num % 2 == 0)
        {
            counter++;
        }
    }
    return counter;
}

// сортировка пузырьком
int[] BubbleSort(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i+1; j < arr.Length; j++)
        {
            if (arr[i] > arr [j])
            {
            // смена позиций без использования третьей переменной
                arr[i] = arr[i] + arr[j];
                arr[j] = arr[i] - arr[j];
                arr[i] = arr[i] - arr[j];
            }
        }
    }
    return arr;
}


int[] randomArray = GenerateArray(new Random().Next(1,50), 100, 999);
Console.WriteLine("Сгенерированный массив:");
PrintData(randomArray);

Console.Write("количество четных чисел в массиве: ");
Console.WriteLine( CountEvenNumbers(randomArray) );

int[] randomArraySorted = BubbleSort(randomArray);
Console.WriteLine("Отсортированный сгенерированный массив:");
PrintData(randomArray);