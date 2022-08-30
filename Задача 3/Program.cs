// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

internal class Programm
{
    private static void Main(string[] args)
    {
        int Prompt(string message)
        {
            Console.Write(message);
            string strValue = Console.ReadLine() ?? "0";
            int value = int.Parse(strValue);
            return value;
        }
        int value = Prompt("Введите число ->");
        if (value % 2 == 0 && value != 2 && 2 != 1)
        {
            Console.WriteLine("да");
        }
        else
        {
            Console.WriteLine("нет");
        }
    }
}