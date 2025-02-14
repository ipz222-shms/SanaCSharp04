﻿using Matrix;

const int N = 2, M = 7;
int[,] matrix = new int[N, M];
Methods.FillMatrixWithRandomNumbers(ref matrix, -32, 64);

Console.WriteLine($"Matrix[{N},{M}]:");
Methods.PrintMatrix(matrix, ConsoleColor.Magenta);

Console.WriteLine($"1) Кількість додатніх елементів: {Methods.CountPositiveElements(matrix)}");
Console.WriteLine($"2) Максимальне із чисел, що зустрічається в заданій матриці більше одного разу: {Methods.GetMaxDuplicatedElement(matrix)}");
Console.WriteLine($"3) Кількість рядків, які не містять жодного нульового елемента: {Methods.CountRowsWithoutZeros(matrix)}");
Console.WriteLine($"4) Кількість стовпців, які містять хоча б один нульовий елемент: {Methods.CountColumnsWithZeros(matrix)}");
Console.WriteLine($"5) Номер рядка, в якому знаходиться найдовша серія однакових елементів: {Methods.GetRowWithLongestSeries(matrix) + 1}");
Console.WriteLine($"6) Добуток елементів в тих рядках, які не містять від’ємних елементів: {Methods.GetPositiveRowProduct(matrix)}");
Console.WriteLine($"7) Максимум серед сум елементів діагоналей, паралельних головній діагоналі матриці: {Methods.GetMaxSumAmongMainParallelDiag(matrix)}");
Console.WriteLine($"8) Сума елементів в тих стовпцях, які не містять від’ємних елементів: {Methods.GetSumOfPositiveColumns(matrix)}");
Console.WriteLine($"9) Мінімум серед сум модулів елементів діагоналей, паралельних побічній діагоналі матриці: {Methods.GetMinSumAmongSideAbsParallelDiag(matrix)}");
Console.WriteLine($"10) Сума елементів в тих стовпцях, які  містять хоча б один від’ємний елемент: {Methods.GetSumOfColumnsContainingNegatives(matrix)}");
Console.WriteLine($"11) Транспонувати матрицю:");
Methods.PrintMatrix(Methods.TransposeMatrix(matrix), ConsoleColor.Cyan);
