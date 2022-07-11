class App
{
    public static String JoinNumbersFromRange(int start, int finish)
    {
        // BEGIN
        var i = start;
        var result = "";

        while (i <= finish)
        {
            result = result + i.ToString();
            i = i + 1;
        }

        return result;
        // END
    }
}
