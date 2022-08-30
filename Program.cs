//  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

internal class Programs
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

        int firstValue = Prompt("Введите первое число ->");
        int secondValue = Prompt("Введите второе число ->");
        int thirdValue = Prompt("Введите третье число ->");
        int Max = firstValue;
        if (firstValue < secondValue) 
        {
            Max=secondValue;
        }    
        else
        {
            Max=firstValue;
        }
        if (secondValue < thirdValue) 
        {
            Max = thirdValue;
        }    
        else
        {
            Max=secondValue;
        }
        Console.WriteLine(Max);
    }

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string? ToString()
    {
        return base.ToString();
    }
}