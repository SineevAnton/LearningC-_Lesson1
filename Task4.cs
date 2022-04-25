//This program will write every even number from 1 to input number (N).
//We can solve this task by two methods:
//1. Check every number from 1 to N with % operator in loop and print our number, if number % 2 == 0.
//2. Start printing with i=2 and just append 2 to our number every loop iteration, while i <= N.
//I chose second case, because some kind of first is used in Task3 class.
class Task4
{
    public static void showEvenNumbers()
    {
        Console.WriteLine(GlobalVars.filler);
        Console.WriteLine("4. Task4. Write every even number from 1 to input number (N).");
        Console.WriteLine();

        Console.WriteLine("Enter integer! number.");
        int num = int.Parse(Console.ReadLine());
        for (int i = 2; i <= num; i += 2)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine(); //With this string i just cheked the carriege place at the end of the programm
    
        Console.WriteLine(GlobalVars.filler);
        Console.WriteLine("Task 4 complete.");
        Console.WriteLine("Enter the number of task, you are interested in or type 'exit'.");
    }
}