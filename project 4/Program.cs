using System;

public class MathHelper
{
    public int PrintValue(int a, int b)
    {
        return a + b;
    }

    public int PrintValue(bool value)
    {
        return value ? 1 : 0;
    }

    public void PrintValue(string str1, string str2)
    {
        string result = str1 + str2;
        Console.WriteLine(result);
    }

    public int PrintValue(int a, int b, int c)
    {
        return a * b * c;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        MathHelper mathHelper = new MathHelper();

        int sum = mathHelper.PrintValue(3, 4);
        Console.WriteLine("Sum: " + sum);

        int boolToInt1 = mathHelper.PrintValue(true);
        Console.WriteLine("Bool to Int (true): " + boolToInt1);

        int boolToInt2 = mathHelper.PrintValue(false);
        Console.WriteLine("Bool to Int (false): " + boolToInt2);

        mathHelper.PrintValue("Hello, ", "World!");

        int multiplication = mathHelper.PrintValue(2, 3, 4);
        Console.WriteLine("Multiplication: " + multiplication);
    }
}
