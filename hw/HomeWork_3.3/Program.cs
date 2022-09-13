//  ============================================================
// №23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов
// чисел от 1 до N.1
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// * Вывести таблицу с границами и значениями друг над другом
//  ============================================================


string inputNumber = ReadData();
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
        string result = "";
        for (int i = 1; i <= int.Parse(inputNumber); i++)
        {
            result = result + Math.Pow(i, 3).ToString();
            if (i != int.Parse(inputNumber)) 
            {
                result = result +", ";
            }
        }
        Console.WriteLine(result);
    }
}
