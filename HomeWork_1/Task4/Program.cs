//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите число,чтобы увидеть все чётные числа от 1 до вашего числа");
string answer = Console.ReadLine();
int number = Convert.ToInt32(answer);

for (int i = 2; i <= number; i = i + 2)
{
    Console.Write("{0}  ", i);
}
