using System.IO;
using System;
class Program
{
    public static Tuple<double,double> AddMulti(double a, double b)
    {
        return new Tuple<double, double>((a + b), (a *b));
    }
    static void Main()
    {
        Tuple<double, double>output = Program.AddMulti(3.5,2.0);
        Console.WriteLine("Sum=" +output.Item1+"Multiplication Value= "+output.Item2);
        Console.ReadLine();
       // Tuple<int, string, double>tuple;// =new Tuple<string,string>("1","2","3");
    }
}