// This programm compare three input numbers and return maximal of them.
public class Task2
{
    public static void FindBigger()
    {
        Console.WriteLine(GlobalVars.filler);
        Console.WriteLine("2. Task2. Compare three input numbers and return maximal of them.");
        Console.WriteLine();

        Console.WriteLine("Enter first integer or double (using dot) number.");
        double num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second integer or double (using dot) number.");
        double num2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter third integer or double (using dot) number.");
        double num3 = double.Parse(Console.ReadLine());

        if (num1 == num2 && num1 == num3)
        {
            Console.WriteLine("Numbers are equal.");
        }
        else if (num1 > num2 && num1 > num3)
        {
            Console.WriteLine("The biggest number is " + num1);
        }
        else if (num2 > num3)
        {
            Console.WriteLine("The biggest number is " + num2);
        }
        else
        {
            Console.WriteLine("The biggest number is " + num3);
        }

        Console.WriteLine(GlobalVars.filler);
        Console.WriteLine("Task 2 complete.");
        Console.WriteLine("Enter the number of task, you are interested in or type 'exit'.");
    }
}