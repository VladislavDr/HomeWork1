﻿//1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да 
//a = 2, b = 10 -> нет 
//a = 9, b = -3 -> да 
//a = -3, b = 9 -> нет
//3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//	3 -> Среда 
//5 -> Пятница

Console.WriteLine("Введите первое числое");
string answerA = Console.ReadLine();
int numberA = Convert.ToInt32(answerA);

Console.WriteLine("Введите второе числе");
string answerB = Console.ReadLine();
int numberB = Convert.ToInt32(answerB);

if (numberB*numberB==numberA){
    Console.WriteLine ("Yes");
}
else Console.WriteLine ("No");
