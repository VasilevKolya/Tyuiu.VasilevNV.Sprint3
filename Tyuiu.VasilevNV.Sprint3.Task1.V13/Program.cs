﻿using Tyuiu.VasilevNV.Sprint3.Task1.V13.Lib;
DataService ds = new DataService();
double value = 5;
int startValue = 1;
int stopValue = 10;
Console.WriteLine("*Спринт #3 | Выполнил: Васильев Н. В. | ИСПБ-24-1                     *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("* Спринт #3                                                             *");
Console.WriteLine("* Тема: Оператор цикла while                                             *");
Console.WriteLine("* Задание #1                                                            *");
Console.WriteLine("* Вариант #13                                                            *");
Console.WriteLine("*  Выполнил: Васильев Н. В. | ИСПБ-24-1                                 *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("*УСЛОВИЕ:                                                               *");
Console.WriteLine("Написать программу используя цикл while, которая вычисляет              *");
Console.WriteLine(" произведение ряда по формуле, при n=1,2                                *");
Console.WriteLine("*                                                                       *");
Console.WriteLine("*************************************************************************");
Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                       *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("Переменная X:  " + value);
Console.WriteLine("Начало шага:  " + startValue);
Console.WriteLine("Конец шага:  " + stopValue);
Console.WriteLine("*************************************************************************");
Console.WriteLine(" РЕЗУЛЬТАТ:                                                             *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("Произведение ряда = " + ds.GetMultiplySeries(value, startValue, stopValue));
Console.ReadKey();
