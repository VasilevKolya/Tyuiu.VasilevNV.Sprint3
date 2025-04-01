using Tyuiu.VasilevNV.Sprint3.Task6.V15.Lib;
DataService ds = new DataService();
int startValue = 10;
int stopValue = 15;
Console.WriteLine("*Спринт #3 | Выполнил: Васильев Н. В. | ИСПБ-24-1                     *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("* Спринт #3                                                             *");
Console.WriteLine("* Тема: Обработка целочисленной информации                              *");
Console.WriteLine("* Задание #6                                                            *");
Console.WriteLine("* Вариант #15                                                            *");
Console.WriteLine("*  Выполнил: Васильев Н. В. | ИСПБ-24-1                                 *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("*УСЛОВИЕ:                                                               *");
Console.WriteLine("Напишите программу, которая ищет среди целых чисел, принадлежащих        *");
Console.WriteLine("  числовому отрезку [6, 15] сумму всех делителей.                        *");
Console.WriteLine("*                                                                       *");
Console.WriteLine("*************************************************************************");
Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                       *");
Console.WriteLine("*************************************************************************");

Console.WriteLine("Начало шага:  " + startValue);
Console.WriteLine("Конец шага:  " + stopValue);
Console.WriteLine("*************************************************************************");
Console.WriteLine(" РЕЗУЛЬТАТ:                                                             *");
Console.WriteLine("*************************************************************************");

Console.WriteLine("Сумма ряда = " + ds.GetSumTheDivisors(startValue, stopValue));
Console.ReadKey();

