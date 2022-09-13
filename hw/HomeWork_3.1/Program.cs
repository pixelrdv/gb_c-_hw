//  ============================================================
// №19 Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да
// * Сделать вариант через СЛОВАРЬ четырехзначных палиндромов
//  ============================================================

string inputNumber = ReadData();
Dictionary<string, bool> polindromDict = new Dictionary<string, bool>();
GenerateDict();
run();

// функцияя по считыванию входящего параметра
string ReadData()
{
    Console.Write("Write inputNumber = ");
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


// функция по генерации четырехзначных полиндромов
void GenerateDict()
{

    for (int i = 10; i < 100; i++)
    {
        int el4 = i / 10;
        int el3 = i % 10;
        string outline = string.Format(i + "" + el3 + "" + el4);
        polindromDict.Add(outline, true);
    }
    // return polindromDict;
}

//функция проверяющая четырехзначные полиндромы через словарь
void checkPolindrom4()
{
    if (polindromDict.ContainsKey(inputNumber))
    {
        Console.Write("да");
    }
    else
    {
        Console.Write("нет");
    }
}

// функция универсальная для определения полиндромов любой размерности
void checkPolindrom()
{
    int length = inputNumber.Length;
    char[] inputNumberArr = inputNumber.ToCharArray();
    string result = "да";
    for (int i = 0; i < length / 2; i++)
    {
        if (inputNumberArr[i] != inputNumberArr[length - i - 1])
        {
            result = "Нет";
            break;
        }
    }
    Console.WriteLine(result);
}

//функция начала программы
void run()
{
    if (inputNumber == "")
    {
        Console.WriteLine("Writed NULL string");
        Environment.Exit(0);
    }
    else
    {
        if (inputNumber.Length == 4) // для 4х-значных своя функция по заданию
        {
            checkPolindrom4();
        }
        else
        {
            checkPolindrom();
        }
    }
}
