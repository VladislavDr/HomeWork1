//Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7, min = 5
//a = 2 b = 10 -> max = 10, min = 2
//a = -9 b = -3 -> max = -3, min = -9


Console.WriteLine("Введите первое число");
string answerA = Console.ReadLine();
int numberA = Convert.ToInt32(answerA);

Console.WriteLine("Введите второе число");
string answerB = Console.ReadLine();
int numberB = Convert.ToInt32(answerB);

int max = 0;
int min = 0;

if (numberA > numberB) {
    max = numberA;
    min = numberB;
    Console.Write ("max = "); 
    Console.WriteLine (max);   
    Console.Write ("min = "); 
    Console.WriteLine (min); 
}
else {
    max = numberB;
    min = numberA;
    Console.Write ("max = "); 
    Console.WriteLine (max);   
    Console.Write ("min = "); 
    Console.WriteLine (min); 
}