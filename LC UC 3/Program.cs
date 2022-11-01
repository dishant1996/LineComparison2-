class Program
{
    public static double Distance(double x1, double x2, double y1, double y2)
    {
        double temp1 = Math.Pow((x2 - x1), 2);
        double temp2 = Math.Pow((y2 - y1), 2);
        double result = Math.Sqrt(temp1 + temp2);
        return result;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter x1 coordinates: ");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please enter y1 coordinates: ");
        double y1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please enter x2 coordinates:");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please enter y2 coordinates: ");
        double y2 = Convert.ToDouble(Console.ReadLine());
        double finalResult1 = Distance(x1, y1, x2, y2);
        Console.WriteLine("Please enter a1 coordinates: ");
        double a1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please enter b1 coordinates: ");
        double b1 = Convert.ToDouble (Console.ReadLine ());
        Console.WriteLine("Please enter a2 coordinates: ");
        double a2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please enter b2 coordinates: ");
        double b2 = Convert.ToDouble(Console.ReadLine());
        double finalResult2 = Distance(a1, b1, a2, b2);
        FinalResult(finalResult1, finalResult2);
    }
    private static void FinalResult(double finalResult1, double finalResult2)
    {
        if (finalResult1 == finalResult2)
        {
            Console.WriteLine("Line-1 and Line-2 are equals.");
        }
        else
        {
            Console.WriteLine("Line - 1 and Line - 2 are not equals.");
        }
            Console.WriteLine("Length of first Line = " + finalResult1);
            Console.WriteLine("Length of second Line = " + finalResult2);
    }
}