//This programm returns the last digit of an input number

class Task5
{
    public static void fineLastDigit()
    {
        Console.WriteLine("_______________________________________________________________");
        Console.WriteLine("5. Task5. Finding the last digit of an input number.");
        Console.WriteLine();

        Console.WriteLine("Please input an integer three-digit number (between 100 and 999).");
        bool flag = true;
        while(flag)
        {
            string str = Console.ReadLine();
            int num;
            bool isNum = int.TryParse(str, out num);
            if (isNum && num >= 100 && num <= 999)
            {
                Console.WriteLine("Last digit of " + num + " is " + num % 10);
                flag = false;
            }
            else
            {
                Console.WriteLine("Incorrect input. Please enter an integer three-digit number.");
            }
        }

        Console.WriteLine("_______________________________________________________________");
        Console.WriteLine("Task 5 complete.");
        Console.WriteLine("Enter the number of task, you are interested in or type 'exit'.");
    }
}