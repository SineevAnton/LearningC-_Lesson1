//This programm returns the last digit of an input number

class Task5
{
    public static void fineLastDigit()
    {
        Console.WriteLine("_______________________________________________________________");
        Console.WriteLine("5. Task5. Finding the last digit of an input number.");
        Console.WriteLine();

        Console.WriteLine("Please input a three-digit number (between 100 and 999.)");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("Last digit of " + num + " is" + num % 10);

        Console.WriteLine("_______________________________________________________________");
        Console.WriteLine("Task 5 complete.");
        Console.WriteLine("Enter the number of task, you are interested in or type 'exit'.");
    }
}