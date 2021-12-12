class App
{
    // BEGIN
    public static void PrintNumbers(int firstNumber)
    {
        var i = firstNumber;
        while (i >= 1)
        {
            Console.WriteLine(i);
            i = i - 1;
        }
        Console.WriteLine("finished!");
    }
    // END
}
