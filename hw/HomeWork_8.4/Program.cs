//==================================================
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
//==================================================



//функция по печати 3D массивов
void Print3DArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k]}({i},{j},{k})\t");
            }
            Console.WriteLine();
        }
    }
}


//создаем 3D массив
int[,,] Generate3DArray(
    int minArrayValue,
    int maxArrayValue,
    int n = 2,
    int m = 2,
    int z = 2)
{
    int[,,] arr = new int[n, m, z];
    Dictionary<int, bool> uniqueNum = new Dictionary<int, bool> { }; //словарь для учета уникальности
    int tempNum = 0; // темповая переменная для учета уникальности
    bool repeat = true; // переменная для цикла при генерации уникального значения

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            for (int k = 0; k < z; k++)
            {
                //блок подготовки уникального значения
                while (repeat)
                {
                    tempNum = new Random().Next(minArrayValue, maxArrayValue);
                    if (!uniqueNum.ContainsKey(tempNum))
                    {
                        uniqueNum[tempNum] = true;
                        arr[i, j, k] = tempNum;
                        repeat = false;
                    }
                }
                repeat = true;
            }
        }
    }
    return arr;
}

int[,,] array = Generate3DArray(0, 20);
Print3DArray(array);