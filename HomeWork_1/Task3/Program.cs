//Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("Введите число, чтобы проверить его четность");
string answer = Console.ReadLine();
int number = Convert.ToInt32(answer);

if (number%2 == 0) {
    Console.WriteLine("Это число четное");
}
else {
    Console.WriteLine("Это числе не четное");
}