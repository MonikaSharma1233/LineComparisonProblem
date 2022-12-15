using System;

public class CheckEquality_UC2
{
	public static void Compare_Length()
	{
        Console.WriteLine("Enter the Co-ordinates for First Line.");
        double lengthofline1 = CalculateLength.CalculateLengthofLine();
        //Console.WriteLine("The length of the line is :" + lengthofline1);

        Console.WriteLine("Enter the Co-ordinates for Second Line.");
        double lengthofline2 = CalculateLength.CalculateLengthofLine();
        //Console.WriteLine("The length of the line is :" + lengthofline2);

        //Compare the Line Length1 to other i call function twice both time it return length of line1 and length of line 2 
        bool compare = String.Equals(lengthofline1, lengthofline2);
        Console.WriteLine(compare);
        if (compare == true)
        {
            Console.WriteLine("Lines are equal");
        }
        else
        {
            Console.WriteLine("Lines are not equal");

        }

    }
}
