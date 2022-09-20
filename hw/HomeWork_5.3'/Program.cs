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
int[] GenerateArray(int n, int minArrayValue, int maxArrayValue)
{
    int[] arr = new int[n];
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
        Console.Write(arr[i] + "\t");
    }
    Console.WriteLine();
}

int[] InsertSort(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        int tempNum = arr[i];
        int j = i;
        while (j > 0 && arr[j - 1] > tempNum)
        {
            arr[j] = arr[j] + arr[j - 1];
            arr[j - 1] = arr[j] - arr[j - 1];
            arr[j] = arr[j] - arr[j - 1];
            j--;
        }
        arr[j] = tempNum;
    }
    return arr;
}


int[] CouterSort(int[] arr)
{
    Dictionary<int, int> countNum = new Dictionary<int, int>();
    List<int> uniqueNum = new List<int>();
    int j = 0;
    //создаем список уникальных значений и словарь частоты нахождения
    for (int i = 0; i < arr.Length; i++)
    {
        if (countNum.ContainsKey(arr[i]))
        {
            countNum[arr[i]]++;
        }
        else
        {
            countNum[arr[i]] = 1;
            uniqueNum[j] = arr[i];
            j++;
        }
    }
    //сортируем список значений
    for (int n = 0; n < j; n++)
    {
        for (int m = n + 1; m < j; m++)
        {
            if (uniqueNum[n] > uniqueNum[m])
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
        while (countNum[ uniqueNum[i] ] < 0)
        {
            arrSort[k] = uniqueNum[i];
            k++;
            countNum[ uniqueNum[i] ]--;
        }
    }
    return arrSort;

}


int[] randomArray = GenerateArray(new Random().Next(100, 1000), 0, 20);
Console.WriteLine("Сгенерированный массив:");
PrintData(randomArray);

Console.WriteLine("Отсортировали Вставкой:");
int[] randomArraySorted = InsertSort(randomArray);
PrintData(randomArraySorted);

Console.WriteLine("Отсортировали Подсчетом:");
int[] randomArraySorted2 = InsertSort(randomArray);
PrintData(randomArraySorted2);


DateTime start = DateTime.Now;
int l = 1000;
while (l>0)
{
    randomArraySorted = InsertSort(randomArray);
    l--;
}
Console.Write("скорость сортировки Вставкой  : ");
Console.WriteLine(DateTime.Now - start);

DateTime start2 = DateTime.Now;
l = 1000;
while (l>0)
{
    randomArraySorted2 = InsertSort(randomArray);
    l--;
}
Console.Write("скорость сортировки Подсчетом : ");
Console.WriteLine(DateTime.Now - start2);