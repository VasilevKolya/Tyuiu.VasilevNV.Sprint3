﻿using Tyuiu.VasilevNV.Sprint3.Task3.V24.Lib;
DataService ds = new DataService();
Console.WriteLine("*Спринт #3 | Выполнил: Васильев Н. В. | ИСПБ-24-1                     *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("* Спринт #3                                                             *");
Console.WriteLine("* Тема: Оператор цикла foreach                                          *");
Console.WriteLine("* Задание #3                                                            *");
Console.WriteLine("* Вариант #24                                                           *");
Console.WriteLine("*  Выполнил: Васильев Н. В. | ИСПБ-24-1                                 *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("*УСЛОВИЕ:                                                               *");
Console.WriteLine("Используя цикл foreach заменить буквы g  на * в строке: gft hggt ntg    *");
Console.WriteLine("*                                                                       *");
Console.WriteLine("*************************************************************************");
Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                       *");
Console.WriteLine("*************************************************************************");
string value = "gft hggt ntg";
char replaceable = 'g';
char replacement = '*';
Console.WriteLine("Исходный текст" + value);
Console.WriteLine("Исходный символом" + replaceable);

Console.WriteLine("*************************************************************************");
Console.WriteLine(" РЕЗУЛЬТАТ:                                                             *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("Результат замены:" + ds.ReplaceCharInString(value, replaceable, replacement));
Console.ReadKey();

