//This programm defines: the input number is even or odd.
class Task3
{
    public static void isEven()
    {
        Console.WriteLine(GlobalVars.filler);
        Console.WriteLine("3. Task3. Defines is the input number even or odd.");
        Console.WriteLine();
        
        Console.WriteLine("Enter integer! number.");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine(num % 2 == 0? num + " is even.": num + " is odd.");

        Console.WriteLine(GlobalVars.filler);
        Console.WriteLine("Task 3 complete.");
        Console.WriteLine("Enter the number of task, you are interested in or type 'exit'.");
    }
}