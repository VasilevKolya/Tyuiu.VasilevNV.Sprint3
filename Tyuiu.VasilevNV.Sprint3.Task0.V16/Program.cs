﻿using Tyuiu.VasilevNV.Sprint3.Task0.V16.Lib;
DataService ds = new DataService();
int value = 5;
int startValue = 1;
int stopValue = 10;

Console.WriteLine("*Спринт #3 | Выполнил: Васильев Н. В. | ИСПБ-24-1                      *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("* Спринт #3                                                             *");
Console.WriteLine("* Тема: Оператор цикла for                                             *");
Console.WriteLine("* Задание #0                                                            *");
Console.WriteLine("* Вариант #16                                                            *");
Console.WriteLine("*  Выполнил: Васильев Н. В. | ИСПБ-24-1                                 *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("*УСЛОВИЕ:                                                               *");
Console.WriteLine("Написать программу используя цикл for, которая                           *");
Console.WriteLine(" вычисляет произведение ряда по формуле, при x = 5                       *");
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
Console.WriteLine("Сумма ряда = " + ds.GetMultiplySeries(value, startValue, stopValue));
Console.ReadKey();
