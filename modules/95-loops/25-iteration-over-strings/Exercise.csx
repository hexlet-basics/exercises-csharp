class App
{
    public static void PrintReversedNameBySymbol(string name)
    {
        // BEGIN
        var i = name.Length - 1;
        while (i >= 0)
        {
            Console.WriteLine(name[i]);
            i = i - 1;
        }
        // END
    }
}
