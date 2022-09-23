//==================================================
// №43 Напишите программу, которая найдёт точку пересечения двух прямых, заданных
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// * Найдите площадь треугольника образованного пересечением 3 прямых
//==================================================

using System.Text.RegularExpressions;

// main ======================
int lineCount = 2;
LineParamets[] lines = new LineParamets[lineCount];
for (int i = 0; i < lineCount; i++)
{
    string inputString = ReadData(i);
    if (inputString == "")
    {
        Console.WriteLine("Writed NULL string");
        Environment.Exit(0);
    }
    ParseParam(inputString, i);
}

CrossPointPrint(lines);


// функция по считыванию входящего параметра
string ReadData(int i)
{
    Console.WriteLine("enter the parameters of the line №" + (i + 1) + " separated by commas (k, b)");
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

//парсинг строки
void ParseParam(string param, int i)
{

    Regex regex = new Regex(@"(-?\d)");
    MatchCollection paramArr = regex.Matches(param);
    int j = 0;
    LineParamets line = new LineParamets();
    if (paramArr.Count > 0)
    {
        line.k = double.Parse(paramArr[0].Value);
        line.b = double.Parse(paramArr[1].Value);
        lines[i] = line;
        line.Print();
    }
    else
    {
        Console.WriteLine("Некорректно введены координаты. Совпадений не найдено");
        Environment.Exit(0);
    }
}

//функция поиска точки пересечения
void CrossPointPrint(LineParamets[] arr)
{
    double x = 0;
    double y = 0;
    
    x = (arr[1].b - arr[0].b) / (arr[0].k - arr[1].k);
    y = arr[0].k*x + arr[0].b;
    Console.WriteLine("x: " + x + " y: " + y);
}

class LineParamets
{
    public double k ;
    public double b;
    public void Print()
    {
        Console.WriteLine($"k : {k} , b : {b}");
    }
}