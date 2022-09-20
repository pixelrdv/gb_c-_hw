//==================================================
// №36 Задайте одномерный массив, заполненный случайными числами. Найдите сумму
// элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [3, 7, -2, 1] -> 8
// [-4, -6, 89, 6] -> 0
// * Найдите все пары в массиве и выведите пользователю
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

//подсчет суммы нечетных чисел
int SumUnevenNumbers(int[] arr) 
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum = sum + arr[i];
        }
    }
    return sum;
}

// поиск пар чисел
void GetPrintCouple(int[] arr)
{
    var coupleDict = new Dictionary<int, bool>();
    string result = "";
    foreach (int num in arr)
    {
        if (coupleDict.ContainsKey(num))
        {
                result = result + num.ToString() + " - " + num.ToString() + "\n";
                coupleDict.Remove(num);
        } else
        {
            coupleDict[num] = false;
        }
            
    }
    if (result != "")
    {
        Console.WriteLine("Найденные пары чисел:");
        Console.WriteLine(result);    
    }
    else
    {
        Console.WriteLine("Пар чисел в массиве нет");
    }
    
}


int[] randomArray = GenerateArray(new Random().Next(1,20), 0, 20);
Console.WriteLine("Сгенерированный массив:");
PrintData(randomArray);

Console.Write("сумма нечетных чисел в массиве: ");
Console.WriteLine( SumUnevenNumbers(randomArray) );

GetPrintCouple(randomArray);