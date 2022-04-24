//Please, READ THIS first.
//This is a main part of my homework.
//I put all tasks in one project.
//When you will run this, the programm will allow you to chose what task to check.
//Have a nice day!
Console.WriteLine("Tasks list:");
Console.WriteLine();
Console.WriteLine("1. Task1. Compare two input numbers and return maximal of them.");
Console.WriteLine("2. Task2. Compare three input numbers and return maximal of them.");
Console.WriteLine("3. Task3. Defines is the input number even or odd.");
Console.WriteLine("4. Task4. Write every even number from 1 to input number (N).");
Console.WriteLine();
Console.WriteLine("Enter the number of task, you are interested in.");
Console.WriteLine("Example: if you want to choose Task2 - print '2' without quotes.");
Console.WriteLine("If you want to stop the programm, type 'exit' without quotes.");

bool Flag = true;
string[] correctChoices = {"1","2","3","4","exit"};

while (Flag)
{
    string choice = Console.ReadLine();
    if (correctChoices.Contains(choice.ToLower()))
    {
        switch (choice.ToLower())
        {
            case "1":
                Task1.FindBigger();
                break;
            case "2":
                Task2.FindBigger();
                break;
            case "3":
                Task3.isEven();
                break;
            case "4":
                Task4.showEvenNumbers();
                break;
            case "exit":
                Flag = false;
                break;
        }
    }
    else
    {
        Console.WriteLine("Incorrect input.");
        Console.WriteLine("Please enter one of this: 1, 2, 3, 4 or exit");
    }
}