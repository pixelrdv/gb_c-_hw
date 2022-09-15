//==================================================
// №29 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// * Ввести с клавиатуры длину массива и диапазон значений элементов
// *Дополнительно: Написать программу которая из имен через запятую выберет случайное
// имя и выведет в терминал
// Игорь, Антон, Сергей -> Антон
// Подсказка: Для разбора строки использовать метод string.split(). Для выбора
// случайного имени метод Random.Next(1,<длина массива имен>+1). 
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

int[] generateArray(int n, int A, int B)
{
    if (n <= 0)
    {
        Console.WriteLine("некорректная размерность массива");
        Environment.Exit(0);
    }
    int [] arr = new int[n];

    for (int i = 0; i < n; i++)
    {
        arr[i] = new Random().Next(A, B);
    }
    return arr;
}

void PrintData(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]+"\t");
    }
}

string n = ReadData("Введите размерность массива (целое число) : ");
string A = ReadData("Введите минимальную величину чисел (целое число) : ");
string B = ReadData("Введите максимальную величину чисел (целое число) : ");
int[] result = generateArray( int.Parse(n) , int.Parse(A) , int.Parse(B) );
PrintData(result);
