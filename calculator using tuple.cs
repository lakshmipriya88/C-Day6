using System.IO;
using System;
public class Calculator
{
    public static Tuple<int,int,int,double> AddMultiSubDiv(int a, int b)
    {
        return new Tuple<int, int,int,double>((a + b),(a * b),(a-b),(a/b));
    }
    public static void Main()
    {
        Tuple<int, int,int,double>output = Calculator.AddMultiSubDiv(6,2);
        Console.WriteLine("Sum=" +output.Item1);
        Console.WriteLine("Multiplication Value= "+output.Item2);
        Console.WriteLine("Sub Value= "+output.Item3);
        Console.WriteLine("Divide Value= "+output.Item4);
        Console.ReadLine();
    }
}