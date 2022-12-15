// See https://aka.ms/new-console-template for more information
public class Program
{
    public static void Main(String[] strings)
    {
        Console.WriteLine("Welcome to Comparison Computation Program");
        double lengthofline = CalculateLength.CalculateLengthofLine();
        Console.WriteLine("The length of the line is :" + lengthofline);

        Console.ReadKey(true);//use for show screen for a some time.

    }
}