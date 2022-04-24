// This programm compare two input numbers and return maximal of them.
public class Task1
{
    public static void FindBigger()
    {
        Console.WriteLine("Enter first integer or double (using dot) number.");
        double num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second integer or double (using dot) number.");
        double num2 = double.Parse(Console.ReadLine());
        if (num1 == num2)
        {
            Console.WriteLine("Numbers are equal.");
        }
        else
        {
            Console.WriteLine(num1 > num2 ? "The biggest number is " + num1: "The biggest number is " + num2);
        }
    }

}