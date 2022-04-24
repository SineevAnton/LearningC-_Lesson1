//This programm defines: the input number is even or odd.
class Task3
{
    public static void isEven()
    {
        Console.WriteLine("Enter integer! number.");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine(num % 2 == 0? num + " is even.": num + " is odd.");
    }
}