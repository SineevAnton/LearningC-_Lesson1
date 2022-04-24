// This programm compare three input numbers and return maximal of them.
public class Task2
{
    public static void FindBigger()
    {
        Console.WriteLine("Enter firs integer or double (using dot) number.");
        double num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second integer or double (using dot) number.");
        double num2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter third integer or double (using dot) number.");
        double num3 = double.Parse(Console.ReadLine());

        if (num1 == num2 & num1 == num3)
        {
            Console.WriteLine("Numbers are equal.");
        }
        else if (num1 >= num2 & num1 >= num3)
        {
            Console.WriteLine("The biggest number is " + num1);
        }
        else if (num2 >= num1 & num2 >= num3)
        {
            Console.WriteLine("The biggest number is " + num2);
        }
        else if (num3 >= num1 & num3 >= num1)
        {
            Console.WriteLine("The biggest number is " + num3);
        }
    }
}