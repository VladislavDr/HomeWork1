//Задача 4: Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Введите первое число");
string answerA = Console.ReadLine();
int numberA = Convert.ToInt32(answerA);

Console.WriteLine("Введите второе числое");
string answerB = Console.ReadLine();
int numberB = Convert.ToInt32(answerB);

Console.WriteLine("Введите третье число");
string answerC = Console.ReadLine();
int numberC = Convert.ToInt32(answerC);

int max = 0;

if (numberA > numberB) {
    if (numberA > numberC){
    max = numberA;
    Console.Write("max= ");
    Console.WriteLine(max);
    }
    else {
        max = numberC;
        Console.Write("max= ");
        Console.WriteLine(max);
    }
}
else { 
    if (numberB>numberC){
    max = numberB;
    Console.Write("max= ");
    Console.WriteLine(max);
    }
    else {
        max = numberC;
        Console.Write("max= ");
        Console.WriteLine(max);
    }
}
