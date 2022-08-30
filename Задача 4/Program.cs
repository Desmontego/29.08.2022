// // Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// // 5 -> 2, 4
// // 8 -> 2, 4, 6, 8

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine ()  ?? "0";
    int value = int.Parse(strValue);
    return value;
}
int value =Prompt("Введите значение ->");
for(int i=1; i<value; i++)
{
    if(i % 2 == 0) Console.Write(i+ " ");
}
Console.ReadKey();