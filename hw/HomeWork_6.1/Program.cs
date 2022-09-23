//==================================================
// №41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл
// пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
// * Пользователь вводит число нажатий, затем программа следит за нажатиями и
// выдает сколько чисел больше 0 было введено.
//==================================================


// using System;


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


void CountPositive(int Mnum)
{
    if (Mnum <= 0)
    {
        Console.WriteLine("Некорректное число. Конец программы");
        Environment.Exit(0);
    }
    
    int count = 0;
    while (Mnum > 0)
    {
        if (int.Parse(ReadData(" ")) > 0 )
        {
            count++;
        }
        Mnum--;
    }
    Console.WriteLine("Количество положительных чисел : " + count);
}



string M = ReadData("Введите количество цифр, которые будут введены : ");
CountPositive(int.Parse(M));