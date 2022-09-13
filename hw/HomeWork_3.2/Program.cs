//  ============================================================
// №21 Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// * Сделать метод загрузки точек
//  ============================================================

using System.Text.RegularExpressions;
int[,] points = new int[2, 3];

for (int i = 0; i < 2; i++)
{
    string inputString = ReadData(i);
    if (inputString == "")
    {
        Console.WriteLine("Writed NULL string");
        Environment.Exit(0);
    }
    ParseCoordinate(inputString, i);
}

calculateDistance();


// функцияя по считыванию входящего параметра
string ReadData(int i)
{
    Console.WriteLine("enter the coordinates of the point №" + (i+1) + " separated by commas");
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
void ParseCoordinate(string coodinate, int i)
{
    
    Regex regex = new Regex(@"(-?\d)");
    MatchCollection coodinatesArr = regex.Matches(coodinate);
    int j=0;
    if (coodinatesArr.Count > 0)
    {
        for (int m = 0; m < 3; m++)
        {
            points[i,m] = int.Parse(coodinatesArr[m].Value);
        }
    }
    else
    {
        Console.WriteLine("Совпадений не найдено");
    }
}

//расчет результата
void calculateDistance()
{
    double result = 0;
    for (int i = 0; i < 3; i++)
    {
        result = result + Math.Pow( points[0, i] - points[1,i], 2 );
    }
    result = Math.Round( Math.Sqrt(result), 4);
    Console.WriteLine(result);
}
