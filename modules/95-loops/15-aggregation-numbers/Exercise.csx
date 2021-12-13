class App
{
    public static int MultiplyNumbersFromRange(int start, int finish)
    {
        // BEGIN
        var i = start;
        var result = 1;

        while (i <= finish)
        {
            result = result * i;
            i = i + 1;
        }

        return result;
        // END
    }
}
