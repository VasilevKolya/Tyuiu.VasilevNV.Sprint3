using System;
using Tyuiu.VasilevNV.Sprint3.Task4.V9.Lib;
DataService ds = new DataService();
int startValue = -5;
int stopValue = 5;
Console.WriteLine("*Спринт #3 | Выполнил: Васильев Н. В. | ИСПБ-24-1                     *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("* Спринт #3                                                             *");
Console.WriteLine("* Тема: Использование операторов continue и break в циклах              *");
Console.WriteLine("* Задание #4                                                            *");
Console.WriteLine("* Вариант #9                                                            *");
Console.WriteLine("*  Выполнил: Васильев Н. В. | ИСПБ-24-1                                 *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("*УСЛОВИЕ:                                                               *");
Console.WriteLine("На отрезке, где x принимает значения от -5 до 5,                        *");
Console.WriteLine("  вычислить значение функции y=x/(cos(x) - x)                           *");
Console.WriteLine("*                                                                       *");
Console.WriteLine("*************************************************************************");
Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                       *");
Console.WriteLine("*************************************************************************");


Console.WriteLine("Начало шага:  " + startValue);
Console.WriteLine("Конец шага:  " + stopValue);
Console.WriteLine("*************************************************************************");
Console.WriteLine(" РЕЗУЛЬТАТ:                                                             *");
Console.WriteLine("*************************************************************************");

Console.WriteLine("Сумма ряда = " + ds.Calculate(startValue, stopValue));
Console.ReadKey();

