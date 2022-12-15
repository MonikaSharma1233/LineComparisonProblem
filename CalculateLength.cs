using System;

public class CalculateLength
{
	public static double CalculateLengthofLine()
	{
        Console.WriteLine("Enter the P1(x,y) co-ordinates for Line:");
        int x1 = Convert.ToInt32(Console.ReadLine());
        int y1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the P2(x,y) co-ordinates for Line:");
        int x2 = Convert.ToInt32(Console.ReadLine());
        int y2 = Convert.ToInt32(Console.ReadLine());

        // A Length as 2 Points(x1, y1) and(x2, y2)
        //Length of a Line = sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2)


        double p1 = Math.Pow(x2 - x1, 2);
        double p2 = Math.Pow(y2 - y1, 2);

        //Console.WriteLine("point1=" + p1 + "point2=" + p2);
        double length = Math.Sqrt(p1 + p2);
        //Console.WriteLine("The length of the line is: " + length);
        return length;
    }
}
