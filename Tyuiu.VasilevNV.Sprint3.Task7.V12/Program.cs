using System;
using Tyuiu.VasilevNV.Sprint3.Task7.V12.Lib;
DataService ds = new DataService();
Console.WriteLine("*Спринт #3 | Выполнил: Васильев Н. В. | ИСПБ-24-1                     *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("* Спринт #3                                                             *");
Console.WriteLine("* Тема: Базовые навыки работы в С#                                      *");
Console.WriteLine("* Задание #7                                                            *");
Console.WriteLine("* Вариант #12                                                           *");
Console.WriteLine("*  Выполнил: Васильев Н. В. | ИСПБ-24-1                                 *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("*УСЛОВИЕ:                                                               *");
Console.WriteLine("Написать программу, которая выводит таблицу значений функции:           *");
int startValue = -5;
int stopValue = 5;

Console.WriteLine("*                                                                       *");
Console.WriteLine("*************************************************************************");
Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                       *");
Console.WriteLine("*************************************************************************");

Console.WriteLine("Начало шага:  " + startValue);
Console.WriteLine("Конец шага:  " + stopValue);

int len = ds.GetMassFunction(startValue, stopValue).Length;
double[] valueArray;
valueArray = new double[len];
valueArray = ds.GetMassFunction(startValue, stopValue);
Console.WriteLine("*************************************************************************");
Console.WriteLine(" РЕЗУЛЬТАТ:                                                             *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("┌──────┬────────┐");
Console.WriteLine("│  x   │  F(x)  │");
Console.WriteLine("├──────┼────────┤");
Console.WriteLine("└──────┴────────┘");

for (int i = 0; i < len; i++)
{
    Console.WriteLine("|{0,5:d}       |   {1,5:f2}    |", startValue,valueArray[i]);
    startValue++;
}
Console.WriteLine("└──────┴────────┘");
Console.ReadKey();

